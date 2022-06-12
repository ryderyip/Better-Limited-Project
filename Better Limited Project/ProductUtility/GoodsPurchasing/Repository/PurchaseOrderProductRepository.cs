using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository
{
    public static class PurchaseOrderProductRepository
    {
        public static IEnumerable<PurchaseOrderProduct> GetByOrderId(string purchaseOrderId)
        {
            var command = new MySqlCommand(
                @"select product_id, quantity from purchase_order_product 
                    where purchase_order_id = @orderId;");
            command.Parameters.AddWithValue("@orderId", purchaseOrderId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let productId = row.Field<int>("product_id").ToString()
                let quantity = row.Field<int>("quantity")
                select new PurchaseOrderProduct(purchaseOrderId, productId, quantity);
        }

        public static void InsertOrUpdate(PurchaseOrderProduct purchaseOrderProduct)
        {
            var command = new MySqlCommand(
                @"insert into purchase_order_product (purchase_order_id, product_id, quantity) 
                        value (@orderId, @productId, @quantity)
                    on duplicate key update quantity = @quantity;");
            command.Parameters.AddWithValue("@orderId", purchaseOrderProduct.PurchaseOrderId);
            command.Parameters.AddWithValue("@productId", purchaseOrderProduct.ProductId);
            command.Parameters.AddWithValue("@quantity", purchaseOrderProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}