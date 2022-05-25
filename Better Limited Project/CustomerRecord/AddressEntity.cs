namespace Better_Limited_Project.CustomerRecord
{
    public class AddressEntity : IEntity
    {
        public string Id { get; }
        public Address Address { get; }

        public AddressEntity(string id, Address address)
        {
            Id = id;
            Address = address;
        }
    }
}