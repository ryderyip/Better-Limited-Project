using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.CustomerRecord
{
    public class Customer : IEntity
    {
        public Customer(string id, string name, string phone, Address address, string? email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public Customer(string name, string phone, Address address, string? email = null)
        {
            Id = new CustomerRepository().GetNewId();
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; }
        public string? Email { get; set; }

        public void Save()
        {
            Address.Save();
            new CustomerRepository().Insert(this);
        }

        public bool HasUnfinishedSalesOrder()
        {
            var orders = new SalesOrderRepository().FindAll(o => o.Customer != null && o.Customer.Id == Id);
            return orders.Any(o => !o.IsCompleted());
        }

        public void Remove()
        {
            Address.Remove();
            new CustomerRepository().Delete(this);
        }
    }
}