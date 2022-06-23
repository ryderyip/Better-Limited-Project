using System;
using System.Collections.Generic;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.PermissionManagement.Permissions
{
    public interface IPermission
    {
        string Id { get; }
        string Name { get; }
        string Description { get; }
        public Func<StaffTitle, bool> PermissionMap { get; }
        public Func<IEnumerable<StaffTitle>> PermittedStaffTitles { get; }
    }
}