using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.PermissionManagement.Controller;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.PermissionManagement.Repository
{
    public class PermissionRepository
    {
        public static IEnumerable<IPermission> GetAll()
        {
            var command = new MySqlCommand(
                @"select * from permission;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToPermission(row);
        }

        public static IPermission FindBy(Permission permission)
        {
            int id = (int) permission;
            return GetAll().FirstOrDefault(p => p.Id == id.ToString())
                   ?? throw new ArgumentException($"Unknown enumeration \"{nameof(permission)}\".");
        }

        private static IPermission ConvertToPermission(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string name = row.Field<string>("name");
            string description = row.Field<string>("description");
            var factory = new PermissionFactory();
            return factory.Generate(new PermissionTemplate(id, name, description));
        }

        private class PermissionTemplate : IPermission
        {
            public PermissionTemplate(string id, string name, string description)
            {
                Id = id;
                Name = name;
                Description = description;
            }

            public string Id { get; }
            public string Name { get; }
            public string Description { get; }

            public Func<StaffTitle, bool> PermissionMap => staffTitle => PermittedStaffTitles()
                .Any(st => st == staffTitle);

            public Func<IEnumerable<StaffTitle>> PermittedStaffTitles => () => StaffTitlePermissionService
                .GetPermittedStaffTitles(this);
        }
    }
}