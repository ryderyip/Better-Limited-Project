namespace Better_Limited_Project.CustomerRecord
{
    public class Customer
    {
        public string Name { get;  set; }
        public string Phone { get;  set; }
        public string? Email { get; set; }
        public AddressEntity AddressEntity { get; set; }
        
        public Customer(string name, string phone, AddressEntity addressEntity)
        {
            Name = name;
            Phone = phone;
            AddressEntity = addressEntity;
        }
        
        public Customer(string name, string phone, AddressEntity addressEntity, string? email)
        : this(name, phone, addressEntity)
        {
            Email = email;
        }
    }
}