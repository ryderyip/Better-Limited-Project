using System;
using Better_Limited_Project.Sales.PaymentUtility.Repository;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public class Payment
    {
        public Payment(decimal amount, PaymentMethod paymentMethod)
        {
            Id = PaymentRepository.GetNewId();
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaidOn = DateTime.Now;
        }

        public Payment(string id, decimal amount, PaymentMethod paymentMethod, DateTime paidOn)
        {
            Id = id;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaidOn = paidOn;
        }

        public string Id { get; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaidOn { get; }

        public void Save()
        {
            if (Amount == 0)
                return;
            PaymentRepository.InsertOrUpdate(this);
        }
    }
}