namespace Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord
{
    public class Customer
    {
        public string Name { get;  }
        public string Phone { get;  }
        public string? Email { get; }
        public Address Address { get; }
        
        public Customer(string name, string phone, Address address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
        
        public Customer(string name, string phone, Address address, string? email)
        : this(name, phone, address)
        {
            Email = email;
        }
    }
}