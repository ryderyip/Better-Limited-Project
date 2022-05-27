using System;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public interface IPaymentForm
    {
        public event EventHandler<Payment>? PaymentCompleted;
        void ShowForm();
    }
}