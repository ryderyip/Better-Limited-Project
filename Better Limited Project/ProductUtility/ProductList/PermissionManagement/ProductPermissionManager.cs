using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList.PermissionManagement
{
    public static class ProductPermissionManager
    {
        public static bool CanCurrentStaffCreateProduct()
        {
            var loginStaff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            return loginStaff.Title switch
            {
                StaffTitle.Admin => true,
                _ => false
            };
        }
    }
}