using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrderProduct
    {
        public SalesOrderProduct(string salesOrderId, string productId, decimal price, int quantity, bool isOutOfStock)
        {
            SalesOrderId = salesOrderId;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
            IsOutOfStock = isOutOfStock;
        }

        public string SalesOrderId { get; set; }
        public string ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsOutOfStock { get; set; }
        public ICollection<string> SalesOrderProductPaymentIds { get; set; } = new List<string>();

        public void Save()
        {
            var repo = new SalesOrderProductRepository();
            repo.InsertOrUpdate(this);
        }

        public SalesOrderProductPaymentStatus GetPaymentStatus()
        {
            var payments = GetProductPayments().ToList();
            decimal due = Price * Quantity;
            if (payments.Sum(sopp => sopp.GetPayment().Amount) >= due)
                return SalesOrderProductPaymentStatus.FullyPaid;
            return payments.Any()
                ? SalesOrderProductPaymentStatus.DepositPaid
                : SalesOrderProductPaymentStatus.AwaitingPayment;
        }

        public IEnumerable<SalesOrderProductPayment> GetProductPayments()
        {
            return SalesOrderProductPaymentRepository.GetByIds(SalesOrderId, ProductId);
        }

        public Product GetProduct()
        {
            return ProductRepository.FindById(ProductId);
        }

        public ReservedSalesOrderProduct? GetReservedStock()
        {
            return ReservedSalesOrderProductRepository.FindByIds(SalesOrderId, ProductId);
        }

        public bool IsStockReady()
        {
            var reservedSalesOrderProduct = GetReservedStock();
            return !IsOutOfStock
                   || reservedSalesOrderProduct != null
                   && reservedSalesOrderProduct.Quantity == Quantity;
        }

        public void Remove()
        {
            new SalesOrderProductRepository().Remove(this);
        }

        public SalesOrder GetSalesOrder()
        {
            return new SalesOrderRepository().FindById(SalesOrderId);
        }

        public decimal GetDepositPaid()
        {
            var payments = GetProductPayments().ToList();
            if (!payments.Any(sopp => sopp.IsDeposit))
                return 0;
            return payments.First(sopp => sopp.IsDeposit).GetPayment().Amount;
        }
    }
}