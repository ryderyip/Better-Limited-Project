using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking.Repository
{
    public static class RestockDeliveryCourierRepository
    {
        public static void Insert(RestockDelivery restockDelivery, Courier courier)
        {
            var command = new MySqlCommand(
                @"insert into restock_delivery_courier value (@restockDeliveryId, @courierId);");
            command.Parameters.AddWithValue("@restockDeliveryId", restockDelivery.Id);
            command.Parameters.AddWithValue("@courierId", courier.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<Courier> GetBy(RestockDelivery restockDelivery)
        {
            var command = new MySqlCommand(
                @"select courier_id from restock_delivery_courier where restock_delivery_id = @restockDeliveryId;");
            command.Parameters.AddWithValue("@restockDeliveryId", restockDelivery.Id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                select CourierRepository.FindById(row.Field<int>("courier_id").ToString());
        }
    }
}