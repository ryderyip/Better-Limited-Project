using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Navigation
{
    public static class NavigationFormFactory
    {
        public static INavigationForm GenerateForm(FormController controller)
        {
            return LoginSession.GetSession().CurrentStaff.Title switch
            {
                StaffTitle.SalesRepresentative or StaffTitle.SalesManager 
                    => new SalesNavigationForm(controller),
                StaffTitle.AccountingClerk => new AccountingClerkNavigationForm(controller),
                StaffTitle.AccountingManager => new AccountingManagerNavigationForm(controller),
                StaffTitle.PurchaseClerk => new PurchaseClerkNavigationForm(controller),
                StaffTitle.PurchaseManager => new PurchaseManagerNavigationForm(controller),
                StaffTitle.InventoryClerk => new InventoryClerkNavigationForm(controller),
                StaffTitle.ReceivingClerk => new ReceivingClerkNavigationForm(controller),
                StaffTitle.TechnicalSupportClerk or StaffTitle.TechnicalSupportManager
                    => new TechnicalSupportNavigationForm(controller),
                StaffTitle.Admin => new AdminNavigationForm(controller),
                _ => throw new ArgumentException("Unexpected staff title.")
            };
        }
    }
}