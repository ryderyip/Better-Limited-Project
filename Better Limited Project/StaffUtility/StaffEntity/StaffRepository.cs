using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class StaffRepository
    {
        public static IEnumerable<Staff> GetStaffs()
        {
            var dataTable = GetStaffTable();

            return from DataRow row in dataTable.Rows select ConvertToStaff(row);
        }

        public static Staff GetStaff(string staffId)
        {
            return GetStaffs().FirstOrDefault(staff => staff.Id == staffId)
                   ?? throw new ArgumentException($"Staff id \"{staffId}\" does not exist.");
        }

        public static DataTable GetStaffTable()
        {
            var command = new MySqlCommand(
                @"SELECT s.id, s.name, date_of_birth, 
                            gender, hired_on, d.name as department, st.name as staff_title
                        FROM staff s 
                        INNER join staff_title st on s.title_id = st.id
                        INNER join department d on s.department_id = d.id;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable;
        }

        private static Staff ConvertToStaff(DataRow row)
        {
            string id = row.Field<string>("id");
            string name = row.Field<string>("name");
            var dob = row.Field<DateTime>("date_of_birth");
            var hiredOn = row.Field<DateTime>("hired_on");
            IGender gender = GenderConverter.Convert(row.Field<string>("gender")[0]);
            var department = DepartmentMapper.Map(row.Field<string>("department"));
            var title = new StaffTitleMapper().Map(row.Field<string>("staff_title"));

            return new Staff(id, name, dob, hiredOn, gender, department, title);
        }

        public static void CreateStaff(string id, string name, DateTime dob, IGender gender, Department department,
            StaffTitle title)
        {
            string departmentId = DepartmentRepository.GetId(department);
            string titleId = StaffTitleRepository.GetId(title);
            
            var command = new MySqlCommand(
                @"insert into staff value (@id, @name, @dob, @gender, @hiredOn, @departmentId, @titleId)");
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@gender", GenderConverter.Convert(gender));
            command.Parameters.AddWithValue("@hiredOn", DateTime.Now);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.Parameters.AddWithValue("@titleId", titleId);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void RemoveStaff(string staffId)
        {
            var command = new MySqlCommand(
                @"delete from staff where id = @id;");
            command.Parameters.AddWithValue("@id", staffId);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void UpdateStaff(string staffId, string name, IGender gender, DateTime dob, StaffTitle title)
        {
            var command = new MySqlCommand(
                @"update staff set name = @name, gender = @gender, date_of_birth = @dob,
                 title_id = @titleId where id = @id;");
            command.Parameters.AddWithValue("@id", staffId);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@gender", GenderConverter.Convert(gender));
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@titleId", StaffTitleRepository.GetId(title));
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}