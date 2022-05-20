using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class StaffRepository
    {
        public static Staff GetStaff(string staffId)
        {
            var command = new MySqlCommand(
                "SELECT * FROM staff WHERE id = @staffId;");
            command.Parameters.AddWithValue("@staffId", staffId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            return ConvertToStaff(dataTable.Rows[0]);
        }

        private static Staff ConvertToStaff(DataRow row)
        {
            string id = row.Field<string>("id");
            string name = row.Field<string>("name");
            var dob = row.Field<DateTime>("date_of_birth");
            var hiredOn = row.Field<DateTime>("hired_on");
            char gender = row.Field<string>("gender")[0];
            var department = DepartmentRepository.GetDepartment(
                row.Field<int>("department_id").ToString());
            var title = StaffTitleRepository.GetTitle(
                row.Field<int>("title_id").ToString());

            return new Staff(id, name, dob, hiredOn, gender, department, title);
        }
    }
}