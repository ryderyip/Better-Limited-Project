using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository
{
    public static class DeliveryCourierRepository
    {
        public static IEnumerable<DeliveryCourier> FindByDeliveryId(string deliveryId)
        {
            var command = new MySqlCommand(
                @"select courier_id from delivery_courier where delivery_id = @deliveryId;");
            command.Parameters.AddWithValue("@deliveryId", deliveryId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
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

        public static IEnumerable<Entity.Delivery> FindByCourierId(string courierId)
        {
            var command = new MySqlCommand(
                @"select delivery_id from delivery_courier where courier_id = @courierId;");
            command.Parameters.AddWithValue("@courierId", courierId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                select DeliveryRepository.GetById(row.Field<int>("delivery_id").ToString());
        }
    }
}