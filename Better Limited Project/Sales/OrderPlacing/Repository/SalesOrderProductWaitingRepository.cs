using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public static class SalesOrderProductWaitingRepository
    {
        public static IEnumerable<SalesOrderProductWaitingForStock> GetAll()
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, quantity, created_on
                    from stock_waiting_list;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select Convert(row);
        }

        private static SalesOrderProductWaitingForStock Convert(DataRow row)
        {
            string orderId = row.Field<int>("sales_order_id").ToString();
            string productId = row.Field<int>("product_id").ToString();
            var quantity = row.Field<int>("quantity");
            var createOn = row.Field<DateTime>("created_on");
            return new SalesOrderProductWaitingForStock(orderId, productId, quantity, createOn);
        }

        public static IEnumerable<SalesOrderProductWaitingForStock> FindBySalesOrderId(string salesOrderId)
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, quantity, created_on
                    from stock_waiting_list
                where sales_order_id = @orderId;");
            command.Parameters.AddWithValue("@orderId", salesOrderId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select Convert(row);
        }

        public static void InsertOrUpdate(SalesOrderProductWaitingForStock salesOrderProductWaitingForStock)
        {
            var command = new MySqlCommand(
                @"insert into stock_waiting_list (sales_order_id, product_id, quantity) 
                value (@orderId, @productId, @quantity)
                on duplicate key update quantity = @quantity;");
            command.Parameters.AddWithValue("@orderId", salesOrderProductWaitingForStock.SalesOrderId);
            command.Parameters.AddWithValue("@productId", salesOrderProductWaitingForStock.ProductId);
            command.Parameters.AddWithValue("@quantity", salesOrderProductWaitingForStock.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void Delete(SalesOrderProductWaitingForStock salesOrderProductWaitingForStock)
        {
            var command = new MySqlCommand(
                @"delete from stock_waiting_list where product_id = @productId and sales_order_id = @orderId;");
            command.Parameters.AddWithValue("@productId", salesOrderProductWaitingForStock.ProductId);
            command.Parameters.AddWithValue("@orderId", salesOrderProductWaitingForStock.SalesOrderId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}