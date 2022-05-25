namespace Better_Limited_Project.CustomerRecord
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public Address(string address1, string address2)
        {
            Address1 = address1;
            Address2 = address2;
        }
    }
}