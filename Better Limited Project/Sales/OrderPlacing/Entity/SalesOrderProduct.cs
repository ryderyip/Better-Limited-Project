using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrderProduct
    {
        public SalesOrderProduct(string salesOrderId, Product product, decimal price, int quantity)
        {
            SalesOrderId = salesOrderId;
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public string SalesOrderId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsDeposit { get; set; }

        public void Save()
        {
            var repo = new SalesOrderProductRepository();
            repo.Insert(this);
        }
    }
}