using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

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

        public void Save()
        {
            var repo = new SalesOrderProductRepository();
            repo.InsertOrUpdate(this);
        }

        public SalesOrderProductPaymentStatus GetPaymentStatus()
        {
            var paidAmount = GetAmountPaid();
            if (IsOutOfStock)
                return paidAmount >= Price * Quantity * Product.DepositPricePercentage
                    ? SalesOrderProductPaymentStatus.DepositPaid
                    : SalesOrderProductPaymentStatus.AwaitingPayment;
            return paidAmount >= Price * Quantity
                ? SalesOrderProductPaymentStatus.FullyPaid
                : SalesOrderProductPaymentStatus.AwaitingPayment;
        }

        public IEnumerable<SalesOrderProductPayment> GetProductPayments()
        {
            return SalesOrderProductPaymentRepository.GetByIds(SalesOrderId, ProductId);
        }

        public SalesOrderProductPayment? GetProductDepositPayment()
        {
            return SalesOrderProductPaymentRepository.GetByIds(SalesOrderId, ProductId).FirstOrDefault(sopp => sopp.IsDeposit);
        }

        public Product GetProduct()
        {
            return ProductRepository.FindById(ProductId);
        }

        public ReservedSalesOrderProduct? GetReservedStock()
        {
            return ReservedSalesOrderProductRepository.FindByIds(SalesOrderId, ProductId);
        }

        public void Remove()
        {
            new SalesOrderProductRepository().Remove(this);
        }

        public SalesOrder GetSalesOrder()
        {
            return new SalesOrderRepository().FindById(SalesOrderId);
        }

        public decimal GetAmountPaid()
        {
            return GetProductPayments().Sum(sopp => sopp.GetPayment().Amount);
        }

        public void Delete()
        {
            new SalesOrderProductRepository().Remove(this);
        }
    }
}