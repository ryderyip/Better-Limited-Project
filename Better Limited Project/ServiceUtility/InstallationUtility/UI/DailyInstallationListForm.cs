using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Controller;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class DailyInstallationListForm : Form
    {
        private readonly List<Installation> _installations;

        public DailyInstallationListForm()
        {
            _installations = InstallationRepository.FindBy(i => !i.IsInstalled()).ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            dtpDate.Value = DateTime.Today;
            dtpDate.MinDate = _installations.Min(i => i.ScheduledOn.Date);
            dtpDate.MaxDate = _installations.Max(i => i.ScheduledOn.Date);
            dtpDate.ValueChanged += (_, _) => FilterDgv();
            PopulateDgv(_installations);
        }

        private void FilterDgv()
        {
            var filtered = GetDateFilteredInstallations();
            PopulateDgv(filtered);
        }

        private IEnumerable<Installation> GetDateFilteredInstallations()
        {
            return _installations.Where(i => i.ScheduledOn.Date == dtpDate.Value.Date);
        }

        private void PopulateDgv(IEnumerable<Installation> installations)
        {
            dgvInstallations.Rows.Clear();
            foreach (var installation in installations)
                dgvInstallations.Rows.Add(installation.Id,
                    installation.InstallationRequest.SalesOrder.OrderNumber,
                    installation.ScheduledOn.ToShortTimeString(),
                    installation.InstallationRequest.ProductsToInstall.Count());
            dgvInstallations.Sort(orderNumberColumn, ListSortDirection.Descending);
        }

        private void btnGenerateDailyList_Click(object sender, EventArgs e)
        {
            var installations = GetDateFilteredInstallations();
            var generator = new InstallationListGenerator(installations);
            generator.GenerateAndOpen();
        }

        private void btnPrintInstallationList_Click(object sender, EventArgs e)
        {
            var installations = GetDateFilteredInstallations();
            var generator = new InstallationListGenerator(installations);
            generator.GenerateAndPrint();
        }
    }
}