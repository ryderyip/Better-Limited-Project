namespace Better_Limited_Project.CustomerRecord
{
    public class Customer : IEntity
    {
        public string Id { get; set; }
        public string Name { get;  set; }
        public string Phone { get;  set; }
        public string? Email { get; set; }
        public Address Address { get; set; }

        public void Save()
        {
            var repo = new CustomerRepository();
            if (repo.FindById(Id) == null)
                repo.Insert(this);
            else
                repo.Update(this);
        }
    }
}