using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class TechnicianListForm : Form
    {
        private List<Technician> _technicians;

        public TechnicianListForm()
        {
            _technicians = TechnicianRepository.GetAll().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            tbSearchBar.TextChanged += (_, _) => FilterDgv();
            PopulateDgv(_technicians);
        }

        private void FilterDgv()
        {
            string searchKeyword = tbSearchBar.Text.Trim().ToLower();
            var filtered = _technicians.Where(t => t.Name.ToLower().Contains(searchKeyword) || t.Phone.Contains(searchKeyword));
            PopulateDgv(filtered);
        }

        private void PopulateDgv(IEnumerable<Technician> technicians)
        {
            dgvInstallationRequests.Rows.Clear();
            foreach (var technician in technicians)
                dgvInstallationRequests.Rows.Add(technician.Id, technician.Name, technician.Phone);
            dgvInstallationRequests.Sort(nameColumn, ListSortDirection.Ascending);
        }

        private void dgvInstallationRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = _technicians.Find(t =>
                t.Id == dgvInstallationRequests.Rows[e.RowIndex].Cells[idCOlumn.Name].Value.ToString());
            var form = new TechnicianDetailsForm(selected);
            form.ShowDialog();
            form.TechnicianUpdated += (_, _) => RefreshForm();
        }

        private void RefreshForm()
        {
            _technicians = TechnicianRepository.GetAll().ToList();
            Initialize();
        }

        private void btnNewTechnician_Click(object sender, System.EventArgs e)
        {
            var form = new TechnicianCreateUpdateForm();
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                RefreshForm();
        }
    }
}
