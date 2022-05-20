using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Admin.PermissionManagement
{
    public static class ProductUpdatePermissionManager
    {
        public static ProductUpdatePermission GetCurrentStaffPermission()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Title switch
            {
                StaffTitle.Admin => ProductUpdatePermission.AllowUpdateAll,
                StaffTitle.AccountingManager => ProductUpdatePermission.AllowUpdatePricePhasingLevelPhasingOut,
                StaffTitle.SalesManager => ProductUpdatePermission.AllowUpdatePrice,
                _ => ProductUpdatePermission.None
            };
        }
    }
}