using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.OrderPlacing;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.Delivery.Repository
{
    public static class DeliveryRequestRepository
    {
        public static DeliveryRequest FindById(string id)
        {
            return GetAll().FirstOrDefault(dr => dr.Id == id)
                   ?? throw new ArgumentException($"Delivery request ID \"{id}\" does not exist.");
        }

        public static IEnumerable<DeliveryRequest> GetAll()
        {
            var dt = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select id, sales_order_id, created_on, created_by_staff_id, 
                       arranged_on, arranged_by_staff_id, delivery_session_id 
                from delivery_request;"));
            return from DataRow row in dt.Rows
                let id = row.Field<int>("id").ToString()
                let salesOrderId = row.Field<int>("sales_order_id").ToString()
                let createOn = row.Field<DateTime>("created_on")
                let createdBy = row.Field<int>("created_by_staff_id").ToString()
                let session = (DeliverySession) row.Field<int>("delivery_session_id")
                let arrangedByStaffId = row.Field<int?>("arranged_by_staff_id")?.ToString()
                let arrangedOn = row.Field<DateTime?>("arranged_on")
                select new DeliveryRequest(id, salesOrderId, createOn, createdBy, session)
                {
                    ArrangedByStaffId = arrangedByStaffId,
                    ArrangedOn = arrangedOn
                };
        }

        public static IEnumerable<DeliveryRequest> FindAll(Predicate<DeliveryRequest> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public static void InsertOrUpdate(DeliveryRequest deliveryRequest)
        {
            var command = new MySqlCommand(
                @"insert into delivery_request (id, sales_order_id, created_on, created_by_staff_id, delivery_session_id, arranged_by_staff_id, arranged_on) 
                value (@id, @salesOrderId, @createOn, @createByStaffId, @deliverySessionId, @arrangedByStaffId, @arrangedOn)
                on duplicate key update sales_order_id = @salesOrderId,
                                        created_on = @createOn,
                                        created_by_staff_id = @createByStaffId,
                                        delivery_session_id = @deliverySessionId,
                                        arranged_by_staff_id = @arrangedByStaffId,
                                        arranged_on = @arrangedOn;");
            command.Parameters.AddWithValue("@id", deliveryRequest.Id);
            command.Parameters.AddWithValue("@salesOrderId", deliveryRequest.SalesOrderId);
            command.Parameters.AddWithValue("@createOn", deliveryRequest.CreateOn);
            command.Parameters.AddWithValue("@createByStaffId", deliveryRequest.CreatedByStaffId);
            command.Parameters.AddWithValue("@deliverySessionId", (int) deliveryRequest.DeliverySession);
            command.Parameters.AddWithValue("@arrangedByStaffId", deliveryRequest.ArrangedByStaffId != null ? deliveryRequest.ArrangedByStaffId : DBNull.Value);
            command.Parameters.AddWithValue("@arrangedOn", deliveryRequest.ArrangedOn != null ? deliveryRequest.ArrangedOn.Value : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }
        
        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) + 1 as id from delivery_request;"));
            return dataTable.Rows[0]["id"] == DBNull.Value
                ? "1" : dataTable.Rows[0].Field<long>("id").ToString();
        }
    }
}