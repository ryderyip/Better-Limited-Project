using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.PermissionManagement.Repository
{
    public static class PermissionStaffTitleRepository
    {
        public static IEnumerable<StaffTitle> FindBy(IPermission permission)
        {
            var command = new MySqlCommand(
                @"select staff_title_id from permission_staff_title where permission_id = @permissionId;");
            command.Parameters.AddWithValue("@permissionId", permission.Id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let staffTitleId = row.Field<int>("staff_title_id").ToString()
                select StaffTitleRepository.FindById(staffTitleId);
        }

        public static void Insert(IPermission permission, StaffTitle staffTitle)
        {
            var command = new MySqlCommand(
                @"insert into permission_staff_title value (@permissionId, @staffTitleId) 
                    on duplicate key update permission_id = @permissionId;");
            command.Parameters.AddWithValue("@permissionId", permission.Id);
            command.Parameters.AddWithValue("@staffTitleId", (int) staffTitle);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void Delete(IPermission permission, StaffTitle staffTitle)
        {
            var command = new MySqlCommand(
                @"delete from permission_staff_title 
                where permission_id = @permissionId and staff_title_id = @staffTitleId;");
            command.Parameters.AddWithValue("@permissionId", permission.Id);
            command.Parameters.AddWithValue("@staffTitleId", (int) staffTitle);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}