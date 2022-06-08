using System;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;

namespace Better_Limited_Project.ServiceUtility.Delivery.Entity
{
    public class Courier : IEntity
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
    }
}