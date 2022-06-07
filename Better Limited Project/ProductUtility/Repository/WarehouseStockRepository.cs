using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class WarehouseStockRepository
    {
        public static void Remove(string warehouseId, string productId)
        {
            var command = new MySqlCommand(
                @"delete from warehouse_stock
                        where warehouse_id = @warehouseId
                        and product_id = @productId;");
            command.Parameters.AddWithValue("@warehouseId", warehouseId);
            command.Parameters.AddWithValue("@productId", productId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}