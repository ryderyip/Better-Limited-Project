namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    public class Address
    {
        public string? Id { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public Address(string city, string address1, string address2)
        {
            City = city;
            Address1 = address1;
            Address2 = address2;
        }
    }
}