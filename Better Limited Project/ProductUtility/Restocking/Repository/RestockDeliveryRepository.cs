using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking.Repository
{
    public static class RestockDeliveryRepository
    {
        public static void InsertOrUpdate(RestockDelivery restockDelivery)
        {
            var command = new MySqlCommand(
                @"insert into restock_delivery 
                value (@id, @createdOn, @scheduledOn) on duplicate key update id = id;");
            command.Parameters.AddWithValue("@id", restockDelivery.Id);
            command.Parameters.AddWithValue("@createdOn", restockDelivery.CreatedOn);
            command.Parameters.AddWithValue("@scheduledOn", restockDelivery.DepartureScheduledOn);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<RestockDelivery> GetAll()
        {
            var command = new MySqlCommand(
                @"select * from restock_delivery;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let id = row.Field<int>("id").ToString()
                let createdOn = row.Field<DateTime>("created_on")
                let scheduledOn = row.Field<DateTime>("scheduled_on")
                select new RestockDelivery(id, createdOn, scheduledOn);
        }

        public static IEnumerable<RestockDelivery> FindAll(Predicate<RestockDelivery> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from restock_delivery;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }
    }
}