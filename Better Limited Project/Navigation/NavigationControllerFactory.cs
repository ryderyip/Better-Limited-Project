using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.Controller;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Navigation
{
    public static class NavigationControllerFactory
    {
        public static INavigationController CreateController(FormController formController, Staff staff)
        {
            var title = staff.StaffTitle;
            return title switch
            {
                StaffTitle.SalesRepresentative or StaffTitle.SalesManager
                    => new SalesNavigationController(formController, staff),
                StaffTitle.AccountingClerk => new AccountingClerkNavigationController(),
                StaffTitle.AccountingManager => new AccountingManagerNavigationController(),
                StaffTitle.PurchaseClerk => new PurchaseClerkNavigationController(),
                StaffTitle.PurchaseManager => new PurchaseManagerNavigationController(),
                StaffTitle.InventoryClerk => new InventoryClerkNavigationController(),
                StaffTitle.ReceivingClerk => new ReceivingClerkNavigationController(),
                StaffTitle.TechnicalSupportClerk or StaffTitle.TechnicalSupportManager
                    => new PurchaseManagerNavigationController(),
                _ => throw new NotImplementedException()
            };
        }
    }
}