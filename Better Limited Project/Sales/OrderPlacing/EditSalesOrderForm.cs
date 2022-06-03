using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.ServiceUtility.Delivery;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class EditSalesOrderForm : Form
    {
        public EventHandler? SalesOrderUpdated;
        private readonly SalesOrder _salesOrder;

        public EditSalesOrderForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            InitializeComponent();
        }

        private void btnManageDelivery_Click(object sender, EventArgs e)
        {
            var deliveryRequest = DeliveryRequestRepository.FindAll(dr => dr.SalesOrderId == _salesOrder.Id)
                .FirstOrDefault();
            if (deliveryRequest != default)
            {
                var confirmResult = MessageBox.Show("Current sales order has requested for a delivery.\n" +
                                                    "Confirm removing delivery request?",
                    "Removing Delivery Request", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (deliveryRequest.IsArranged())
                    {
                        MessageBox.Show("This delivery has already been confirmed by inventory department.\n" +
                                        "Delivery request removal failed.");
                        return;
                    }

                    deliveryRequest.Remove();
                    Close();
                    SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Current sales order has not requested for a delivery.\n" +
                                                    "Confirm sending a delivery request for this order?",
                    "Sending Delivery Request", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                    AskForDeliverySessionAndSendDeliveryRequest();
            }
        }

        private void AskForDeliverySessionAndSendDeliveryRequest()
        {
            var form = new DeliverySessionSelectionForm();
            form.SessionSelected += (_, session) =>
            {
                new DeliveryService().SendRequest(_salesOrder, session);
                MessageBox.Show("Delivery request sent.");
                Close();
                SalesOrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}