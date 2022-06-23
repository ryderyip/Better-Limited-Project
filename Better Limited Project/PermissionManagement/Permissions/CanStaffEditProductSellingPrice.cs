using System;
using System.Collections.Generic;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.PermissionManagement.Permissions
{
    public class CanStaffEditProductSellingPrice : IPermission
    {
        public CanStaffEditProductSellingPrice(string id, string name, string description,
            Func<StaffTitle, bool> permissionMap, Func<IEnumerable<StaffTitle>> permittedStaffTitles)
        {
            Id = id;
            Name = name;
            Description = description;
            PermissionMap = permissionMap;
            PermittedStaffTitles = permittedStaffTitles;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Func<StaffTitle, bool> PermissionMap { get; }
        public Func<IEnumerable<StaffTitle>> PermittedStaffTitles { get; }
    }
}