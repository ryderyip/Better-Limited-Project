namespace Better_Limited_Project.CustomerRecord
{
    public class Customer : IEntity
    {
        public Customer(string name, string phone, Address address, string? email = null)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public string Id { get; set; } = new CustomerRepository().GetId();
        public string Name { get;  set; }
        public string Phone { get;  set; }
        public Address Address { get; set; }
        public string? Email { get; set; }

        public void Save()
        {
            new CustomerRepository().Insert(this);
        }
    }
}