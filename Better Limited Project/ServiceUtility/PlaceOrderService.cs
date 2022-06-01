using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.ServiceUtility.Delivery;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ServiceUtility
{
    public class PlaceOrderService
    {
        private readonly Cart _cart;
        private readonly Customer? _customer;
        public event EventHandler? SalesOrderPlaced;
        public bool IsNeedDelivery { get; set; }
        public bool IsNeedInstallation { get; set; }

        public PlaceOrderService(Cart cart, Customer? customer = null)
        {
            _cart = cart;
            _customer = customer;
        }

        public void PlaceOrder()
        {
            var order = SalesOrderComposer.Compose(_cart, _customer);
            var form = new ConfirmPlacingOrderForm(order);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OrderConfirmed += (_, _) => SelectPaymentMethod(order);
            form.ShowDialog();
        }

        private void SelectPaymentMethod(SalesOrder salesOrder)
        {
            var form = new PaymentMethodSelectionForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Selected += (_, method) => OpenPaymentForm(salesOrder, method);
            form.ShowDialog();
        }

        private void OpenPaymentForm(SalesOrder salesOrder, PaymentMethod method)
        {
            decimal amountDue = salesOrder.GetInStockItemPrice() + salesOrder.GetDepositPrice();
            var form = PaymentFormFactory.Generate(amountDue, method);
            form.PaymentCompleted += (_, payment) =>
            {
                SaveSalesOrderToDatabase(salesOrder, payment);
                if (IsNeedDelivery)
                    SelectDeliverySessionAndSendDeliveryRequest(salesOrder);
                if (IsNeedInstallation)
                    SendInstallationServiceRequest(salesOrder);
            };
            form.ShowForm();
        }

        private void SelectDeliverySessionAndSendDeliveryRequest(SalesOrder salesOrder)
        {
            var form = new DeliverySessionSelectionForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SessionSelected += (_, session) => new DeliveryService().SendRequest(salesOrder, session);
            form.ShowDialog();
        }

        private void SendInstallationServiceRequest(SalesOrder salesOrder)
        {
            var service = new InstallationService();
            service.SendRequest(salesOrder);
        }

        private void SaveSalesOrderToDatabase(SalesOrder salesOrder, Payment payment)
        {
            salesOrder.Save();
            
            salesOrder.SalesOrderProducts.Where(sop => !sop.IsOutOfStock).ToList()
                .ForEach(sop =>
                {
                    sop.Payments.Add(new SalesOrderProductPayment(sop.SalesOrderId, sop.Product.Id,
                        payment.Id, sop.Quantity, sop.IsOutOfStock));
                    sop.Payments.ToList().ForEach(p =>
                    {
                        p.SalesOrderId = sop.SalesOrderId;
                        p.Save();
                    });
                    sop.Save();
                });
            
            var stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var salesOrderProduct in salesOrder.SalesOrderProducts)
            {
                var stock = stocks.First(stock => stock.Product.Id == salesOrderProduct.Product.Id);
                stock.Quantity -= salesOrderProduct.Quantity;
                if (stock.Quantity < 0)
                    stock.Quantity = 0;
                stock.Update();
            }

            SalesOrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}