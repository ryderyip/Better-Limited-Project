using System;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class TechnicianDetailsForm : Form
    {
        public event EventHandler? TechnicianUpdated;
        private Technician _technician;

        public TechnicianDetailsForm(Technician technician)
        {
            _technician = technician;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            tbName.Text = _technician.Name;
            tbPhone.Text = _technician.Phone;
            if (_technician.HasAppointedIncompleteInstallation())
                btnRemove.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new TechnicianCreateUpdateForm();
            var result = form.ShowDialog();
            if (result is not DialogResult.OK) 
                return;
            RefreshForm();
            TechnicianUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshForm()
        {
            _technician = TechnicianRepository.FindById(_technician.Id);
            Initialize();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _technician.Remove();
            TechnicianUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
