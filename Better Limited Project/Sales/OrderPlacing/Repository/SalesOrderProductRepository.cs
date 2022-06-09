using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class SalesOrderProductRepository
    {
        public void InsertOrUpdate(SalesOrderProduct salesOrderProduct)
        {
            var command = new MySqlCommand(
                @"insert into sales_order_product 
                        value (@salesOrderId, @productId, @price, @quantity, @is_out_of_stock)
                    on duplicate key update price = @price, quantity = @quantity, is_out_of_stock = @is_out_of_stock");
            command.Parameters.AddWithValue("@salesOrderId", salesOrderProduct.SalesOrderId);
            command.Parameters.AddWithValue("@productId", salesOrderProduct.ProductId);
            command.Parameters.AddWithValue("@price", salesOrderProduct.Price);
            command.Parameters.AddWithValue("@quantity", salesOrderProduct.Quantity);
            command.Parameters.AddWithValue("@is_out_of_stock", salesOrderProduct.IsOutOfStock);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public IEnumerable<SalesOrderProduct> GetAll()
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, price, quantity, is_out_of_stock from sales_order_product;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToSalesOrderProduct(row);
        }

        private SalesOrderProduct ConvertToSalesOrderProduct(DataRow row)
        {
            string salesOrderId = row.Field<int>("sales_order_id").ToString();
            string productId = row.Field<int>("product_id").ToString();
            decimal price = row.Field<decimal>("price");
            int quantity = row.Field<int>("quantity");
            bool isOutOfStock = row.Field<bool>("is_out_of_stock");
            return new SalesOrderProduct(salesOrderId, productId, price, quantity, isOutOfStock)
            {
                SalesOrderProductPaymentIds = SalesOrderProductPaymentRepository.GetByIds(salesOrderId, productId)
                    .Select(sopp => sopp.PaymentId)
                    .ToList()
            };
        }

        public IEnumerable<SalesOrderProduct> FindAll(Predicate<SalesOrderProduct> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public IEnumerable<SalesOrderProduct> FindByOrderId(string salesOrderId)
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, price, quantity, is_out_of_stock 
                    from sales_order_product
                    where sales_order_id = @salesOrderId;");
            command.Parameters.AddWithValue("@salesOrderId", salesOrderId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToSalesOrderProduct(row);
        }

        public void Remove(SalesOrderProduct salesOrderProduct)
        {
            var command = new MySqlCommand(
                @"delete from sales_order_product where sales_order_id = @salesOrderId and product_id = @productId;");
            command.Parameters.AddWithValue("@salesOrderId", salesOrderProduct.SalesOrderId);
            command.Parameters.AddWithValue("@productId", salesOrderProduct.ProductId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}