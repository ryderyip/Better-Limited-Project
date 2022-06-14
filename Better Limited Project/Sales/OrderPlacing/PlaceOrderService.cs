using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.PaymentUtility.UI;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.ServiceUtility.DeliveryUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Controller;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class PlaceOrderService
    {
        private readonly SalesOrder _order;
        private readonly List<SalesOrderProduct> _salesOrderProduct;
        public event EventHandler? SalesOrderPlaced;
        public bool IsNeedDelivery { get; set; }
        public bool IsNeedInstallation { get; set; }
        private readonly SalesOrderCalculator _calculator;

        public PlaceOrderService(Cart cart, Customer? customer = null)
        {
            var composer = new SalesOrderComposer(cart, customer);
            _order = composer.GetSalesOrder();
            _salesOrderProduct = composer.GetSalesOrderProducts().ToList();
            _calculator = new SalesOrderCalculator(_salesOrderProduct);
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
            var amountDue = _calculator.GetNonDepositAmount() + _calculator.GetDepositAmount();
            var form = PaymentFormFactory.Generate(amountDue, method);
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
            var service = new InstallationRequestService(_order.Id);
            service.AddProductRange(_salesOrderProduct);
            service.SendRequest();
            MessageBox.Show("Installation service request sent.");
        }

        private void SaveSalesOrderToDatabase(PaymentMethod paymentMethod)
        {
            var nonDepositPayment = new Payment(_calculator.GetNonDepositAmount(), paymentMethod);
            nonDepositPayment.Save();
            var depositPayment = new Payment(_calculator.GetDepositAmount(), paymentMethod);
            depositPayment.Save();

            _order.Save();
            // save products and payments
            _salesOrderProduct.ForEach(sop =>
            {
                new SalesOrderProductPayment(sop.SalesOrderId, sop.ProductId,
                    sop.IsOutOfStock ? depositPayment.Id : nonDepositPayment.Id,
                    isDeposit: sop.IsOutOfStock).Save();
                sop.Save();
            });
            _order.Save();

            if (_salesOrderProduct.Any(sop => sop.IsOutOfStock))
            {
                AddOutOfStockItemsToWaitingList();
                ReserveInStockProducts();
            }
            else
                MinusFromStock();
        }

        private void MinusFromStock()
        {
            var stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var salesOrderProduct in _salesOrderProduct)
            {
                var stock = stocks.First(s => s.Product.Id == salesOrderProduct.ProductId);
                stock.Quantity -= salesOrderProduct.Quantity;
                stock.Save();
            }
        }

        private void ReserveInStockProducts()
        {
            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => !sop.IsOutOfStock))
            {
                var service = new ProductReservationService(_order);
                service.Reserve(salesOrderProduct.ProductId, salesOrderProduct.Quantity);
            }
        }

        private void AddOutOfStockItemsToWaitingList()
        {
            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => sop.IsOutOfStock))
                new SalesOrderProductWaitingForStock(salesOrderProduct.SalesOrderId,
                    salesOrderProduct.ProductId, salesOrderProduct.Quantity).Save();
        }

        private void CompleteOrderPlacing()
        {
            MessageBox.Show(OrderPlacingStringResources.order_placed);
            // TODO turned off for easy debug
            /*if (_salesOrderProduct.Any(sop => sop.IsOutOfStock))
                new DepositReceiptGenerator(_order).GenerateAndOpen();
            if (_salesOrderProduct.Any(sop => !sop.IsOutOfStock))
                new PaymentReceiptGenerator(_order).GenerateAndOpen();*/
            SalesOrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}