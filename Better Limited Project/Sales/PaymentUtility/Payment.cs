using System;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public class Payment
    {
        public decimal Amount { get; }
        public PaymentMethod PaymentMethod { get; }
        public DateTime PaidOn { get; }
        public bool IsDeposit { get; }

        public Payment(decimal amount, PaymentMethod paymentMethod, DateTime paidOn, bool isDeposit = false)
        {
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaidOn = paidOn;
            IsDeposit = isDeposit;
        }
    }
}