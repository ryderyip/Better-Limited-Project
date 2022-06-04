using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.Tools;

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
            {
                btnArrangeDelivery.Enabled = false;
                btnViewDeliveryDetails.Enabled = true;
            }

            FillFields();
        }

        private void FillFields()
        {
            tbStockStatus.Text = EnumToStringHelper.GetDisplayValue(_deliveryRequest.GetGoodsStatus());
            tbCreatedOn.Text =
                $"{_deliveryRequest.CreatedOn.ToLongDateString()} | {_deliveryRequest.CreatedOn.ToShortTimeString()}";
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
            if (_deliveryRequest.IsArranged())
            {
                MessageBox.Show("Delivery for this request is already arranged!");
                return;
            }

            if (!_deliveryRequest.IsStockReadyForDelivery())
            {
                MessageBox.Show("Delivery can only be arranged once the stock is replenished.");
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

        private void btnViewDeliveryDetails_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f is DeliveryDetailsForm))
                return;
            var form = new DeliveryDetailsForm(_deliveryRequest.GetDeliveries().First());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}