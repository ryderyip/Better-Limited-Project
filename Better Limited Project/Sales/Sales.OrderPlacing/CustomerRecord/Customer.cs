namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    public class Customer
    {
        public string? Id { get; set; }
        public string Name { get;  }
        public string Phone { get;  }
        public string? Email { get; set; }
        public Address? Address { get; set; }
        
        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}