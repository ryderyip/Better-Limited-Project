using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.PermissionManagement.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.PermissionManagement.Controller
{
    public class UpdatePermissionService
    {
        private readonly IPermission _permission;

        public UpdatePermissionService(IPermission permission)
        {
            _permission = permission;
        }

        public void Update(IEnumerable<StaffTitle> staffTitlesToPermit)
        {
            var staffTitlesToPermitList = staffTitlesToPermit.ToList();
            var permittedStaffTitles = _permission.PermittedStaffTitles().ToList();
            var added = staffTitlesToPermitList.Where(st => permittedStaffTitles.All(pst => st != pst));
            foreach (var staffTitle in added)
                PermissionStaffTitleRepository.Insert(_permission, staffTitle);
            var removed = permittedStaffTitles.Where(pst => !staffTitlesToPermitList.Exists(st => st == pst));
            foreach (var staffTitle in removed)
                PermissionStaffTitleRepository.Delete(_permission, staffTitle);
        }
    }
}