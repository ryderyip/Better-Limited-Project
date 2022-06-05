using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class StockRepository
    {
        public static EventHandler<IWorkplace>? StockUpdated;
        
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
                let productId = row.Field<int>("product_id").ToString()
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
                let retailStore = new RetailStoreRepository().GetById(row.Field<string>("retail_store_id"))
                select new RetailStoreStock(product, retailStore, quantity, sellingPrice, restockLevel);
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
                let productId = row.Field<int>("product_id").ToString()
                let productName = row.Field<string>("name")
                let originalPrice = row.Field<decimal>("original_price")
                let desc = row.Field<string>("description")
                let category = CategoryRepository.GetById(row.Field<int>("category_id").ToString())
                let supplier = SupplierRepository.GetById(row.Field<int>("supplier_id").ToString())
                let isPhasingOut = row.Field<bool>("is_phasing_out")
                let product = new Product(productId, productName, originalPrice, desc, supplier, category, isPhasingOut)
                let quantity = row.Field<int>("quantity")
                let restockLevel = row.Field<int>("restock_level")
                let warehouse = WarehouseRepository.GetWarehouseById(row.Field<int>("warehouse_id").ToString())
                select new WarehouseStock(product, warehouse, quantity, restockLevel);
        }

        public static void UpdateStock(IStock stock)
        {
            if (stock is RetailStoreStock retailStoreStock)
                UpdateRetailStoreStock(retailStoreStock);
            else if (stock is WarehouseStock warehouseStock)
                UpdateWarehouseStock(warehouseStock);
            else
                throw new NotImplementedException("Unknown implementation of IStock class.");
            
            StockUpdated?.Invoke(null, stock.Workplace);
        }

        public static void UpdateRetailStoreStock(RetailStoreStock stock)
        {
            var command = new MySqlCommand(
                @"update retail_store_stock
                        set selling_price = @sellingPrice,
                            restock_level = @restockLevel,
                            quantity = @quantity
                        where product_id = @productId
                        and retail_store_id = @retailStoreId;");
            command.Parameters.AddWithValue("@sellingPrice", stock.SellingPrice);
            command.Parameters.AddWithValue("@restockLevel", stock.RestockLevel);
            command.Parameters.AddWithValue("@quantity", stock.Quantity);
            command.Parameters.AddWithValue("@productId", stock.Product.Id);
            command.Parameters.AddWithValue("@retailStoreId", stock.Workplace.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
        
        public static void UpdateWarehouseStock(WarehouseStock stock)
        {
            var command = new MySqlCommand(
                @"update warehouse_stock
                        set restock_level = @restockLevel,
                            quantity = @quantity
                        where product_id = @productId
                        and warehouse_stock.warehouse_id = @warehouseId;");
            command.Parameters.AddWithValue("@restockLevel", stock.RestockLevel);
            command.Parameters.AddWithValue("@quantity", stock.Quantity);
            command.Parameters.AddWithValue("@productId", stock.Product.Id);
            command.Parameters.AddWithValue("@warehouseId", stock.Workplace.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}