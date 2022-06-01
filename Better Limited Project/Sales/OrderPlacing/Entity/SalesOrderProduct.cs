using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrderProduct
    {
        public SalesOrderProduct(string salesOrderId, Product product, decimal price, int quantity, bool isOutOfStock)
        {
            SalesOrderId = salesOrderId;
            Product = product;
            Price = price;
            Quantity = quantity;
            IsOutOfStock = isOutOfStock;
        }

        public string SalesOrderId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsOutOfStock { get; set; }
        public ICollection<SalesOrderProductPayment> Payments { get; set; } = new List<SalesOrderProductPayment>();

        public void Save()
        {
            var repo = new SalesOrderProductRepository();
            repo.InsertOrUpdate(this);
        }
    }
}