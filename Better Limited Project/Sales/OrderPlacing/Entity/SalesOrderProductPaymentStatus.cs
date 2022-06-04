using System.ComponentModel.DataAnnotations;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public enum SalesOrderProductPaymentStatus
    {
        [Display(Name = "Awaiting Payment")] AwaitingPayment = 1,
        [Display(Name = "Deposit Paid")] DepositPaid = 2,
        [Display(Name = "Fully Paid")] FullyPaid = 3
    }
}