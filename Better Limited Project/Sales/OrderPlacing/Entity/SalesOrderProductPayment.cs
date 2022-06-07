using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.PaymentUtility.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrderProductPayment
    {
        public SalesOrderProductPayment(string salesOrderId, string productId, string paymentId, int quantity, bool isDeposit)
        {
            SalesOrderId = salesOrderId;
            ProductId = productId;
            PaymentId = paymentId;
            Quantity = quantity;
            IsDeposit = isDeposit;
        }

        public string SalesOrderId { get; set; }
        public string ProductId { get; set; }
        public string PaymentId { get; set; }
        public int Quantity { get; set; }
        public bool IsDeposit { get; set; }

        public void Save()
        {
            SalesOrderProductPaymentRepository.InsertOrUpdate(this);
        }

        public Payment GetPayment()
        {
            return PaymentRepository.FindById(PaymentId);
        }
    }
}