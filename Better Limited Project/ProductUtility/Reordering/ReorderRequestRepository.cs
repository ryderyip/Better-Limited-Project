using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestRepository
    {
        public static void Insert(ReorderRequest reorderRequest)
        {
            var command = new MySqlCommand(
                @"insert into reorder_request (id, warehouse_id, requested_by, requested_on)
                value (@id, @warehouse_id, @requestedBy, @requestedOn)");
            command.Parameters.AddWithValue("@id", reorderRequest.Id);
            command.Parameters.AddWithValue("@warehouse_id", reorderRequest.RequestedFor.Id);
            command.Parameters.AddWithValue("@requestedBy", reorderRequest.RequestedBy.Id);
            command.Parameters.AddWithValue("@requestedOn", reorderRequest.RequestedOn);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}