using System.ComponentModel.DataAnnotations;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility
{
    public enum DeliveryGoodsStatus
    {
        [Display(Name = "Waiting for Replenishment")] WaitingForReplenishment,
        [Display(Name = "Ready for Delivery")] ReadyForDelivery,
        [Display(Name = "Arranged For Delivery")] ArrangedForDelivery
    }
}