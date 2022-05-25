namespace Better_Limited_Project.Sales.PaymentUtility.PaymentProcesses
{
    public interface IPaymentProcedure
    {
        public delegate void PaymentCompletedEventHandler(object sender, PaymentStatus status);
        public event PaymentCompletedEventHandler PaymentCompleted;

        void Start();
    }
}