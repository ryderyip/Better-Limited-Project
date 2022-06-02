using System.ComponentModel.DataAnnotations;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public enum DeliveryStatus
    {
        [Display(Name = "Awaiting Restock")] AwaitingRestock = 1,
        [Display(Name = "Awaiting Dispatch")] AwaitingDispatch = 2,
        [Display(Name = "In Transit")] InTransit = 3,
        [Display(Name = "Delivered")] Delivered = 4
    }
}