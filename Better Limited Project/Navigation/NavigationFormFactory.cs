using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Navigation
{
    public static class NavigationFormFactory
    {
        public static INavigationForm GenerateForm(FormController controller, Staff staff)
        {
            var title = staff.StaffTitle;
            return title switch
            {
                StaffTitle.SalesRepresentative or StaffTitle.SalesManager 
                    => new SalesNavigationForm(controller, staff),
                StaffTitle.AccountingClerk => new AccountingClerkNavigationForm(controller, staff),
                StaffTitle.AccountingManager => new AccountingManagerNavigationForm(controller, staff),
                StaffTitle.PurchaseClerk => new PurchaseClerkNavigationForm(controller, staff),
                StaffTitle.PurchaseManager => new PurchaseManagerNavigationForm(controller, staff),
                StaffTitle.InventoryClerk => new InventoryClerkNavigationForm(controller, staff),
                StaffTitle.ReceivingClerk => new ReceivingClerkNavigationForm(controller, staff),
                StaffTitle.TechnicalSupportClerk or StaffTitle.TechnicalSupportManager
                    => new TechnicalSupportNavigationForm(controller, staff),
                _ => throw new NotImplementedException()
            };
        }
    }
}