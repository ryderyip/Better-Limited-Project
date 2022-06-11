using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestRepository
    {
        public static void Insert(ReorderRequest reorderRequest)
        {
            var command = new MySqlCommand(
                @"insert into reorder_request (id, warehouse_id, requested_by_staff_id, requested_on, approved_by_staff_id, approved_on)
                value (@id, @warehouse_id, @requestedByStaffId, @requestedOn, @approvedByStaffId, @approvedOn)");
            command.Parameters.AddWithValue("@id", reorderRequest.Id);
            command.Parameters.AddWithValue("@warehouse_id", reorderRequest.Warehouse.Id);
            command.Parameters.AddWithValue("@requestedByStaffId", reorderRequest.RequestedByStaff.Id);
            command.Parameters.AddWithValue("@requestedOn", reorderRequest.RequestedOn);
            command.Parameters.AddWithValue("@approvedByStaffId",
                reorderRequest.ApprovedByStaffId != null ? reorderRequest.ApprovedByStaffId : DBNull.Value);
            command.Parameters.AddWithValue("@approvedOn",
                reorderRequest.ApprovedOn != null ? reorderRequest.ApprovedOn : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<ReorderRequest> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, warehouse_id, requested_by_staff_id, requested_on, approved_by_staff_id, approved_on
                    from reorder_request;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToReorderRequest(row);
        }

        private static ReorderRequest ConvertToReorderRequest(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string warehouseId = row.Field<string>("warehouse_id");
            string requestedByStaffId = row.Field<int>("requested_by_staff_id").ToString();
            DateTime requestedOn = row.Field<DateTime>("requested_on");
            string approvedByStaffId = row.Field<int>("approved_by_staff_id").ToString();
            DateTime approvedOn = row.Field<DateTime>("approved_on");
            return new ReorderRequest(id, warehouseId, requestedByStaffId, approvedByStaffId, requestedOn, approvedOn);
        }

        public static ReorderRequest FindById(string id)
        {
            var command = new MySqlCommand(
                @"select id, warehouse_id, requested_by_staff_id, requested_on, approved_by_staff_id, approved_on
                    from reorder_request
                    where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Reorder request with ID \"{id}\" does not exist.");
            return ConvertToReorderRequest(dataTable.Rows[0]);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from reorder_request;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }
    }
}