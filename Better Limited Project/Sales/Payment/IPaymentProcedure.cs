namespace Better_Limited_Project.Sales.Payment
{
    public interface IPaymentProcedure
    {
        public delegate void PaymentCompletedEventHandler(object sender, PaymentStatus status);
        public event PaymentCompletedEventHandler PaymentCompleted;

        void Start();
    }
}