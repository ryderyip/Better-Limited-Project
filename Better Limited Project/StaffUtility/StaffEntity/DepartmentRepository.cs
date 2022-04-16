using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
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

            string name = dataTable.Rows[0].Field<string>("name");
            return DepartmentEnumMapper.GetDepartmentType(name);
        }
    }
}