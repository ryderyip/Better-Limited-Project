using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class Delivery : IEntity
    {
        private const int MaximumDeliveriesPerSession = 5;

        public Delivery(string deliveryRequestId, DateTime scheduledOn)
        {
            Id = DeliveryRepository.GetNewId();
            DeliveryRequestId = deliveryRequestId;
            CreatedOn = DateTime.Now;
            ScheduledOn = scheduledOn;
            DeliveryStatus = GetStatus(deliveryRequestId);
        }

        public Delivery(string id, string deliveryRequestId, DateTime createdOn, DateTime scheduledOn,
            DeliveryStatus deliveryStatus, DateTime? dispatchedOn, DateTime? deliveredOn,
            ICollection<DeliveryCourier> deliveryCouriers)
        {
            Id = id;
            DeliveryRequestId = deliveryRequestId;
            CreatedOn = createdOn;
            ScheduledOn = scheduledOn;
            DeliveryStatus = deliveryStatus;
            DispatchedOn = dispatchedOn;
            DeliveredOn = deliveredOn;
            DeliveryCouriers = deliveryCouriers;
        }

        public string Id { get; }
        public string DeliveryRequestId { get; }
        public DateTime CreatedOn { get; }
        public DateTime ScheduledOn { get; }
        public DeliveryStatus DeliveryStatus { get; }
        public DateTime? DispatchedOn { get; }
        public DateTime? DeliveredOn { get; }
        public ICollection<DeliveryCourier> DeliveryCouriers { get; set; } = new List<DeliveryCourier>();

        public DeliveryRequest GetDeliveryRequest()
        {
            return DeliveryRequestRepository.FindById(DeliveryRequestId);
        }

        private DeliveryStatus GetStatus(string deliveryRequestId)
        {
            var request = DeliveryRequestRepository.FindById(deliveryRequestId);
            return request.GetSalesOrder().SalesOrderProducts.Any(sop => sop.IsOutOfStock)
                ? DeliveryStatus.AwaitingRestock
                : DeliveryStatus.AwaitingDispatch;
        }

        public static DateTime GetEarliestDeliveryDate(DeliverySession deliverySession)
        {
            var tomorrow = DateTime.Today + TimeSpan.FromDays(1);
            var earliestDate = DeliveryRepository.GetAll()
                .Where(d => d.ScheduledOn > tomorrow
                            && d.GetDeliveryRequest().DeliverySession == deliverySession)
                .GroupBy(d => d.ScheduledOn)
                .Where(group => group.Count() < MaximumDeliveriesPerSession)
                .Select(group => group.Key)
                .OrderBy(deliveryDate => deliveryDate)
                .FirstOrDefault();
            return earliestDate != default ? earliestDate : tomorrow;
        }

        public void Save()
        {
            DeliveryRepository.InsertOrUpdate(this);
        }

        public IEnumerable<Courier> GetCouriers()
        {
            return DeliveryCouriers.ToList().Select(dc => CourierRepository.FindById(dc.CourierId));
        }
    }
}