using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.DevTools
{
    public class RandomOrderPlacer
    {
        private readonly Random _random;
        private readonly List<RetailStore> _retailStores;
        private readonly List<RetailStoreStock> _stocks;

        public RandomOrderPlacer()
        {
            _retailStores = new RetailStoreRepository().GetAll().ToList();
            _stocks = _retailStores.SelectMany(rs => StockRepository.GetRetailStoreStocks(rs.Id)).ToList();
            _random = new Random();
        }

        /// <summary>
        ///     Places orders randomly for a specified number of times.
        ///     Cart items and customer info will be selected randomly.
        /// </summary>
        public async Task PlaceOrdersAsync(int numberOfOrders, IProgress<double> progress)
        {
            if (numberOfOrders == 0)
                return;

            await Task.Run(() =>
            {
                foreach (var retailStore in _retailStores)
                    Restock((int) (numberOfOrders * 0.7), retailStore);
            });

            await Task.Run(() =>
            {
                for (var i = 0; i < numberOfOrders; i++)
                {
                    var retailStore = GetRandomRetailStore();
                    var cart = new Cart(retailStore.Id);
                    for (var j = 0; j < _random.Next(1, 15); j++)
                        cart.Add(GetRandomProduct());

                    var salesOrder = GetRandomSalesOrder(retailStore);
                    var salesOrderProducts = cart.GetCartItems().Select(cartItem =>
                        new SalesOrderProduct(salesOrder.Id, cartItem.Product.Id, cartItem.Price, cartItem.Quantity,
                            cartItem.IsOutOfStock)).ToList();

                    var paymentMethod = GetRandomPaymentMethod();
                    var calculator = new SalesOrderCalculator(salesOrderProducts);
                    var nonDepositPayment = new Payment(PaymentRepository.GetNewId(), calculator.GetNonDepositAmount(),
                        paymentMethod, salesOrder.CreatedOn);
                    nonDepositPayment.Save();
                    var depositPayment = new Payment(PaymentRepository.GetNewId(), calculator.GetDepositAmount(),
                        paymentMethod, salesOrder.CreatedOn);
                    depositPayment.Save();

                    salesOrder.Save();
                    // save products and payments
                    salesOrderProducts.ForEach(sop =>
                    {
                        new SalesOrderProductPayment(sop.SalesOrderId, sop.ProductId,
                            sop.IsOutOfStock ? depositPayment.Id : nonDepositPayment.Id,
                            sop.IsOutOfStock).Save();
                        sop.Save();
                    });
                    salesOrder.Save();

                    if (salesOrderProducts.Any(sop => sop.IsOutOfStock))
                    {
                        AddOutOfStockItemsToWaitingList(salesOrderProducts);
                        ReserveInStockProducts(salesOrder, salesOrderProducts);
                    }
                    else
                    {
                        MinusFromStock(salesOrderProducts);
                    }

                    progress.Report(i * 100.0 / numberOfOrders);
                }
            });
        }

        private void MinusFromStock(List<SalesOrderProduct> salesOrderProducts)
        {
            var stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var salesOrderProduct in salesOrderProducts)
            {
                var stock = stocks.First(s => s.Product.Id == salesOrderProduct.ProductId);
                stock.Quantity -= salesOrderProduct.Quantity;
                stock.Save();
            }
        }

        private void ReserveInStockProducts(SalesOrder salesOrder, List<SalesOrderProduct> salesOrderProducts)
        {
            foreach (var salesOrderProduct in salesOrderProducts.Where(sop => !sop.IsOutOfStock))
            {
                var service = new ProductReservationService(salesOrder);
                service.Reserve(salesOrderProduct.ProductId, salesOrderProduct.Quantity);
            }
        }

        private void AddOutOfStockItemsToWaitingList(List<SalesOrderProduct> salesOrderProducts)
        {
            foreach (var salesOrderProduct in salesOrderProducts.Where(sop => sop.IsOutOfStock))
                new SalesOrderProductWaitingForStock(salesOrderProduct.SalesOrderId,
                    salesOrderProduct.ProductId, salesOrderProduct.Quantity).Save();
        }

        private SalesOrder GetRandomSalesOrder(RetailStore retailStore)
        {
            return new SalesOrder(new SalesOrderRepository().GetNewId(),
                SalesOrderNumberGenerator.GetNewOrderNumber(retailStore.Id),
                GetRandomSalesStaff(),
                retailStore,
                GetRandomOrderDate(),
                true)
            {
                Customer = GetRandomCustomerOrNoCustomer()
            };
        }

        private DateTime GetRandomOrderDate()
        {
            var hoursInAMonth = 30 * 24;
            return DateTime.Now - TimeSpan.FromHours(_random.Next(hoursInAMonth * 3));
        }

        private Staff GetRandomSalesStaff()
        {
            var randomSalesStaff = new StaffRepository().GetAll().ToList();
            return randomSalesStaff[_random.Next(randomSalesStaff.Count)];
        }

        private PaymentMethod GetRandomPaymentMethod()
        {
            return _random.Next(3) switch
            {
                0 => PaymentMethod.Cash,
                1 => PaymentMethod.Octopus,
                _ => PaymentMethod.CreditCard
            };
        }

        private Customer? GetRandomCustomerOrNoCustomer()
        {
            var customers = new CustomerRepository().GetAll().ToList();
            var random = _random.Next(-1, customers.Count);
            return random == -1 ? null : customers[random];
        }

        private Product GetRandomProduct()
        {
            return _stocks[_random.Next(_stocks.Count)].Product;
        }

        private void Restock(int numberOfOrders, RetailStore retailStore)
        {
            var restockTool = new RestockTool(retailStore);
            _stocks.ForEach(s => restockTool.AddItem(s.Product, numberOfOrders / _stocks.Count + 1));
            restockTool.Restock();
        }

        private static RetailStore GetRandomRetailStore()
        {
            var random = new Random();
            return random.Next(3) == 1
                ? new RetailStoreRepository().GetAll().First()
                : new RetailStoreRepository().GetAll().Last();
        }
    }
}