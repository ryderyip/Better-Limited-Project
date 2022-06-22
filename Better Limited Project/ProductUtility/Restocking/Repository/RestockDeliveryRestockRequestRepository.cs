using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking.Repository
{
    public static class RestockDeliveryRestockRequestRepository
    {
        public static void Insert(RestockDelivery restockDelivery, RestockRequest restockRequest)
        {
            var command = new MySqlCommand(
                @"insert into restock_delivery_restock_request value (@restockDeliveryId, @restockRequestId);");
            command.Parameters.AddWithValue("@restockDeliveryId", restockDelivery.Id);
            command.Parameters.AddWithValue("@restockRequestId", restockRequest.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<RestockRequest> GetBy(RestockDelivery restockDelivery)
        {
            var command = new MySqlCommand(
                @"select restock_request_id from restock_delivery_restock_request where restock_delivery_id = @restockDeliveryId;");
            command.Parameters.AddWithValue("@restockDeliveryId", restockDelivery.Id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                select RestockRequestRepository.FindById(row.Field<int>("restock_request_id").ToString());
        }
    }
}