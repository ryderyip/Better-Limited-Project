namespace Better_Limited_Project.CustomerRecord
{
    public class CustomerEntity : IEntity
    {
        public CustomerEntity(Customer customer, string id)
        {
            Customer = customer;
            Id = id;
        }

        public Customer Customer { get; set; }
        public string Id { get; }
    }
}