using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.Delivery.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.Delivery.Repository
{
    public static class CourierRepository
    {
        public static Courier FindById(string id)
        {
            var command = new MySqlCommand(
                @"select id, name, phone from courier where id = @id");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Courier ID \"{id}\" does not exist.");
            return ConvertToCourier(dataTable.Rows[0]);
        }

        public static IEnumerable<Courier> GetAll()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select id, name, phone from courier"));
            return from DataRow row in dataTable.Rows select ConvertToCourier(row);
        }

        private static Courier ConvertToCourier(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string name = row.Field<string>("name");
            string phone = row.Field<string>("phone");
            return new Courier(id, name, phone);
        }

        public static IEnumerable<Courier> FindAll(Predicate<Courier> filter)
        {
            throw new NotImplementedException();
        }

        public static void Insert(Courier entity)
        {
            throw new NotImplementedException();
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) + 1 as id from courier;"));
            return dataTable.Rows[0].Field<long>("id").ToString();
        }
    }
}