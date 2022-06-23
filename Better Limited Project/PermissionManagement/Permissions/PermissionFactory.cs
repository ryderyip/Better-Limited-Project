using System;

namespace Better_Limited_Project.PermissionManagement.Permissions
{
    public class PermissionFactory
    {
        public IPermission Generate(IPermission permissionTemplate)
        {
            return permissionTemplate.Id switch
            {
                "1" => new CanStaffCreateProduct(permissionTemplate.Id,
                    permissionTemplate.Name, 
                    permissionTemplate.Description,
                    permissionTemplate.PermissionMap,
                    permissionTemplate.PermittedStaffTitles),
                "2" => new CanStaffViewAllWorkplaceProductStocksInProductListView(permissionTemplate.Id,
                    permissionTemplate.Name, 
                    permissionTemplate.Description,
                    permissionTemplate.PermissionMap,
                    permissionTemplate.PermittedStaffTitles),
                "3" => new CanStaffEditPhasingOut(permissionTemplate.Id,
                    permissionTemplate.Name, 
                    permissionTemplate.Description,
                    permissionTemplate.PermissionMap,
                    permissionTemplate.PermittedStaffTitles),
                "4" => new CanStaffEditProductSellingPrice(permissionTemplate.Id,
                permissionTemplate.Name,
                permissionTemplate.Description,
                permissionTemplate.PermissionMap,
                permissionTemplate.PermittedStaffTitles),
                _ => throw new ArgumentException($"Permission with id {permissionTemplate.Id} does not exist.")
            };
        }
    }
}