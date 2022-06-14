using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class DeliveryRequestListForm : Form
    {
        private List<DeliveryRequest> _deliveryRequests;
        private readonly List<SalesOrder> _salesOrders;

        public DeliveryRequestListForm()
        {
            _deliveryRequests = DeliveryRequestRepository.GetAll().ToList();
            _salesOrders = new SalesOrderRepository()
                .FindAll(so => _deliveryRequests.Any(dr => dr.SalesOrderId == so.Id)).ToList();
            Shown += (_, _) => ApplyFilterOnDgv();
            InitializeComponent();
        }

        private void tbSearchBox_TextChanged(object sender, System.EventArgs e)
        {
            ApplyFilterOnDgv();
        }
        
        private void cbShowArrangedRequests_CheckedChanged(object sender, System.EventArgs e)
        {
            ApplyFilterOnDgv();
        }

        private void ApplyFilterOnDgv()
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var requests = _deliveryRequests.Where(dr => _salesOrders.Find(so => so.Id == dr.SalesOrderId)
                    .OrderNumber.ToLower().Contains(searchKeyword));
            requests = !cbShowArrangedRequests.Checked ? requests.Where(dr => !dr.IsArranged()) : requests;

            PopulateDgv(requests);
        }

        private void PopulateDgv(IEnumerable<DeliveryRequest> requests)
        {
            dgvDeliveryRequests.Rows.Clear();
            foreach (var request in requests)
            {
                string orderNumber = _salesOrders.Find(so => so.Id == request.SalesOrderId).OrderNumber;
                dgvDeliveryRequests.Rows.Add(orderNumber, 
                    request.CreatedOn.ToString("g"),
                    request.ArrangedOn.HasValue ? 
                        request.ArrangedOn.Value.ToString("g") : "-",
                    request.DeliverySession.ToString());
            }
            dgvDeliveryRequests.Sort(createdOnColumn, ListSortDirection.Descending);
        }

        private void dgvDeliveryRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedOrderNumber = dgvDeliveryRequests.Rows[e.RowIndex].Cells[orderNumberColumn.Name].Value.ToString();
            string selectedSalesOrderId = _salesOrders.Find(so => so.OrderNumber == selectedOrderNumber).Id;
            var selectedDeliveryRequest = _deliveryRequests.Find(dr => dr.SalesOrderId == selectedSalesOrderId);
            var form = new DeliveryRequestDetailsForm(selectedDeliveryRequest);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.InfoUpdated += (_, _) => RefreshRequests();
            form.ShowDialog();
        }

        private void RefreshRequests()
        {
            _deliveryRequests = DeliveryRequestRepository.GetAll().ToList();
            ApplyFilterOnDgv();
        }
    }
}
