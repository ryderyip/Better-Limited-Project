using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class RetailStoreStockRepository
    {
        public static void Remove(string workplaceId, string productId)
        {
            var command = new MySqlCommand(
                @"delete from retail_store_stock
                        where retail_store_id = @retailStoreId
                        and product_id = @productId;");
            command.Parameters.AddWithValue("@retailStoreId", workplaceId);
            command.Parameters.AddWithValue("@productId", productId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}