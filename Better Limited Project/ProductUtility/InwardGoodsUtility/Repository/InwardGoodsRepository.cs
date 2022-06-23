using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.Repository
{
    public static class InwardGoodsRepository
    {
        public static void Insert(InwardGoods inwardGoods)
        {
            var command = new MySqlCommand(
                @"insert into inward_goods (id, purchase_order_id, received_on) 
                    value (@id, @purchaseOrderId, @receivedOn)
                    on duplicate key update id = @id;");
            command.Parameters.AddWithValue("@id", inwardGoods.Id);
            command.Parameters.AddWithValue("@purchaseOrderId", inwardGoods.PurchaseOrderId);
            command.Parameters.AddWithValue("@receivedOn", inwardGoods.ReceivedOn);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<InwardGoods> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, purchase_order_id, received_on from inward_goods;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToInwardGoods(row);
        }

        private static InwardGoods ConvertToInwardGoods(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string purchaseOrderId = row.Field<int>("purchase_order_id").ToString();
            var receivedOn = row.Field<DateTime>("received_on");
            return new InwardGoods(id, purchaseOrderId, receivedOn);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from inward_goods;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static IEnumerable<InwardGoods> FindBy(Predicate<InwardGoods> filter)
        {
            return GetAll().Where(filter.Invoke);
        }
    }
}