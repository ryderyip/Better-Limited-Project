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
                        value (@salesOrderId, @productId, @price, @quantity, @isDeposit)");
            command.Parameters.AddWithValue("salesOrderId", salesOrderProduct.SalesOrderId);
            command.Parameters.AddWithValue("productId", salesOrderProduct.Product.Id);
            command.Parameters.AddWithValue("price", salesOrderProduct.Price);
            command.Parameters.AddWithValue("quantity", salesOrderProduct.Quantity);
            command.Parameters.AddWithValue("isDeposit", salesOrderProduct.IsDeposit);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public IEnumerable<SalesOrderProduct> GetAll()
        {
            var command = new MySqlCommand(
                @"select sales_order_id, product_id, price, quantity, is_deposit 
                        from sales_order_product;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let salesOrderId = new Guid(row.Field<byte[]>("sales_order_id")).ToString()
                let product = ProductRepository.FindById(row.Field<int>("product_id").ToString())
                let price = row.Field<decimal>("price")
                let quantity = row.Field<int>("quantity")
                select new SalesOrderProduct(salesOrderId, product, price, quantity)
                {
                    IsDeposit = row.Field<bool>("is_deposit")
                };
        }

        public IEnumerable<SalesOrderProduct> FindAll(Predicate<SalesOrderProduct> filter)
        {
            return GetAll().Where(filter.Invoke);
        }
    }
}