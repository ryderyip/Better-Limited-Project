using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Staff.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Login
{
    public class StaffRepository
    {
        public static Staff GetStaff(string staffId)
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

        private static Staff ConvertToStaff(DataRow row)
        {
            return new Staff
            {
                Id = row.Field<string>("id"),
                Name = row.Field<string>("name"),
                DateOfBirth = row.Field<DateTime>("date_of_birth"),
                HiredOn = row.Field<DateTime>("hired_on"),
                Gender = row.Field<char>("gender"),
                Department = DepartmentRepository.GetDepartment(
                    row.Field<string>("department_id")),
                StaffTitle = StaffTitleRepository.GetTitle(
                    row.Field<string>("title_id"))
            };
        }
    }
}