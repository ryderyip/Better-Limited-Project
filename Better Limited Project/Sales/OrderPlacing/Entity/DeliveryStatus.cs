using System.ComponentModel.DataAnnotations;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public enum DeliveryStatus
    {
        [Display(Name = "Awaiting Dispatch")] AwaitingDispatch = 1,
        [Display(Name = "In Transit")] InTransit = 2,
        [Display(Name = "Delivered")] Delivered = 3
    }
}