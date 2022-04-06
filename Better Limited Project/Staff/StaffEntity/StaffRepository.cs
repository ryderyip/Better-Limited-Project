using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Better_Limited_Project.Staff.StaffEntity
{
    public static class StaffRepository
    {
        public static Login.Staff GetStaff(string staffId)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT * FROM staff WHERE id = @staffId;", conn);
            command.Parameters.AddWithValue("@staffId", staffId);
            
            var dataReader = command.ExecuteReader();
            
            dataTable.Load(dataReader);
            dataReader.Close();

            return ConvertToStaff(dataTable.Rows[0]);
        }

        private static Login.Staff ConvertToStaff(DataRow row)
        {
            return new Login.Staff
            {
                Id = row.Field<string>("id"),
                Name = row.Field<string>("name"),
                DateOfBirth = row.Field<DateTime>("date_of_birth"),
                HiredOn = row.Field<DateTime>("hired_on"),
                Gender = row.Field<string>("gender")[0],
                Department = DepartmentRepository.GetDepartment(
                    row.Field<int>("department_id").ToString()),
                StaffTitle = StaffTitleRepository.GetTitle(
                    row.Field<int>("title_id").ToString())
            };
        }
    }
}