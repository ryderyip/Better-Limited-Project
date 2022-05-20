namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Phone { get;set; }
        public string Email { get; set; }

        public Supplier(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}