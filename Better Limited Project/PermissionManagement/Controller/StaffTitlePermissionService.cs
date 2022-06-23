using System.Collections.Generic;
using Better_Limited_Project.PermissionManagement.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using IPermission = Better_Limited_Project.PermissionManagement.Permissions.IPermission;

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