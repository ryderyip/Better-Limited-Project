using System;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.ServiceUtility.Delivery.Entity
{
    public class Courier : IEntity
    {
        public Courier(string name, string phone)
        {
            Id = CourierRepository.GetNewId();
            Name = name;
            Phone = phone;
            HiredOn = DateTime.Now;
        }

        public Courier(string id, string name, string phone, DateTime hiredOn)
        {
            Id = id;
            Name = name;
            Phone = phone;
            HiredOn = hiredOn;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime HiredOn { get; set; }
    }
}