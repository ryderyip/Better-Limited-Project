using System;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

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
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbCreatedOn.Text =
                $"{_deliveryRequest.CreateOn.ToLongDateString()} | {_deliveryRequest.CreateOn.ToShortTimeString()}";
            tbCreatedBy.Text = $"{_deliveryRequest.CreatedBy.Name} ({_deliveryRequest.CreatedBy.Id})";
            tbArrangedOn.Text = _deliveryRequest.ArrangedOn.HasValue
                ? $"{_deliveryRequest.ArrangedOn.Value.ToLongDateString()} | {_deliveryRequest.ArrangedOn.Value.ToShortTimeString()}"
                : "-";
            tbArrangedBy.Text = _deliveryRequest.ArrangedBy != null
                ? $"{_deliveryRequest.ArrangedBy.Name} ({_deliveryRequest.ArrangedBy.Id})"
                : "-";
            tbDeliverySession.Text = _deliveryRequest.DeliverySession.ToString();
        }

        private void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            var order = new SalesOrderRepository().FindById(_deliveryRequest.SalesOrderId);
            var form = new SalesOrderDetailsForm(order);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnArrangeDelivery_Click(object sender, EventArgs e)
        {
            
        }
    }
}