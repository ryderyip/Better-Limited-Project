using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity
{
    public class Courier 
    {
        public Courier(string name, Gender gender, string phone)
        {
            Id = CourierRepository.GetNewId();
            Name = name;
            Gender = gender;
            Phone = phone;
            HiredOn = DateTime.Now;
        }

        public Courier(string id, string name, Gender gender, string phone, DateTime hiredOn)
        {
            Id = id;
            Gender = gender;
            Name = name;
            Phone = phone;
            HiredOn = hiredOn;
        }

        public string Id { get; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime HiredOn { get; set; }

        public void Save()
        {
            CourierRepository.InsertOrUpdate(this);
        }

        public bool HasUnfinishedDelivery()
        {
            return GetAppointedDeliveries().Any(d => d.DeliveryStatus is not DeliveryStatus.Delivered)
                || GetAppointedRestockDelivery().Any(rd => !rd.IsDelivered());
        }

        public IEnumerable<Delivery> GetAppointedDeliveries()
        {
            return DeliveryRepository.FindAll(d => d.DeliveryCouriers.Any(dc => dc.CourierId == Id));
        }

        public IEnumerable<RestockDelivery> GetAppointedRestockDelivery()
        {
            return RestockDeliveryRepository.FindAll(d => d.Couriers.Any(c => c.Id == Id));
        }

        public void Remove()
        {
            CourierRepository.Remove(this);
        }

        public bool IsFreeOn(DateTime selectedDate)
        {
            return GetAppointedDeliveries().Where(d => d.ScheduledOn.Date == selectedDate).All(d => d.IsDelivered())
                   && GetAppointedRestockDelivery().Where(d => d.ScheduledOn.Date == selectedDate)
                       .All(d => d.IsDelivered());
        }
    }
}