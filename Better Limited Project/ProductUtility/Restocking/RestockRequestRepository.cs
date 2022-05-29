using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public static class RestockRequestRepository
    {
        public static void Insert(RestockRequest restockRequest)
        {
            var command = new MySqlCommand(
                @"insert into restock_request (id, retail_store_id, created_on, created_by_staff_id)
                value (@id, @retailStoreId, @createOn, @createdByStaffId)");
            command.Parameters.AddWithValue("@id", restockRequest.Id);
            command.Parameters.AddWithValue("@retailStoreId", restockRequest.RequestedFor.Id);
            command.Parameters.AddWithValue("@createOn", restockRequest.RequestedOn);
            command.Parameters.AddWithValue("@createdByStaffId", restockRequest.RequestedBy.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}