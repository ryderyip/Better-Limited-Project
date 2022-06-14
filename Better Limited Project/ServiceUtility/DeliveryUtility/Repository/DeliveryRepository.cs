using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository
{
    public static class DeliveryRepository
    {
        public static event EventHandler<Entity.Delivery>? DeliveryStatusUpdated;
        
        public static IEnumerable<Entity.Delivery> GetAll()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select id, delivery_request_id, created_on, scheduled_on, 
                    delivery_status_id, dispatched_on, delivered_on from delivery;"));
            return from DataRow row in dataTable.Rows select ConvertToDelivery(row);
        }

        public static Entity.Delivery GetById(string id)
        {
            var command = new MySqlCommand(
                @"select id, delivery_request_id, created_on, scheduled_on, 
                    delivery_status_id, dispatched_on, delivered_on from delivery
                where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Delivery ID \"{id}\" does not exist.");
            return ConvertToDelivery(dataTable.Rows[0]);
        }

        public static IEnumerable<Entity.Delivery> FindAll(Predicate<Entity.Delivery> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        private static Entity.Delivery ConvertToDelivery(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string deliveryRequestId = row.Field<int>("delivery_request_id").ToString();
            var createdOn = row.Field<DateTime>("created_on");
            var scheduledOn = row.Field<DateTime>("scheduled_on");
            var deliveryStatus = (DeliveryStatus) row.Field<int>("delivery_status_id");
            var dispatchedOn = deliveryStatus is DeliveryStatus.AwaitingDispatch
                ? null
                : row.Field<DateTime?>("dispatched_on");
            var deliveredOn = deliveryStatus is not DeliveryStatus.Delivered
                ? null
                : row.Field<DateTime?>("delivered_on");
            var courierIds = DeliveryCourierRepository.FindByDeliveryId(id).ToList();
            return new Entity.Delivery(id, deliveryRequestId, createdOn, scheduledOn, deliveryStatus, 
                dispatchedOn, deliveredOn, courierIds);
        }

        public static void InsertOrUpdate(Entity.Delivery delivery)
        {
            var command = new MySqlCommand(
                @"insert into delivery (id, delivery_request_id, created_on, scheduled_on, delivery_status_id, 
                      dispatched_on, delivered_on)
                value (@id, @deliveryRequestId, @createdOn, @scheduledOn, @deliveryStatusId, @dispatchedOn,
                      @deliveredOn)
                on duplicate key update delivery_request_id = @deliveryRequestId, scheduled_on = @scheduledOn,
                    delivery_status_id = @deliveryStatusId, dispatched_on = @dispatchedOn, 
                    delivered_on = @deliveredOn;");
            command.Parameters.AddWithValue("@id", delivery.Id);
            command.Parameters.AddWithValue("@deliveryRequestId", delivery.DeliveryRequestId);
            command.Parameters.AddWithValue("@createdOn", delivery.CreatedOn);
            command.Parameters.AddWithValue("@scheduledOn", delivery.ScheduledOn);
            command.Parameters.AddWithValue("@deliveryStatusId", (int) delivery.DeliveryStatus);
            command.Parameters.AddWithValue("@dispatchedOn",
                delivery.DispatchedOn != null ? delivery.DispatchedOn.Value : DBNull.Value);
            command.Parameters.AddWithValue("@deliveredOn",
                delivery.DeliveredOn != null ? delivery.DeliveredOn.Value : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
            DeliveryStatusUpdated?.Invoke(null, delivery);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) + 1 as id from delivery;"));
            return dataTable.Rows[0]["id"] == DBNull.Value
                ? "1" : dataTable.Rows[0].Field<long>("id").ToString();
        }
    }
}