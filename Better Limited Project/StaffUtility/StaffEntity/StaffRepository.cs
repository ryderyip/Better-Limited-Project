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
                @"SELECT s.id, s.name, date_of_birth, 
                            gender, hired_on, d.name as department, st.name as staff_title
                        FROM staff s 
                        INNER join staff_title st on s.title_id = st.id
                        INNER join department d on s.department_id = d.id
                        WHERE s.id = @staffId;");
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
            var department = DepartmentMapper.Map(row.Field<string>("department"));
            var title = new StaffTitleMapper().Map(row.Field<string>("staff_title"));

            return new Staff(id, name, dob, hiredOn, gender, department, title);
        }
    }
}