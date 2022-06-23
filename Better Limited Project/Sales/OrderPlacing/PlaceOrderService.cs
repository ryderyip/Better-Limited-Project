using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class PlaceOrderService
    {
        private readonly SalesOrderCalculator _calculator;
        private readonly SalesOrder _salesOrder;
        private readonly List<SalesOrderProduct> _salesOrderProduct;

        public PlaceOrderService(SalesOrder salesOrder, IEnumerable<SalesOrderProduct> salesOrderProduct)
        {
            _salesOrder = salesOrder;
            _salesOrderProduct = salesOrderProduct.ToList();
            _calculator = new SalesOrderCalculator(_salesOrderProduct);
        }

        public void PlaceOrder(PaymentMethod paymentMethod)
        {
            var nonDepositPayment = new Payment(_calculator.GetNonDepositAmount(), paymentMethod);
            nonDepositPayment.Save();
            var depositPayment = new Payment(_calculator.GetDepositAmount(), paymentMethod);
            depositPayment.Save();

            _salesOrder.Save();
            // save products and payments
            _salesOrderProduct.ForEach(sop =>
            {
                new SalesOrderProductPayment(sop.SalesOrderId, sop.ProductId,
                    sop.IsOutOfStock ? depositPayment.Id : nonDepositPayment.Id,
                    sop.IsOutOfStock).Save();
                sop.Save();
            });

            if (_salesOrderProduct.Any(sop => sop.IsOutOfStock))
            {
                AddOutOfStockItemsToWaitingList();
                ReserveInStockProducts();
            }
            else
            {
                MinusFromStock();
            }
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
                var service = new ProductReservationService(_salesOrder);
                service.Reserve(salesOrderProduct.ProductId, salesOrderProduct.Quantity);
            }
        }

        private void AddOutOfStockItemsToWaitingList()
        {
            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => sop.IsOutOfStock))
                new SalesOrderProductWaitingForStock(salesOrderProduct.SalesOrderId,
                    salesOrderProduct.ProductId, salesOrderProduct.Quantity).Save();
        }
    }
}