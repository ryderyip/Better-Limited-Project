using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity
{
    public class DeliveryCourier
    {
        public DeliveryCourier(string deliveryId, string courierId)
        {
            DeliveryId = deliveryId;
            CourierId = courierId;
        }

        public string DeliveryId { get; set; }
        public string CourierId { get; set; }

        public void Save()
        {
            DeliveryCourierRepository.Insert(this);
        }
    }
}