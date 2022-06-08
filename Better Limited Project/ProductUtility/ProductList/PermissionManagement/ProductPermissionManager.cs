using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList.PermissionManagement
{
    public static class ProductPermissionManager
    {
        public static bool CanCurrentStaffCreateProduct()
        {
            var loginStaff = LoginSession.GetSession().CurrentStaff;
            return loginStaff.Title switch
            {
                StaffTitle.Admin or StaffTitle.PurchaseManager => true,
                _ => false
            };
        }
        
        public static bool CanCurrentStaffRemoveProduct()
        {
            return CanCurrentStaffCreateProduct();
        }
        
        public static bool CanCurrentStaffSwitchWorkplaceInProductList()
        {
            var loginStaff = LoginSession.GetSession().CurrentStaff;
            return loginStaff.Department switch
            {
                Department.Admin or Department.Purchase or Department.Accounting => true,
                _ => false
            };
        }

        public static bool CanCurrentStaffEditPhasingOut()
        {
            var loginStaff = LoginSession.GetSession().CurrentStaff;
            return loginStaff.Title switch
            {
                StaffTitle.Admin or StaffTitle.PurchaseManager or StaffTitle.AccountingManager => true,
                _ => false
            };
        }

        public static bool CanCurrentStaffEditSellingPrice()
        {
            var loginStaff = LoginSession.GetSession().CurrentStaff;
            return loginStaff.Title switch
            {
                StaffTitle.Admin or StaffTitle.PurchaseManager or StaffTitle.AccountingManager
                    or StaffTitle.SalesManager => true,
                _ => false
            };
        }

        public static bool CanEditAllInformation()
        {
            return CanCurrentStaffCreateProduct();
        }
    }
}