using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Staff.StaffEntity
{
    public static class DepartmentRepository
    {
        public static Department GetDepartment(string departmentId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT * FROM department WHERE id = @id;", conn);
            command.Parameters.AddWithValue("@id", departmentId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            return Convert(dataTable.Rows[0]);
        }

        private static Department Convert(DataRow row)
        {
            return new Department
            {
                Id = row.Field<int>("id").ToString(),
                Name = row.Field<string>("name")
            };
        }
    }
}