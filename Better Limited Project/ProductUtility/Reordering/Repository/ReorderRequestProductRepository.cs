using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestProductRepository
    {
        public static void InsertOrUpdate(ReorderRequestProduct requestedRequestProduct)
        {
            var command = new MySqlCommand(
                @"insert into reorder_request_product
                    value (@reorderRequestId, @productId, @quantity)
                    on duplicate key update quantity = @quantity;");
            command.Parameters.AddWithValue("@reorderRequestId", requestedRequestProduct.RequestId);
            command.Parameters.AddWithValue("@productId", requestedRequestProduct.Product.Id);
            command.Parameters.AddWithValue("@quantity", requestedRequestProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<ReorderRequestProduct> GetBy(ReorderRequest reorderRequest)
        {
            var command = new MySqlCommand(
                @"select product_id, quantity from reorder_request_product
                    where reorder_request_id = @requestId;");
            command.Parameters.AddWithValue("@requestId", reorderRequest.Id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows 
                select ConvertToReorderRequestProduct(reorderRequest, row);
        }

        private static ReorderRequestProduct ConvertToReorderRequestProduct(ReorderRequest reorderRequest, DataRow row)
        {
            string productId = row.Field<int>("product_id").ToString();
            int quantity = row.Field<int>("quantity");
            return new ReorderRequestProduct(reorderRequest.Id, productId, quantity);
        }

        public static void Delete(ReorderRequestProduct requestedRequestProduct)
        {
            var command = new MySqlCommand(
                @"delete from reorder_request_product 
                where reorder_request_id = @requestId and product_id = @productId;");
            command.Parameters.AddWithValue("@requestId", requestedRequestProduct.RequestId);
            command.Parameters.AddWithValue("@productId", requestedRequestProduct.ProductId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}