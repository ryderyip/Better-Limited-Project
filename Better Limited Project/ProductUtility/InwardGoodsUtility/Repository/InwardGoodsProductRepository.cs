using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.Repository
{
    public static class InwardGoodsProductRepository
    {
        public static void InsertOrUpdate(InwardGoodsProduct inwardGoodsProduct)
        {
            var command = new MySqlCommand(
                @"insert into inward_goods_product (inward_goods_id, product_id, quantity) 
                        value (@inwardGoodsId, @productId, @quantity) 
                    on duplicate  key update quantity = @quantity;");
            command.Parameters.AddWithValue("@inwardGoodsId", inwardGoodsProduct.InwardGoodsId);
            command.Parameters.AddWithValue("@productId", inwardGoodsProduct.ProductId);
            command.Parameters.AddWithValue("@quantity", inwardGoodsProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<InwardGoodsProduct> GetByInwardGoodsId(string inwardGoodsId)
        {
            var command = new MySqlCommand(
                @"select product_id, quantity from inward_goods_product 
                where inward_goods_id = @inwardGoodsId;");
            command.Parameters.AddWithValue("@inwardGoodsId", inwardGoodsId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToInwardGoodsProduct(inwardGoodsId, row);
        }

        private static InwardGoodsProduct ConvertToInwardGoodsProduct(string inwardGoodsId, DataRow row)
        {
            string productId = row.Field<int>("product_id").ToString();
            var quantity = row.Field<int>("quantity");
            return new InwardGoodsProduct(inwardGoodsId, productId, quantity);
        }
    }
}