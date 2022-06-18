using System;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class TechnicianCreateUpdateForm : Form
    {
        private readonly Technician? _technician;

        public TechnicianCreateUpdateForm(Technician? technician = null)
        {
            _technician = technician;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            if (technician != null)
                Load += (_, _) => FillOldTechnicianInfo(technician);
        }

        private void FillOldTechnicianInfo(Technician technician)
        {
            tbName.Text = technician.Name;
            tbPhone.Text = technician.Phone;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string phone = tbPhone.Text.Trim();

            if (HasAnyUnfilledField(name, phone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            
            if (!CommonInformationVerifier.IsValidPhoneNumber(phone))
            {
                MessageBox.Show($"{phone} is not a valid phone number. Please enter a valid Hong Kong phone number.");
                return;
            }

            if (_technician == null)
                new Technician(name, phone).Save();
            else
            {
                _technician.Name = name;
                _technician.Phone = phone;
                _technician.Save();
            }
            DialogResult = DialogResult.OK;
        }

        private bool HasAnyUnfilledField(string nameField, string phoneField)
        {
            return string.IsNullOrWhiteSpace(nameField) || string.IsNullOrWhiteSpace(phoneField);
        }
    }
}
