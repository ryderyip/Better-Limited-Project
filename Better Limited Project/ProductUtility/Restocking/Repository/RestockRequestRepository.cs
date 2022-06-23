using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking.Repository
{
    public static class RestockRequestRepository
    {
        public static void InsertOrUpdate(RestockRequest restockRequest)
        {
            var command = new MySqlCommand(
                @"insert into restock_request (id, request_number, retail_store_id, created_on, created_by_staff_id)
                value (@id, @requestNumber, @retailStoreId, @createOn, @createdByStaffId)
                on duplicate key update arranged_by_staff_id = @arrangedByStaffId,
                                        arranged_on = @arrangedOn,
                                        received_on = @receivedOn;");
            command.Parameters.AddWithValue("@id", restockRequest.Id);
            command.Parameters.AddWithValue("@requestNumber", restockRequest.RequestNumber);
            command.Parameters.AddWithValue("@retailStoreId", restockRequest.RequestedForRetailStore.Id);
            command.Parameters.AddWithValue("@createOn", restockRequest.RequestedOn);
            command.Parameters.AddWithValue("@createdByStaffId", restockRequest.RequestedByStaff.Id);
            command.Parameters.AddWithValue("@arrangedByStaffId",
                restockRequest.ArrangedByStaffId != null ? restockRequest.ArrangedByStaffId : DBNull.Value);
            command.Parameters.AddWithValue("@arrangedOn",
                restockRequest.ArrangedOn != null ? restockRequest.ArrangedOn : DBNull.Value);
            command.Parameters.AddWithValue("@receivedOn", restockRequest.ReceivedOn != null
                ? restockRequest.ReceivedOn
                : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from restock_request;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static IEnumerable<RestockRequest> GetAll()
        {
            var command = new MySqlCommand(
                @"select * from restock_request;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToRestockRequest(row);
        }

        public static RestockRequest FindById(string restockRequestId)
        {
            var command = new MySqlCommand(
                @"select * from restock_request where id = @id");
            command.Parameters.AddWithValue("@id", restockRequestId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Restock request id \"{restockRequestId} does not exist.");
            return ConvertToRestockRequest(dataTable.Rows[0]);
        }

        private static RestockRequest ConvertToRestockRequest(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string requestNumber = row.Field<string>("request_number");
            string retailStoreId = row.Field<string>("retail_store_id");
            DateTime createdOn = row.Field<DateTime>("created_on");
            string createdByStaffId = row.Field<int>("created_by_staff_id").ToString();
            var arrangedOn = row.Field<DateTime?>("arranged_on") ?? null;
            var arrangedByStaffId = row.Field<int?>("arranged_by_staff_id")?.ToString() ?? null;
            var receivedOn = row.Field<DateTime?>("received_on") ?? null;
            return new RestockRequest(id, requestNumber, retailStoreId, createdByStaffId, createdOn, arrangedByStaffId,
                arrangedOn, receivedOn);
        }

        public static void Remove(RestockRequest restockRequest)
        {
            var command = new MySqlCommand(
                @"delete from restock_request where id = @id;");
            command.Parameters.AddWithValue("@id", restockRequest.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}