using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ServiceUtility
{
    public class SalesOrderComposer
    {
        private readonly Cart _cart;
        private readonly Customer? _customer;
        private readonly Staff _salesStaff;
        private readonly RetailStore _retailStore;

        public SalesOrderComposer(Cart cart, Customer? customer)
        {
            _cart = cart;
            _customer = customer;
            _salesStaff = LoginSession.GetSession().CurrentStaff;
            _retailStore = new RetailStoreRepository().GetById(UserSettings.GetSettings().Workplace!.Id);
        }

        public SalesOrder GetSalesOrder()
        {
            return new SalesOrder(_salesStaff, _retailStore)
            {
                Customer = _customer
            };
        }

        public IEnumerable<SalesOrderProduct> GetSalesOrderProducts()
        {
            return _cart.GetCartItems().Select(cartItem =>
                new SalesOrderProduct(GetSalesOrder().Id, cartItem.Product.Id, cartItem.Price, cartItem.Quantity,
                    cartItem.IsOutOfStock));
        }
    }
}