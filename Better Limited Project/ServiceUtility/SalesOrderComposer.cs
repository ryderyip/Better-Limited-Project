using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ServiceUtility
{
    public static class SalesOrderComposer
    {
        public static SalesOrder Compose(Cart cart, Customer? customer)
        {
            var staff = LoginSession.GetSession().CurrentStaff;
            var retailStore = new RetailStoreRepository().GetRetailStoreById(UserSettings.GetSettings().Workplace!.Id);

            var salesOrder = new SalesOrder(staff, retailStore)
            {
                Customer = customer
            };
            
            var salesOrderProducts = cart.GetCartItems().ToList().ConvertAll(cartItem =>
                new SalesOrderProduct(salesOrder.Id, cartItem.Product.Id, cartItem.Price, cartItem.Quantity, cartItem.IsDeposit));
            
            salesOrderProducts.ForEach(sop => salesOrder.SalesOrderProducts.Add(sop));
            return salesOrder;
        }
    }
}