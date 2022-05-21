using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList.PermissionManagement
{
    public static class ProductInfoEditPermissionManager
    {
        public static ProductInfoEditPermission GetCurrentStaffPermission()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Title switch
            {
                StaffTitle.Admin => ProductInfoEditPermission.AllowUpdateAll,
                StaffTitle.AccountingManager => ProductInfoEditPermission.AllowUpdatePricePhasingLevelPhasingOut,
                StaffTitle.SalesManager => ProductInfoEditPermission.AllowUpdatePrice,
                _ => ProductInfoEditPermission.None
            };
        }
    }
}