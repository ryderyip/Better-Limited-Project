using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public class SalesOrder
    {
        public Staff Staff { get; }
        public RetailStore RetailStore { get; }
        public Cart Cart { get; }
        public CustomerEntity? CustomerEntity { get; }

        public SalesOrder(Staff staff, RetailStore retailStore, Cart cart)
        {
            Staff = staff;
            RetailStore = retailStore;
            Cart = cart;
            CustomerEntity = null;
        }
        
        public SalesOrder(Staff staff, RetailStore retailStore, Cart cart, CustomerEntity customerEntity)
        {
            Staff = staff;
            RetailStore = retailStore;
            Cart = cart;
            CustomerEntity = customerEntity;
        }
    }
}