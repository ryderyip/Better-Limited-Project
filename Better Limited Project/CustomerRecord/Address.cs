namespace Better_Limited_Project.CustomerRecord
{
    public class Address 
    {
        public Address(string address1, string address2)
        {
            Address1 = address1;
            Address2 = address2;
        }

        public string Id { get; set; } = new AddressRepository().GetNewId();
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public void Save()
        {
            new AddressRepository().Insert(this);
        }

        public void  Remove()
        {
            new AddressRepository().Remove(this);
        }
    }
}