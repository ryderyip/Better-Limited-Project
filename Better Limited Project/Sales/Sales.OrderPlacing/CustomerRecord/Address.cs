namespace Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord
{
    public class Address
    {
        public string? Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public Address(string address1, string address2)
        {
            Address1 = address1;
            Address2 = address2;
        }
    }
}