using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    public partial class DeliveryRequestDetailsForm : Form
    {
        public event EventHandler? InfoUpdated;
        private DeliveryRequest _deliveryRequest;

        public DeliveryRequestDetailsForm(DeliveryRequest deliveryRequest)
        {
            _deliveryRequest = deliveryRequest;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (_deliveryRequest.IsArranged())
                btnArrangeDelivery.Enabled = false;
            FillFields();
        }
        
        private void FillFields()
        {
            tbCreatedOn.Text =
                $"{_deliveryRequest.CreateOn.ToLongDateString()} | {_deliveryRequest.CreateOn.ToShortTimeString()}";
            tbCreatedIn.Text = _deliveryRequest.GetSalesOrder().RetailStore.Name;
            tbCreatedBy.Text = $"{_deliveryRequest.GetCreatedByStaff().Name}";
            tbArrangedOn.Text = _deliveryRequest.ArrangedOn.HasValue
                ? $"{_deliveryRequest.ArrangedOn.Value.ToLongDateString()} | {_deliveryRequest.ArrangedOn.Value.ToShortTimeString()}"
                : "-";
            var arrangedByStaff = _deliveryRequest.GetArrangedByStaff();
            tbArrangedBy.Text = arrangedByStaff != null
                ? $"{arrangedByStaff.Name}"
                : "-";
            tbDeliverySession.Text = _deliveryRequest.DeliverySession.ToString();
        }

        private void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            var form = new SalesOrderDetailsForm(_deliveryRequest.GetSalesOrder());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnArrangeDelivery_Click(object sender, EventArgs e)
        {
            if (_deliveryRequest.GetSalesOrder().SalesOrderProducts.Any(sop => sop.IsOutOfStock))
            {
                var order = _deliveryRequest.GetSalesOrder();
                var outOfStockProductNames = order.SalesOrderProducts.ToList().Select(sop => sop.GetProduct().Name);
                MessageBox.Show($"{order.RetailStore.Name} does not have enough stock " +
                                $"for the following product(s):\n" +
                                $"{string.Join("\n", outOfStockProductNames)}\n" +
                                $""); // TODO fix logic
                return;
            }

            var controller = new ArrangeDeliveryController(_deliveryRequest);
            controller.DeliveryArranged += (_, _) =>
            {
                RefreshData();
                InfoUpdated?.Invoke(this, EventArgs.Empty);
            };
            controller.OpenForm();
        }

        private void RefreshData()
        {
            _deliveryRequest = DeliveryRequestRepository.FindById(_deliveryRequest.Id);
            Initialize();
        }
    }
}