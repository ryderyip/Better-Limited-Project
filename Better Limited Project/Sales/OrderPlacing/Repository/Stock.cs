using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class Stock
    {
        public Stock(string salesOrderId, string productId, int quantity)
        {
            SalesOrderId = salesOrderId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string SalesOrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public SalesOrder SalesOrder => new SalesOrderRepository().FindById(SalesOrderId);
        public Product Product => ProductRepository.FindById(ProductId);
    }
}