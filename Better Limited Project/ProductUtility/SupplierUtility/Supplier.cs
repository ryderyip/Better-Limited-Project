using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public class Supplier
    {
        public Supplier(string name, string phone, string email)
        {
            Id = SupplierRepository.GetNewId();
            Name = name;
            Phone = phone;
            Email = email;
        }

        public Supplier(string id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            SupplierRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            SupplierRepository.Remove(this);
        }
    }
}