using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class SalesOrderProductRepository
    {
        public void Insert(SalesOrderProduct salesOrderProduct)
        {
            var command = new MySqlCommand(
                @"insert into sales_order_product 
                        value (@salesOrderId, @productId, @price, @quantity, @isDeposit, @paymentId)");
            command.Parameters.AddWithValue("salesOrderId", salesOrderProduct.SalesOrderId);
            command.Parameters.AddWithValue("productId", salesOrderProduct.Product.Id);
            command.Parameters.AddWithValue("price", salesOrderProduct.Price);
            command.Parameters.AddWithValue("quantity", salesOrderProduct.Quantity);
            command.Parameters.AddWithValue("isDeposit", salesOrderProduct.IsDeposit);
            command.Parameters.AddWithValue("paymentId", salesOrderProduct.Payment.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public IEnumerable<SalesOrderProduct> GetAll()
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, price, quantity, is_deposit 
                        from sales_order_product;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                select new SalesOrderProduct
                {
                    SalesOrderId = row.Field<string>("sales_order_id"),
                    Product = ProductRepository.FindById(row.Field<int>("product_id").ToString()),
                    Price = row.Field<decimal>("price"),
                    Quantity = row.Field<int>("quantity"),
                    IsDeposit = row.Field<bool>("is_deposit")
                };
        }

        public IEnumerable<SalesOrderProduct> FindAll(Predicate<SalesOrderProduct> filter)
        {
            return GetAll().Where(filter.Invoke);
        }
    }
}