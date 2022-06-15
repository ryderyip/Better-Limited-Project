using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.PaymentUtility.UI;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.ServiceUtility.DeliveryUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Controller;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class PlaceOrderHandler
    {
        private readonly SalesOrder _order;
        private readonly List<SalesOrderProduct> _salesOrderProduct;
        public event EventHandler? SalesOrderPlaced;
        public bool IsNeedDelivery { get; set; }
        public bool IsNeedInstallation { get; set; }

        public PlaceOrderHandler(Cart cart, Customer? customer = null)
        {
            var composer = new SalesOrderComposer(cart, customer);
            _order = composer.GetSalesOrder();
            _salesOrderProduct = composer.GetSalesOrderProducts().ToList();
        }

        public void PlaceOrder()
        {
            var form = new ConfirmPlacingOrderForm(_order, _salesOrderProduct);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OrderConfirmed += (_, _) => SelectPaymentMethod();
            form.ShowDialog();
        }

        private void SelectPaymentMethod()
        {
            var form = new PaymentMethodSelectionForm();
            form.Selected += (_, method) => OpenPaymentForm(method);
            form.ShowDialog();
        }

        private void OpenPaymentForm(PaymentMethod method)
        {
            SalesOrderCalculator calculator = new(_salesOrderProduct);
            var amountDue = calculator.GetNonDepositAmount() + calculator.GetDepositAmount();
            var form = PaymentFormFactory.Generate(amountDue, method);
            form.PaymentCompleted += (_, paymentMethod) =>
            {
                new PlaceOrderService(_order, _salesOrderProduct).PlaceOrder(paymentMethod);
                if (IsNeedDelivery)
                    SelectDeliverySessionAndSendDeliveryRequest();
                if (IsNeedInstallation)
                    SendInstallationServiceRequest();

                CompleteOrderPlacing();
            };
            form.ShowForm();
        }

        private void SelectDeliverySessionAndSendDeliveryRequest()
        {
            var form = new DeliverySessionSelectionForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SessionSelected += (_, session) =>
            {
                new DeliveryService().SendRequest(_order, session);
                MessageBox.Show(ServiceUtilityStringResources.delivery_request_sent);
            };
            form.ShowDialog();
        }

        private void SendInstallationServiceRequest()
        {
            var service = new InstallationRequestService(_order.Id);
            service.AddProductRange(_salesOrderProduct);
            service.SendRequest();
            MessageBox.Show("Installation service request sent.");
        }

        private void CompleteOrderPlacing()
        {
            MessageBox.Show(OrderPlacingStringResources.order_placed);
            _order.Save();
            // TODO turned off for easy debug
            /*if (_salesOrderProduct.Any(sop => sop.IsOutOfStock))
                new DepositReceiptGenerator(_order).GenerateAndOpen();
            if (_salesOrderProduct.Any(sop => !sop.IsOutOfStock))
                new PaymentReceiptGenerator(_order).GenerateAndOpen();*/
            SalesOrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}