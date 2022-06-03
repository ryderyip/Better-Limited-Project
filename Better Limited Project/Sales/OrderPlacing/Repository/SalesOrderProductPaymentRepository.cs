using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public static class SalesOrderProductPaymentRepository
    {
        public static IEnumerable<SalesOrderProductPayment> GetByIds(string salesOrderId, string productId)
        {
            var command = new MySqlCommand(
                @"select payment_id, product_quantity, is_deposit from sales_order_product_payment
                    where sales_order_id = @salesOrderId 
                      and product_id = @productId;");
            command.Parameters.AddWithValue("@salesOrderId", salesOrderId);
            command.Parameters.AddWithValue("@productId", productId);
            var datatable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in datatable.Rows
                let quantity = row.Field<int>("product_quantity")
                let paymentId = row.Field<int>("payment_id").ToString()
                let isDeposit = row.Field<bool>("is_deposit")
                select new SalesOrderProductPayment(salesOrderId, productId, paymentId, quantity, isDeposit);
        }

        public static void InsertOrUpdate(SalesOrderProductPayment salesOrderProductPayment)
        {
            var command = new MySqlCommand(
                @"insert into sales_order_product_payment 
                    value (@salesOrderId, @productId, @paymentId, @productQuantity, @isDeposit)
                    on duplicate key update product_quantity = @productQuantity, is_deposit = @isDeposit;");
            command.Parameters.AddWithValue("salesOrderId", salesOrderProductPayment.SalesOrderId);
            command.Parameters.AddWithValue("productId", salesOrderProductPayment.ProductId);
            command.Parameters.AddWithValue("paymentId", salesOrderProductPayment.PaymentId);
            command.Parameters.AddWithValue("productQuantity", salesOrderProductPayment.Quantity);
            command.Parameters.AddWithValue("isDeposit", salesOrderProductPayment.IsDeposit);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}