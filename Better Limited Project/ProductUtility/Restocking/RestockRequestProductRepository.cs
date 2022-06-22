using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public static class RestockRequestProductRepository
    {
        public static void Insert(RestockRequestProduct requestedProduct)
        {
            var command = new MySqlCommand(
                @"insert into restock_request_product
                    value (@restockRequestId, @productId, @quantity)");
            command.Parameters.AddWithValue("@restockRequestId", requestedProduct.RestockRequestId);
            command.Parameters.AddWithValue("@productId", requestedProduct.Product.Id);
            command.Parameters.AddWithValue("@quantity", requestedProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<RestockRequestProduct> GetByRequestId(RestockRequest restockRequest)
        {
            var command = new MySqlCommand(
                @"select product_id, quantity 
                from restock_request_product
                where restock_request_id = @restockRequestId");
            command.Parameters.AddWithValue("@restockRequestId", restockRequest.Id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let productId = row.Field<int>("product_id").ToString()
                let quantity = row.Field<int>("quantity")
                select new RestockRequestProduct(restockRequest.Id, productId, quantity);
        }

        public static void Remove(RestockRequestProduct restockRequestProduct)
        {
            var command = new MySqlCommand(
                @"delete from restock_request_product where restock_request_id = @requestId;");
            command.Parameters.AddWithValue("@requestId", restockRequestProduct.RestockRequestId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}