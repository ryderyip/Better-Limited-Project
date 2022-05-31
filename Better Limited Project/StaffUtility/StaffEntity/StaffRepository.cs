using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public class StaffRepository : IRepository<Staff>, IRepositoryInsert<Staff>
    {
        public IEnumerable<Staff> GetAll()
        {
            var command = new MySqlCommand(
                @"SELECT s.id, s.name, date_of_birth, 
                            gender, hired_on, d.name as department, st.name as staff_title
                        FROM staff s 
                        INNER join staff_title st on s.title_id = st.id
                        INNER join department d on s.department_id = d.id;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToStaff(row);
        }

        public IEnumerable<Staff> FindAll(Predicate<Staff> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public Staff FindById(string staffId)
        {
            return GetAll().First(staff => staff.Id == staffId);
        }

        private Staff ConvertToStaff(DataRow row)
        {
            return new Staff
            {
                Id = row.Field<int>("id").ToString(),
                Name = row.Field<string>("name"),
                DateOfBirth = row.Field<DateTime>("date_of_birth"),
                HiredOn = row.Field<DateTime>("hired_on"),
                Gender = GenderConverter.Convert(row.Field<string>("gender")[0]),
                Department = DepartmentMapper.Map(row.Field<string>("department")),
                Title = new StaffTitleMapper().Map(row.Field<string>("staff_title"))
            };
        }

        public void RemoveStaff(string staffId)
        {
            var command = new MySqlCommand(
                @"delete from staff where id = @id;");
            command.Parameters.AddWithValue("@id", staffId);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public void Insert(Staff staff)
        {
            string departmentId = ((int) staff.Department).ToString();
            string titleId = StaffTitleRepository.GetId(staff.Title);

            var command = new MySqlCommand(
                @"insert into staff value (@id, @name, @dob, @gender, @hiredOn, @departmentId, @titleId)
                    on duplicate key update name = @name, date_of_birth = @dob, gender = @gender,
                                            hired_on = @hiredOn, department_id = @departmentId, title_id = @titleId;");
            command.Parameters.AddWithValue("@id", staff.Id);
            command.Parameters.AddWithValue("@name", staff.Name);
            command.Parameters.AddWithValue("@dob", staff.DateOfBirth);
            command.Parameters.AddWithValue("@gender", GenderConverter.Convert(staff.Gender));
            command.Parameters.AddWithValue("@hiredOn", DateTime.Now);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.Parameters.AddWithValue("@titleId", titleId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}