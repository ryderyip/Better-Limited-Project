using System;
using System.Collections.Generic;
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

            var orderId = Guid.NewGuid().ToString();
            return new SalesOrder
            {
                Id = orderId, Staff = staff, RetailStore = retailStore, Customer = customer,
                SalesOrderProducts = new List<SalesOrderProduct>(cart.GetCartItems().ToList()
                    .ConvertAll(cartItem =>
                        new SalesOrderProduct(orderId, cartItem.Product, cartItem.Price, cartItem.Quantity)
                        {
                            IsDeposit = cartItem.IsDeposit
                        }))
            };
        }
    }
}