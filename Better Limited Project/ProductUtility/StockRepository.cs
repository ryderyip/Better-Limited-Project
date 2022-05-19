using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility
{
    public static class StockRepository
    {
        /// <summary>
        /// Get the stock of all products from the specified retail store
        /// </summary>
        public static List<ProductQuantity> GetRetailStoreStock(string retailStoreId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       price as original_price, 
                       description, 
                       is_phasing_out, 
                       rss.quantity, 
                       rss.selling_price, 
                       pc.name as category, 
                       s.name as supplier_name, 
                       s.phone as supplier_phone, 
                       s.email as supplier_email,
                       rs.name as retail_store_name
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;", conn);
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToStock(dataTable);
        }
        
        /// <summary>
        /// Get the stock of a particular product from the specified retail store
        /// </summary>
        public static ProductQuantity GetRetailStoreStock(string retailStoreId, string productId)
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       price as original_price, 
                       description, 
                       is_phasing_out, 
                       rss.quantity, 
                       rss.selling_price, 
                       pc.name as category, 
                       s.name as supplier_name, 
                       s.phone as supplier_phone, 
                       s.email as supplier_email,
                       rs.name as retail_store_name
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId
                        AND p.id = @productId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToStock(dataTable).First();
        }
        
        public static void UpdateProductInfo(string retailStoreId, string productId, decimal sellingPrice)
        {
            var command = new MySqlCommand(
                @"update retail_store_stock
                        set selling_price = @sellingPrice
                        where product_id = @productId
                        and retail_store_id = @retailStoreId;");
            command.Parameters.AddWithValue("@sellingPrice", sellingPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            DataTableRepository.ExecuteNonQuery(command);
        }
        
        public static List<ProductQuantity> GetWarehouseStock(string warehouseId)
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       price as original_price, 
                       description, 
                       is_phasing_out, 
                       ws.quantity, 
                       pc.name as category, 
                       s.name as supplier_name, 
                       s.phone as supplier_phone, 
                       s.email as supplier_email,
                       w.name as warehouse_name
                        from warehouse_stock ws
                        INNER JOIN product p on ws.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN warehouse w on ws.warehouse_id = w.id
                        WHERE w.id = @warehouseId;");
            command.Parameters.AddWithValue("@warehouseId", warehouseId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToStock(dataTable);
        }
        
        private static List<ProductQuantity> ConvertToStock(DataTable dataTable)
        {
            var stock = new List<ProductQuantity>();
            foreach (DataRow row in dataTable.Rows)
            {
                var product = new Product
                {
                    Id = row.Field<string>("product_id"),
                    Name = row.Field<string>("name"),
                    OriginalPrice = row.Field<decimal>("original_price"),
                    SellingPrice = row.Field<decimal>("selling_price"),
                    Description = row.Field<string>("description"),
                    Category = row.Field<string>("category"),
                    IsPhasingOut = row.Field<bool>("is_phasing_out"),
                    Supplier = new Supplier
                    {
                        Name = row.Field<string>("supplier_name"),
                        Phone = row.Field<string>("supplier_phone"),
                        Email = row.Field<string>("supplier_email")
                    }
                };
                int quantity = row.Field<int>("quantity");
                stock.Add(new ProductQuantity(product, quantity));
            }

            return stock;
        }
    }
}