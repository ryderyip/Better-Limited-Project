using System;

namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    public interface IPaymentForm
    {
        public event EventHandler<PaymentMethod>? PaymentCompleted;
        void ShowForm();
    }
}