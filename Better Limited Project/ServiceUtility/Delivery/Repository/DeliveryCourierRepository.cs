using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.Delivery.Repository
{
    public static class DeliveryCourierRepository
    {
        public static IEnumerable<DeliveryCourier> FindByDeliveryId(string deliveryId)
        {
            var command = new MySqlCommand(
                @"select courier_id from delivery_courier where delivery_id = @deliveryId;");
            command.Parameters.AddWithValue("@deliveryId", Guid.Parse(deliveryId));
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Delivery ID \"{deliveryId}\" does not exist.");
            return from DataRow row in dataTable.Rows 
                select new DeliveryCourier(deliveryId, row.Field<int>("courier_id").ToString());
        }

        public static void Insert(DeliveryCourier deliveryCourier)
        {
            var command = new MySqlCommand(
                @"insert into delivery_courier (delivery_id, courier_id) 
                value (@deliveryId, @courierId);");
            command.Parameters.AddWithValue("@deliveryId", deliveryCourier.DeliveryId);
            command.Parameters.AddWithValue("@courierId", deliveryCourier.CourierId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}