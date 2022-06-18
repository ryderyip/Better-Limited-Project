using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.ServiceUtility.DeliveryUtility;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class ManageSalesOrderForm : Form
    {
        public EventHandler? SalesOrderUpdated;
        private readonly SalesOrder _salesOrder;

        public ManageSalesOrderForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnManageDelivery_Click(object sender, EventArgs e)
        {
            var deliveryRequest = _salesOrder.GetDeliveryRequest();
            if (deliveryRequest != default)
            {
                if (deliveryRequest.IsArranged())
                {
                    MessageBox.Show(PaymentStringResources.cant_remove_delivery_request);
                    return;
                }
                AskForAndRemoveDeliveryRequest(deliveryRequest);
                return;
            }

            if (_salesOrder.GetSalesOrderProducts().Any(sop => !sop.IsOutOfStock))
            {
                MessageBox.Show("Currently you can only add a delivery to sales orders whose products are all waiting for stock.");
                return;
            }
            
            if (_salesOrder.Customer == null)
            {
                var confirmResult = MessageBox.Show(PaymentStringResources.create_customer_information_to_request_delivery,
                    CreateCustomerRecordForm.lblHeader_Text, MessageBoxButtons.YesNo);
                if (confirmResult is DialogResult.Yes)
                    CreateCustomerRecord();
                return;
            }
            
            AskForDeliverySessionAndSendDeliveryRequest();
        }

        private void CreateCustomerRecord()
        {
            var form = new IsFirstTimeCustomerSelectionForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.IsFirstTimeCustomerSelected += (_, isFirstTime) =>
            {
                if (isFirstTime)
                    StartCreateCustomerForm();
                else
                    StartFindCustomerRecordForm();
            };
            form.ShowDialog();
        }

        private void StartFindCustomerRecordForm()
        {
            var findCustomerForm = new FindCustomerRecordForm();
            findCustomerForm.StartPosition = FormStartPosition.CenterScreen;
            findCustomerForm.CustomerRecordFound += (_, customer) =>
            {
                _salesOrder.Customer = customer;
                _salesOrder.Save();
                SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            findCustomerForm.ShowDialog();
        }

        private void StartCreateCustomerForm()
        {
            var createCustomerRecordForm = new CreateCustomerRecordForm();
            createCustomerRecordForm.StartPosition = FormStartPosition.CenterScreen;
            createCustomerRecordForm.CustomerCreated += (_, customer) =>
            {
                _salesOrder.Customer = customer;
                _salesOrder.Save();
                SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            createCustomerRecordForm.ShowDialog();
        }

        private void AskForAndRemoveDeliveryRequest(DeliveryRequest deliveryRequest)
        {
            var confirmResult = MessageBox.Show(PaymentStringResources.askRemoveDeliveryRequest,
                PaymentStringResources.removeDeliveryRequest, MessageBoxButtons.YesNo);
            if (confirmResult is DialogResult.Yes)
            {
                if (deliveryRequest.IsArranged())
                {
                    MessageBox.Show(PaymentStringResources.removeDeliveryRequestFail);
                    return;
                }

                deliveryRequest.Remove();
                _salesOrder.Save();
                Close();
                SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void AskForDeliverySessionAndSendDeliveryRequest()
        {
            var confirmResult = MessageBox.Show(PaymentStringResources.askSendDeliveryRequest,
                PaymentStringResources.sendDeliveryRequest, MessageBoxButtons.YesNo);
            if (confirmResult is not DialogResult.Yes)
                return;
            
            var form = new DeliverySessionSelectionForm();
            form.SessionSelected += (_, session) =>
            {
                new DeliveryService().SendRequest(_salesOrder, session);
                MessageBox.Show(PaymentStringResources.deliveryRequestSent);
                Close();
                SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (!_salesOrder.IsRemovable())
            {
                MessageBox.Show("Current sales order has already been arranged a delivery or installation. Cancellation failed.");
                return;
            }

            var result =
                MessageBox.Show(
                    "This will completely erase all information regarding this sales order. No refund will be given. Proceed to cancel?",
                    "Confirm Cancellation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;

            _salesOrder.SetAsInactiveAndSave();
            SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}