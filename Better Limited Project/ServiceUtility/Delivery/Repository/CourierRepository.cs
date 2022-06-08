using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.Delivery.Entity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.Delivery.Repository
{
    public static class CourierRepository
    {
        public static Courier FindById(string id)
        {
            var command = new MySqlCommand(
                @"select id, name, phone, hired_on, gender from courier where id = @id");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Courier ID \"{id}\" does not exist.");
            return ConvertToCourier(dataTable.Rows[0]);
        }

        public static IEnumerable<Courier> GetAll()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select id, name, phone, hired_on, gender from courier"));
            return from DataRow row in dataTable.Rows select ConvertToCourier(row);
        }

        private static Courier ConvertToCourier(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            var gender = GenderConverter.Convert(row.Field<string>("gender")[0]);
            string name = row.Field<string>("name");
            string phone = row.Field<string>("phone");
            var hiredOn = row.Field<DateTime>("hired_on");
            return new Courier(id, name, gender, phone, hiredOn);
        }

        public static IEnumerable<Courier> FindAll(Predicate<Courier> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public static void InsertOrUpdate(Courier courier)
        {
            var command = new MySqlCommand(
                @"insert into courier (id, name, phone, hired_on, gender) 
                    value (@id, @name, @phone, @hiredOn, @gender)
                on duplicate key update name = @name, phone = @phone, gender = @gender;");
            command.Parameters.AddWithValue("@id", courier.Id);
            command.Parameters.AddWithValue("@name", courier.Name);
            command.Parameters.AddWithValue("@phone", courier.Phone);
            command.Parameters.AddWithValue("@hiredOn", courier.HiredOn);
            command.Parameters.AddWithValue("@gender", GenderConverter.Convert(courier.Gender));
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) + 1 as id from courier;"));
            return dataTable.Rows[0].Field<long>("id").ToString();
        }

        public static void Remove(Courier courier)
        {
            var command = new MySqlCommand(@"delete from courier where id = @id;");
            command.Parameters.AddWithValue("@id", courier.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}