using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.SettingsUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList.ProductList
{
    public static class ProductListDataTableRetriever
    {
        public static DataTable GetRetailStoreStockTable()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            return GetRetailStoreStockTable(retailStoreId!);
        }

        public static DataTable GetWarehouseStockTable()
        {
            var warehouseId = UserSettings.GetSettings().Workplace?.Id;
            return GetWarehouseStockTable(warehouseId!);
        }
        
        public static DataTable GetRetailStoreStockTable(string retailStore)
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       rss.quantity, 
                       rss.selling_price, 
                       pc.name as category
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStore);
            return DataTableRepository.RetrieveDataTable(command);
        }

        public static DataTable GetWarehouseStockTable(string warehouseId)
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       ws.quantity, 
                       pc.name as category
                        from warehouse_stock ws
                        INNER JOIN product p on ws.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN warehouse w on ws.warehouse_id = w.id
                        WHERE w.id = @warehouseId;");
            command.Parameters.AddWithValue("@warehouseId", warehouseId);
            return DataTableRepository.RetrieveDataTable(command);
        }
    }
}