using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.Repository
{
    public static class DepartmentRepository
    {
        public static IEnumerable<Department> GetDepartments()
        {
            var command = new MySqlCommand("select id, name from department;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                select DepartmentMapper.Map(row.Field<string>("name"));
        }
    }
}