using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.CustomerRecord
{
    public class Customer : IEntity
    {
        public Customer(string name, string phone, Address address, string? email = null)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public string Id { get; set; } = new CustomerRepository().GetNewId();
        public string Name { get;  set; }
        public string Phone { get;  set; }
        public Address Address { get; set; }
        public string? Email { get; set; }

        public void Save()
        {
            new CustomerRepository().Insert(this);
        }

        public bool HasDuePayment()
        {
            var orders = new SalesOrderRepository().FindAll(o => o.Customer != null && o.Customer.Id == Id);
            return orders.Any(o => !new SalesOrderCalculator(o).IsAllPaymentCompleted());
        }

        public bool HasYetToArriveDelivery()
        {
            var orders = new SalesOrderRepository().FindAll(o => o.Customer != null && o.Customer.Id == Id);
            return orders.Any(o => !o.IsAllDeliveryArrived());
        }
    }
}