using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class DeliveryRequestRepository
    {
        public DeliveryRequest FindById(string id)
        {
            return GetAll().FirstOrDefault(dr => dr.Id == id)
                ?? throw new ArgumentException($"Delivery request ID \"{id}\" does not exist.");
        }

        public IEnumerable<DeliveryRequest> GetAll()
        {
            var dt = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select id, sales_order_id, created_on, created_by_staff_id, 
                       arranged_on, arranged_by_staff_id, delivery_session_id 
                from delivery_request;"));
            return from DataRow row in dt.Rows
                let id = new Guid(row.Field<byte[]>("id")).ToString()
                let salesOrderId = new Guid(row.Field<byte[]>("sales_order_id")).ToString()
                let createOn = row.Field<DateTime>("create_on")
                let createdBy = new StaffRepository().FindById(row.Field<int>("created_by_staff_id").ToString())
                let session = (DeliverySession) row.Field<int>("delivery_session_id")
                let arrangedBy = row.Field<int?>("arranged_by_staff_id") != null
                    ? new StaffRepository().FindById(row.Field<int?>("arranged_by_staff_id").Value.ToString())
                    : null
                let arrangedOn = row.Field<DateTime?>("arranged_on") != null
                    ? row.Field<DateTime?>("arranged_on") : null
                
                select new DeliveryRequest(id, salesOrderId, createOn, createdBy, session)
                {
                    ArrangedBy = arrangedBy,
                    ArrangedOn = arrangedOn
                };
        }

        public IEnumerable<DeliveryRequest> FindAll(Predicate<DeliveryRequest> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public void InsertOrUpdate(DeliveryRequest deliveryRequest)
        {
            var command = new MySqlCommand(
                @"insert into delivery_request (id, sales_order_id, created_on, created_by_staff_id, delivery_session_id) 
                value (@id, @salesOrderId, @createOn, @createByStaffId, @deliverySessionId)
                on duplicate key update sales_order_id = @salesOrderId,
                                        created_on = @createOn,
                                        created_by_staff_id = @createByStaffId,
                                        delivery_session_id = @deliverySessionId;");
            command.Parameters.AddWithValue("@id", deliveryRequest.Id);
            command.Parameters.AddWithValue("@salesOrderId", deliveryRequest.SalesOrderId);
            command.Parameters.AddWithValue("@createOn", deliveryRequest.CreateOn);
            command.Parameters.AddWithValue("@createByStaffId", deliveryRequest.CreatedBy.Id);
            command.Parameters.AddWithValue("@deliverySessionId", (int) deliveryRequest.DeliverySession);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}