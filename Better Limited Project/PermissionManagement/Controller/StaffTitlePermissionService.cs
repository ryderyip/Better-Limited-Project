using System.Collections.Generic;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.PermissionManagement.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.PermissionManagement.Controller
{
    public static class StaffTitlePermissionService
    {
        public static IEnumerable<StaffTitle> GetPermittedStaffTitles(IPermission permission)
        {
            return PermissionStaffTitleRepository.FindBy(permission);
        }
    }
}