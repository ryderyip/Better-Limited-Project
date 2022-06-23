using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class InstallationRequestListForm : Form
    {
        private List<InstallationRequest> _requests;

        public InstallationRequestListForm()
        {
            _requests = InstallationRequestRepository.GetAll().ToList();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            PopulateDgv(_requests);
        }

        private void FilterDgv()
        {
            string searchKeywords = tbSearchBox.Text.Trim().ToLower();
            var filtered = _requests.Where(r => r.SalesOrder.OrderNumber.ToLower().Contains(searchKeywords));
            PopulateDgv(filtered.ToList());
        }

        private void PopulateDgv(List<InstallationRequest> requests)
        {
            dgvInstallationRequests.Rows.Clear();
            requests.ForEach(r => dgvInstallationRequests.Rows.Add(r.Id, r.SalesOrder.OrderNumber,
                r.SalesOrder.CreatedOn.ToString("g"),
                r.IsArranged() ? "Yes" : "No",
                r.ArrangedOn?.ToString("g") ?? "-"));
            dgvInstallationRequests.Sort(orderNumberColumn, ListSortDirection.Descending);
        }

        private void dgvInstallationRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRequest = _requests.Find(r =>
                r.Id == dgvInstallationRequests.Rows[e.RowIndex].Cells[instllationRequestIdColumn.Name].Value
                    .ToString());
            var form = new InstallationRequestDetailsForm(selectedRequest);
            form.InfoUpdated += (_, _) => RefreshRequests();
            form.ShowDialog();
        }

        private void RefreshRequests()
        {
            _requests = InstallationRequestRepository.GetAll().ToList();
            Initialize();
        }
    }
}