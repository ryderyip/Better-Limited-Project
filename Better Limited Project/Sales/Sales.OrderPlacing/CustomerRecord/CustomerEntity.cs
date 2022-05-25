namespace Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord
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