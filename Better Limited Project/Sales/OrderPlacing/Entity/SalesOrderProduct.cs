using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrderProduct
    {
        public string SalesOrderId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsDeposit { get; set; }

        public SalesOrderProduct()
        {
        }

        public void Save()
        {
            var repo = new SalesOrderProductRepository();
            repo.Insert(this);
        }
    }
}