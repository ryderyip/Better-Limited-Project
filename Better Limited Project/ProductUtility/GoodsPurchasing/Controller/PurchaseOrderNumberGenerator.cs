using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.Repository;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.Controller
{
    public static class PurchaseOrderNumberGenerator
    {
        public static string Generate(string warehouseId)
        {
            var warehouse = WarehouseRepository.GetById(warehouseId);
            return "PO"
                   + warehouse.Abbreviation.ToUpper()
                   + DateTime.Today.ToString("yyMMdd")
                   + GetOrderNumber().PadLeft(6, '0');
        }

        private static string GetOrderNumber()
        {
            var command = new MySqlCommand(
                @"insert into purchase_order_seq value ();
                    select last_insert_id() as id;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable.Rows[0].Field<ulong>("id").ToString();
        }
    }
}