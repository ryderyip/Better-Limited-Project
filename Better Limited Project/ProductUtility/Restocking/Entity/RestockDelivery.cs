using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking.Entity
{
    public class RestockDelivery
    {
        public RestockDelivery(DateTime departureScheduledOn)
        {
            Id = RestockDeliveryRepository.GetNewId();
            CreatedOn = DateTime.Now;
            DepartureScheduledOn = departureScheduledOn;
        }

        public RestockDelivery(string id, DateTime createdOn, DateTime departureScheduledOn)
        {
            Id = id;
            CreatedOn = createdOn;
            DepartureScheduledOn = departureScheduledOn;
        }

        public string Id { get; }
        public DateTime CreatedOn { get; }
        public DateTime DepartureScheduledOn { get; }
        public IEnumerable<Courier> Couriers => RestockDeliveryCourierRepository.GetBy(this);
        public IEnumerable<RestockRequest> RestockRequests => RestockDeliveryRestockRequestRepository.GetBy(this);

        public bool IsDelivered()
        {
            return RestockRequests.All(rr => rr.IsReceived());
        }

        public void Save()
        {
            RestockDeliveryRepository.InsertOrUpdate(this);
        }
    }
}