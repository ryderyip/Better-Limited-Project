using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Controller
{
    public static class SalesOrderNumberGenerator
    {
        public static string GetNewOrderNumber(string retailStoreId)
        {
            var command = new MySqlCommand(
                @"insert into sales_order_seq value ();
                    select last_insert_id() as id");
            var datatable = DataTableRepository.RetrieveDataTable(command);
            string sequence = datatable.Rows[0].Field<ulong>("id").ToString();
            return retailStoreId + DateTime.Today.ToString("yyyy-MM-dd") + sequence.PadLeft(6, '0');
        }
    }
}