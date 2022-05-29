using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestProductRepository
    {
        public static void Insert(ReorderRequestProduct requestedProduct)
        {
            var command = new MySqlCommand(
                @"insert into reorder_request_product
                    value (@reorderRequestId, @productId, @quantity)");
            command.Parameters.AddWithValue("@reorderRequestId", requestedProduct.ReorderRequestId);
            command.Parameters.AddWithValue("@productId", requestedProduct.Product.Id);
            command.Parameters.AddWithValue("@quantity", requestedProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}