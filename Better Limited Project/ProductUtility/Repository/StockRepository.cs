using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class StockRepository
    {
        /// <summary>
        /// Get the stocks of a specified workplace (retail store/warehouse).
        /// </summary>
        /// <param name="workplaceId">retail store id/warehouse id</param>
        public static IEnumerable<IStock> GetStocks(string workplaceId)
        {
            var stocks = GetWarehouseStocks(workplaceId).Cast<IStock>()
                .Concat(GetRetailStoreStocks(workplaceId)).ToList();
            return stocks.Any() ? stocks 
                : throw new ArgumentException($"Workplace id \"{workplaceId}\" does not exist.");
        }

        /// <summary>
        /// Get the stock of all products from the specified retail store
        /// </summary>
        public static IEnumerable<RetailStoreStock> GetRetailStoreStocks(string retailStoreId)
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       price as original_price, 
                       description, 
                       is_phasing_out, 
                        rss.retail_store_id,
                       rss.quantity, 
                       rss.selling_price,
                       rss.restock_level,
                       pc.id as category_id, 
                       s.id as supplier_id, 
                       rs.name as retail_store_name
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows
                let productId = row.Field<string>("product_id")
                let productName = row.Field<string>("name")
                let originalPrice = row.Field<decimal>("original_price")
                let desc = row.Field<string>("description")
                let category = CategoryRepository.GetById(row.Field<int>("category_id").ToString())
                let supplier = SupplierRepository.GetById(row.Field<int>("supplier_id").ToString())
                let isPhasingOut = row.Field<bool>("is_phasing_out")
                let product = new Product(productId, productName, originalPrice, desc, supplier, category, isPhasingOut)
                let sellingPrice = row.Field<decimal>("selling_price")
                let quantity = row.Field<int>("quantity")
                let restockLevel = row.Field<int>("restock_level")
                let retailStore = RetailStoreRepository.GetRetailStoreById(row.Field<string>("retail_store_id"))
                select new RetailStoreStock(product, retailStore, quantity, sellingPrice, restockLevel);
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
        
        public static IEnumerable<WarehouseStock> GetWarehouseStocks(string warehouseId)
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       price as original_price, 
                       description, 
                       is_phasing_out, 
                        ws.warehouse_id,
                       ws.quantity,
                        ws.restock_level,
                       pc.id as category_id, 
                       s.id as supplier_id, 
                       w.name as retail_store_name
                        from warehouse_stock ws
                        INNER JOIN product p on ws.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN warehouse w on ws.warehouse_id = w.id
                        WHERE w.id = @warehouse_id;");
            command.Parameters.AddWithValue("@warehouse_id", warehouseId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows
                let productId = row.Field<string>("product_id")
                let productName = row.Field<string>("name")
                let originalPrice = row.Field<decimal>("original_price")
                let desc = row.Field<string>("description")
                let category = CategoryRepository.GetById(row.Field<int>("category_id").ToString())
                let supplier = SupplierRepository.GetById(row.Field<int>("supplier_id").ToString())
                let isPhasingOut = row.Field<bool>("is_phasing_out")
                let product = new Product(productId, productName, originalPrice, desc, supplier, category, isPhasingOut)
                let quantity = row.Field<int>("quantity")
                let restockLevel = row.Field<int>("restock_level")
                let warehouse = WarehouseRepository.GetWarehouseById(row.Field<string>("warehouse_id"))
                select new WarehouseStock(product, warehouse, quantity, restockLevel);
        }
        
        /*private static List<Stock> ConvertToRetailStoreStocks(DataTable dataTable)
        {
            var stocks = new List<Stock>();
            foreach (DataRow row in dataTable.Rows)
            {
                var id = row.Field<string>("product_id");
                var name = row.Field<string>("name");
                var originalPrice = row.Field<decimal>("original_price");
                var desc = row.Field<string>("description");
                var category = CategoryRepository.GetById(row.Field<int>("category_id").ToString());
                var supplier = SupplierRepository.GetById(row.Field<int>("supplier_id").ToString());
                var isPhasingOut = row.Field<bool>("is_phasing_out");
                
                var product = new Product(id, name, originalPrice, desc, supplier, category, isPhasingOut);
                
                decimal sellingPrice = row.Field<decimal>("selling_price");
                int quantity = row.Field<int>("quantity");
                int restockLevel = row.Field<int>("restock_level");
                var retailStore = RetailStoreRepository.GetRetailStoreById(row.Field<string>("retail_store_id"));
                stocks.Add(new Stock(product, ));
            }

            return stocks;
        }*/

        /// <summary>
        /// Get the stock of a particular product from the specified retail store
        /// </summary>
        public static RetailStoreStock GetProductStockFromRetailStore(string productId, string retailStoreId)
        {
            return GetRetailStoreStocks(retailStoreId)
                .First(stock => stock.Product.Id == productId);
            /*var command = new MySqlCommand(
                @"select p.id as product_id, p.name as name, price as original_price, 
                       description, is_phasing_out, rss.quantity, rss.restock_level,
                       rss.selling_price, rss.retail_store_id, pc.id as category_id, s.id as supplier_id
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
            return ConvertToRetailStoreStocks(dataTable);*/
        }

        public static WarehouseStock GetProductStockFromWarehouse(string productId, string warehouseId)
        {
            return GetWarehouseStocks(warehouseId).First(stock => stock.Product.Id == productId);
            /*var command = new MySqlCommand(
                @"select p.id as product_id, p.name as name, price as original_price, 
                       description, is_phasing_out, ws.quantity, pc.id as category_id, s.id as supplier_id,
                       s.name as supplier_name, s.phone as supplier_phone, 
                       s.email as supplier_email, w.name as retail_store_name
                        from warehouse_stock ws
                        INNER JOIN product p on ws.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN warehouse w on ws.warehouse_id = w.id
                        WHERE w.id = @retailStoreId
                        AND p.id = @productId;");
            command.Parameters.AddWithValue("@retailStoreId", warehouseId);
            command.Parameters.AddWithValue("@productId", productId);
            
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            var stock = // user your own convert ConvertToStock(dataTable);
            return stock.Any() ? stock.First() : null;*/
        }
    }
}