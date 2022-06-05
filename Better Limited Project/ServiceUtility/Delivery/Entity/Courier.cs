using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class Courier : IEntity
    {
        public Courier(string name, string phone)
        {
            Id = CourierRepository.GetNewId();
            Name = name;
            Phone = phone;
        }

        public Courier(string id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}