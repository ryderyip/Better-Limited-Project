using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility.Repository;

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

        public SalesOrderProductStatus GetStatus()
        {
            var payments = GetPayments().ToList();
            decimal due = Price * Quantity;
            if (payments.Sum(sopp => PaymentRepository.FindById(sopp.PaymentId).Amount) >= due)
                return SalesOrderProductStatus.FullyPaid;
            return payments.Count != 0 ? SalesOrderProductStatus.DepositPaid : SalesOrderProductStatus.AwaitingPayment;
        }

        public IEnumerable<SalesOrderProductPayment> GetPayments()
        {
            return SalesOrderProductPaymentRepository.GetByIds(SalesOrderId, ProductId);
        }

        public Product GetProduct()
        {
            return ProductRepository.FindById(ProductId);
        }
    }
}