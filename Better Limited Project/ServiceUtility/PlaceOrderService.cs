using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.ServiceUtility.Delivery;

namespace Better_Limited_Project.ServiceUtility
{
    public class PlaceOrderService
    {
        private readonly SalesOrder _order;
        private readonly List<SalesOrderProduct> _salesOrderProduct;
        public event EventHandler? SalesOrderPlaced;
        public bool IsNeedDelivery { get; set; }
        public bool IsNeedInstallation { get; set; }

        public PlaceOrderService(Cart cart, Customer? customer = null)
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
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Selected += (_, method) => OpenPaymentForm(method);
            form.ShowDialog();
        }

        private void OpenPaymentForm(PaymentMethod method)
        {
            var calculator = new SalesOrderCalculator(_order);
            decimal amountDue = calculator.GetInStockItemPrice() + calculator.GetDepositAmount();
            var form = PaymentFormFactory.Generate(amountDue, method);
            form.PaymentCompleted += (_, payment) =>
            {
                SaveSalesOrderToDatabase(payment);
                if (IsNeedDelivery)
                    SelectDeliverySessionAndSendDeliveryRequest();
                if (IsNeedInstallation)
                    SendInstallationServiceRequest();
            };
            form.ShowForm();
        }

        private void SelectDeliverySessionAndSendDeliveryRequest()
        {
            var form = new DeliverySessionSelectionForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SessionSelected += (_, session) => new DeliveryService().SendRequest(_order, session);
            form.ShowDialog();
        }

        private void SendInstallationServiceRequest()
        {
            var service = new InstallationService();
            service.SendRequest(_order);
        }

        private void SaveSalesOrderToDatabase(Payment payment)
        {
            _order.Save();

            _salesOrderProduct.ToList()
                .ForEach(sop =>
                {
                    var payments = sop.GetPayments().ToList();
                    payments.Add(new SalesOrderProductPayment(sop.SalesOrderId, sop.ProductId,
                        payment.Id, sop.Quantity, sop.IsOutOfStock));
                    payments.ToList().ForEach(p =>
                    {
                        p.SalesOrderId = sop.SalesOrderId;
                        p.Save();
                    });
                    sop.Save();
                });

            var reservationService = new ProductReservationService();
            foreach (var salesOrderProduct in _salesOrderProduct)
                reservationService.Reserve(salesOrderProduct.SalesOrderId, salesOrderProduct.ProductId, salesOrderProduct.Quantity);

            SalesOrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}