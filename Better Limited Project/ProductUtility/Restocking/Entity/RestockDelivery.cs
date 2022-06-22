using System;
using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking.Entity
{
    public class RestockDelivery
    {
        public RestockDelivery(DateTime scheduledOn)
        {
            Id = RestockDeliveryRepository.GetNewId();
            CreatedOn = DateTime.Now;
            ScheduledOn = scheduledOn;
        }

        public RestockDelivery(string id, DateTime createdOn, DateTime scheduledOn, DateTime? departedOn)
        {
            Id = id;
            CreatedOn = createdOn;
            ScheduledOn = scheduledOn;
            DepartedOn = departedOn;
        }

        public string Id { get; }
        public DateTime CreatedOn { get; }
        public DateTime ScheduledOn { get; }
        public DateTime? DepartedOn { get; set; }
        public IEnumerable<Courier> Couriers => RestockDeliveryCourierRepository.GetBy(this);

        public bool IsDelivered()
        {
            return DepartedOn != null;
        }

        public void Save()
        {
            RestockDeliveryRepository.InsertOrUpdate(this);
        }
    }
}