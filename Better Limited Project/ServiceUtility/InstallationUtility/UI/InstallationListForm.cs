using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class InstallationListForm : Form
    {
        private List<Installation> _installations;

        public InstallationListForm()
        {
            _installations = InstallationRepository.GetAll().ToList();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            dgvInstallations.Rows.Clear();
            _installations.ForEach(i => dgvInstallations.Rows.Add(i.Id,
                i.InstallationRequest.SalesOrder.OrderNumber,
                i.ScheduledOn,
                i.InstalledOn?.ToString("g") ?? "-"));
            dgvInstallations.Sort(orderNumberColumn, ListSortDirection.Descending);
        }

        private void dgvInstallations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = _installations.Find(i =>
                i.Id == dgvInstallations.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString());
            var form = new InstallationDetailsForm(selected);
            form.InfoUpdated += (_, _) => RefreshForm();
            form.ShowDialog();
        }

        private void RefreshForm()
        {
            _installations = InstallationRepository.GetAll().ToList();
            Initialize();
        }

        private void btnDailyList_Click(object sender, EventArgs e)
        {
            var installations = InstallationRepository.FindBy(i => !i.IsInstalled()).ToList();
            if (installations.Count == 0)
            {
                MessageBox.Show("There are no appointed installations");
                return;
            }
            var form = new DailyInstallationListForm(installations);
            form.ShowDialog();
        }
    }
}