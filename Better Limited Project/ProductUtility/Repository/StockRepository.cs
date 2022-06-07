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
        public static EventHandler<IStock>? StockUpdated;

        /// <summary>
        /// Get the stocks of a specified workplace (retail store/warehouse).
        /// </summary>
        /// <param name="workplaceId">retail store id/warehouse id</param>
        public static IEnumerable<IStock> GetStocks(string workplaceId)
        {
            var stocks = GetWarehouseStocks(workplaceId).Cast<IStock>()
                .Concat(GetRetailStoreStocks(workplaceId)).ToList();
            return stocks.Any()
                ? stocks
                : throw new ArgumentException($"Workplace id \"{workplaceId}\" does not exist.");
        }

        /// <summary>
        /// Get the stock of all products from the specified retail store
        /// </summary>
        public static IEnumerable<RetailStoreStock> GetRetailStoreStocks(string retailStoreId)
        {
            var command = new MySqlCommand(
                @"select product_id, retail_store_id, quantity, selling_price, restock_level
                        from retail_store_stock
                        WHERE retail_store_id = @retailStoreId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows select ConvertToRetailStoreStock(row);
        }

        private static RetailStoreStock ConvertToRetailStoreStock(DataRow row)
        {
            string productId = row.Field<int>("product_id").ToString();
            var product = ProductRepository.FindById(productId);
            decimal sellingPrice = row.Field<decimal>("selling_price");
            int quantity = row.Field<int>("quantity");
            int restockLevel = row.Field<int>("restock_level");
            string retailStoreId = row.Field<string>("retail_store_id");
            RetailStore retailStore = new RetailStoreRepository().GetById(retailStoreId);
            return new RetailStoreStock(product, retailStore, quantity, sellingPrice, restockLevel);
        }

        public static IEnumerable<WarehouseStock> GetWarehouseStocks(string warehouseId)
        {
            var command = new MySqlCommand(
                @"select warehouse_id, product_id, quantity, restock_level 
                    from warehouse_stock
                    where warehouse_id = @warehouse_id;");
            command.Parameters.AddWithValue("@warehouse_id", warehouseId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows select ConvertToWarehouseStock(row);
        }

        private static WarehouseStock ConvertToWarehouseStock(DataRow row)
        {
            string productId = row.Field<int>("product_id").ToString();
            var product = ProductRepository.FindById(productId);
            int quantity = row.Field<int>("quantity");
            int restockLevel = row.Field<int>("restock_level");
            Warehouse warehouse = WarehouseRepository.GetWarehouseById(row.Field<int>("warehouse_id").ToString());
            return new WarehouseStock(product, warehouse, quantity, restockLevel);
        }

        public static void InsertOrUpdate(IStock stock)
        {
            if (stock is RetailStoreStock retailStoreStock)
                InsertOrUpdateRetailStoreStock(retailStoreStock);
            else if (stock is WarehouseStock warehouseStock)
                InsertOrUpdateWarehouseStock(warehouseStock);
            else
                throw new ArgumentException("Unknown implementation of IStock class.");

            StockUpdated?.Invoke(null, stock);
        }

        public static void InsertOrUpdateRetailStoreStock(RetailStoreStock stock)
        {
            var command = new MySqlCommand(
                @"insert into retail_store_stock (product_id, retail_store_id, quantity, selling_price, restock_level) 
                    value (@productId, @retailStoreId, @quantity, @sellingPrice, @restockLevel)
                on duplicate key update selling_price = @sellingPrice,
                                        restock_level = @restockLevel,
                                        quantity = @quantity;");
            command.Parameters.AddWithValue("@productId", stock.Product.Id);
            command.Parameters.AddWithValue("@retailStoreId", stock.Workplace.Id);
            command.Parameters.AddWithValue("@sellingPrice", stock.SellingPrice);
            command.Parameters.AddWithValue("@restockLevel", stock.RestockLevel);
            command.Parameters.AddWithValue("@quantity", stock.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void InsertOrUpdateWarehouseStock(WarehouseStock stock)
        {
            var command = new MySqlCommand(
                @"insert into warehouse_stock (warehouse_id, product_id, quantity, restock_level)
                    value (@warehouseId, @productId, @quantity, @restockLevel)
                    on duplicate key update restock_level = @restockLevel, quantity = @quantity;");
            command.Parameters.AddWithValue("@warehouseId", stock.Workplace.Id);
            command.Parameters.AddWithValue("@productId", stock.Product);
            command.Parameters.AddWithValue("@restockLevel", stock.RestockLevel);
            command.Parameters.AddWithValue("@quantity", stock.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IStock FindByIds(string workplaceId, string productId)
        {
            var command = new MySqlCommand(
                @"select product_id, retail_store_id, quantity, selling_price, restock_level
                        from retail_store_stock
                        where retail_store_id = @retailStoreId
                        and product_id = @productId;");
            command.Parameters.AddWithValue("@retailStoreId", workplaceId);
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count != 0)
                return ConvertToRetailStoreStock(dataTable.Rows[0]);

            command = new MySqlCommand(
                @"select warehouse_id, product_id, quantity, restock_level from warehouse_stock
                where warehouse_id = @warehouseId and product_id = @productId");
            command.Parameters.AddWithValue("@warehouseId", workplaceId);
            command.Parameters.AddWithValue("@productId", productId);
            dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count != 0)
                return ConvertToWarehouseStock(dataTable.Rows[0]);
            throw new ArgumentException(
                $"No stock found for workplace id \"{workplaceId}\" and product id \"{productId}\".");
        }

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