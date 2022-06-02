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
                            gender, hired_on, department_id, title_id as staff_title
                        FROM staff s;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToStaff(row);
        }

        public IEnumerable<Staff> FindAll(Predicate<Staff> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public Staff FindById(string staffId)
        {
            var command = new MySqlCommand(
                @"select id, name, date_of_birth, gender, hired_on, department_id, title_id from staff
                where id = @id");
            command.Parameters.AddWithValue("@id", staffId);
            var datatable = DataTableRepository.RetrieveDataTable(command);
            if (datatable.Rows.Count == 0)
                throw new ArgumentException($"Staff ID \"{staffId}\" does not exist.");
            return ConvertToStaff(datatable.Rows[0]);
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
                Department = (Department) row.Field<int>("department_id"),
                Title = (StaffTitle) row.Field<int>("title_id")
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