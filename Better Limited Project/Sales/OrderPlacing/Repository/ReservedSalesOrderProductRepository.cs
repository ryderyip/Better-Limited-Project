using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public static class ReservedSalesOrderProductRepository
    {
        public static void InsertOrUpdate(ReservedSalesOrderProduct reservedSalesOrderProduct)
        {
            var command = new MySqlCommand(
                @"insert into reserved_sales_order_product (sales_order_id, product_id, quantity) 
                value (@orderId, @productId, @quantity)
                on duplicate key update quantity = @quantity;");
            command.Parameters.AddWithValue("@orderId", reservedSalesOrderProduct.SalesOrderId);
            command.Parameters.AddWithValue("@productId", reservedSalesOrderProduct.ProductId);
            command.Parameters.AddWithValue("@quantity", reservedSalesOrderProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<ReservedSalesOrderProduct> FindAll(Predicate<ReservedSalesOrderProduct> filter)
        {
            return GetAll().Where(filter.Invoke);
        }
        
        public static IEnumerable<ReservedSalesOrderProduct> GetAll()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select sales_order_id, product_id, quantity from reserved_sales_order_product;"));
            return from DataRow row in dataTable.Rows select ReservedSalesOrderProduct(row);
        }

        private static ReservedSalesOrderProduct ReservedSalesOrderProduct(DataRow row)
        {
            string orderId = row.Field<int>("sales_order_id").ToString();
            string productId = row.Field<int>("product_id").ToString();
            int quantity = row.Field<int>("quantity");
            return new ReservedSalesOrderProduct(orderId, productId, quantity);
        }

        public static ReservedSalesOrderProduct? FindByIds(string salesOrderId, string productId)
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, quantity from reserved_sales_order_product
                where sales_order_id = @orderId and product_id = @productId;");
            command.Parameters.AddWithValue("@orderId", salesOrderId);
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable.Rows.Count == 0 ? null : ReservedSalesOrderProduct(dataTable.Rows[0]);
        }

        public static void Delete(string salesOrderId, string productId)
        {
            var command = new MySqlCommand(
                @"delete from reserved_sales_order_product
                where sales_order_id = @orderId and product_id = @productId;");
            command.Parameters.AddWithValue("@orderId", salesOrderId);
            command.Parameters.AddWithValue("@productId", productId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}