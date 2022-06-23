using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.Repository
{
    public class StaffRepository : IRepository<Staff>, IRepositoryInsert<Staff>
    {
        public IEnumerable<Staff> GetAll()
        {
            var command = new MySqlCommand(
                @"SELECT s.id, s.name, date_of_birth, 
                            gender, hired_on, department_id, title_id
                        FROM staff s;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToStaff(row);
        }

        public IEnumerable<Staff> FindAll(Predicate<Staff> filter)
        {
            return GetAll().Where(filter.Invoke);
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
            var id = row.Field<int>("id").ToString();
            var name = row.Field<string>("name");
            var dateOfBirth = row.Field<DateTime>("date_of_birth");
            var hiredOn = row.Field<DateTime>("hired_on");
            var gender = GenderConverter.Convert(row.Field<string>("gender")[0]);
            var department = (Department) row.Field<int>("department_id");
            var title = (StaffTitle) row.Field<int>("title_id");
            return new Staff(id, name, dateOfBirth, hiredOn, gender, department, title);
        }

        public void RemoveStaff(Staff staff)
        {
            var command = new MySqlCommand(
                @"delete from staff where id = @id;");
            command.Parameters.AddWithValue("@id", staff.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public string GetNewId()
        {
            var datatable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from staff;"));
            return ((from DataRow row in datatable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }
    }
}