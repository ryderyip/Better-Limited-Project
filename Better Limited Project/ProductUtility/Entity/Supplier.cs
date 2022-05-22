namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Supplier
    {
        public string Id { get; }
        public string Name { get; }
        public string Phone { get; }
        public string Email { get; }

        public Supplier(string id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}