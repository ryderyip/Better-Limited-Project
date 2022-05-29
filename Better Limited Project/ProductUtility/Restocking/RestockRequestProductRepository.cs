using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public static class RestockRequestProductRepository
    {
        public static void Insert(RestockRequestProduct requestedProduct)
        {
            var command = new MySqlCommand(
                @"insert into restock_request_product
                    value (@restockRequestId, @productId, @quantity)");
            command.Parameters.AddWithValue("@restockRequestId", requestedProduct.RestockRequestId);
            command.Parameters.AddWithValue("@productId", requestedProduct.Product.Id);
            command.Parameters.AddWithValue("@quantity", requestedProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}