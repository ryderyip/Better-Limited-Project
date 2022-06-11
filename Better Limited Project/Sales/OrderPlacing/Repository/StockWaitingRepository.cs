using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class StockWaitingRepository
    {
        public IEnumerable<Stock> GetAll()
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, quantity
                    from stock_waiting_list;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select Convert(row);
        }

        private Stock Convert(DataRow row)
        {
            string orderId = row.Field<int>("sales_order_id").ToString();
            string productId = row.Field<int>("product_id").ToString();
            int quantity = row.Field<int>("quantity");
            return new Stock(orderId, productId, quantity);
        }

        public Stock FindByIds(string salesOrderId, string productId)
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, quantity
                    from stock_waiting_list
                where sales_order_id = @orderId and product_id = @productId;");
            command.Parameters.AddWithValue("@orderId", salesOrderId);
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return Convert(dataTable.Rows[0]);
        }

        public void InsertOrUpdate(Stock stock)
        {
            var command = new MySqlCommand(
                @"insert into stock_waiting_list (sales_order_id, product_id, quantity) 
                value (@orderId, @productId, @quantity)
                on duplicate key update quantity = @quantity;");
            command.Parameters.AddWithValue("@orderId", stock.SalesOrderId);
            command.Parameters.AddWithValue("@productId", stock.ProductId);
            command.Parameters.AddWithValue("@quantity", stock.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}