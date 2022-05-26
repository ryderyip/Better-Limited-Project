using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList.PermissionManagement
{
    public static class ProductPermissionManager
    {
        public static bool CanCurrentStaffRemoveProduct()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Title switch
            {
                StaffTitle.Admin or StaffTitle.PurchaseManager => true,
                _ => false
            };
        }
        
        public static bool CanCurrentStaffCreateProduct()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Department switch
            {
                Department.Admin or Department.Purchase => true,
                _ => false
            };
        }

        public static bool CanCurrentStaffSwitchWorkplaceInProductList()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Department switch
            {
                Department.Admin or Department.Purchase or Department.Accounting => true,
                _ => false
            };
        }

        public static bool CanCurrentStaffEditPhasingOut()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Department switch
            {
                Department.Admin or Department.Purchase or Department.Accounting => true,
                _ => false
            };
        }

        public static bool CanCurrentStaffEditSellingPrice()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Title switch
            {
                StaffTitle.Admin or StaffTitle.PurchaseManager or StaffTitle.AccountingManager
                    or StaffTitle.SalesManager => true,
                _ => false
            };
        }

        public static bool CanCurrentStaffEditProductOriginalInformation()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Title switch
            {
                StaffTitle.Admin or StaffTitle.PurchaseManager => true,
                _ => false
            };
        }
        
        public static bool CanCurrentStaffUpdateProduct()
        {
            return CanCurrentStaffEditPhasingOut() || CanCurrentStaffEditProductOriginalInformation();
        }
    }
}