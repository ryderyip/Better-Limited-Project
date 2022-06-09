using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.PaymentUtility.UI;
using Better_Limited_Project.ServiceUtility.Delivery;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ServiceUtility
{
    public class PlaceOrderService
    {
        private readonly SalesOrder _order;
        private readonly List<SalesOrderProduct> _salesOrderProduct;
        public event EventHandler? SalesOrderPlaced;
        public bool IsNeedDelivery { get; set; }
        public bool IsNeedInstallation { get; set; }
        private readonly decimal _amountDue;

        public PlaceOrderService(Cart cart, Customer? customer = null)
        {
            var composer = new SalesOrderComposer(cart, customer);
            _order = composer.GetSalesOrder();
            _salesOrderProduct = composer.GetSalesOrderProducts().ToList();
            
            var calculator = new SalesOrderCalculator(_salesOrderProduct);
            _amountDue = calculator.GetInStockItemPrice() + calculator.GetDepositAmount();
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
            var form = PaymentFormFactory.Generate(_amountDue, method);
            form.PaymentCompleted += (_, paymentMethod) =>
            {
                SaveSalesOrderToDatabase(paymentMethod);
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
            var service = new InstallationService();
            service.SendRequest(_order);
        }

        private void SaveSalesOrderToDatabase(PaymentMethod paymentMethod)
        {
            var payment = new Payment(_amountDue, paymentMethod);
            payment.PaidOn = DateTime.Now;
            payment.Save();
            
            _order.Save();

            _salesOrderProduct.ToList()
                .ForEach(sop =>
                {
                    var payments = sop.GetProductPayments().ToList();
                    payments.Add(new SalesOrderProductPayment(sop.SalesOrderId, sop.ProductId,
                        payment.Id, sop.Quantity, sop.IsOutOfStock));
                    payments.ToList().ForEach(p =>
                    {
                        p.SalesOrderId = sop.SalesOrderId;
                        p.Save();
                    });
                    sop.Save();
                });

            var stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => !sop.IsOutOfStock))
            {
                var stock = stocks.First(s => s.Product.Id == salesOrderProduct.ProductId);
                stock.Quantity -= salesOrderProduct.Quantity;
                stock.Save();
            }
                
            var reservationService = new ProductReservationService(_order);
            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => sop.IsOutOfStock))
                reservationService.Reserve(salesOrderProduct.ProductId, salesOrderProduct.Quantity);
        }
        
        private void CompleteOrderPlacing()
        {
            MessageBox.Show(OrderPlacingStringResources.order_placed);
            if (_salesOrderProduct.Any(sop => sop.IsOutOfStock))
                new DepositReceiptGenerator(_order).GenerateAndOpen();
            if (_salesOrderProduct.Any(sop => !sop.IsOutOfStock))
                new PaymentReceiptGenerator(_order).GenerateAndOpen();
            SalesOrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}