using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class ReservedSalesOrderProduct
    {
        public ReservedSalesOrderProduct(string salesOrderId, string productId, int quantity)
        {
            SalesOrderId = salesOrderId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string SalesOrderId { get; }
        public string ProductId { get; }
        public int Quantity { get; set; }

        public void Save()
        {
            ReservedSalesOrderProductRepository.InsertOrUpdate(this);
        }

        public SalesOrder GetSalesOrder()
        {
            return new SalesOrderRepository().FindById(SalesOrderId);
        }

        public void Delete()
        {
            ReservedSalesOrderProductRepository.Delete(SalesOrderId, ProductId);
        }
    }
}