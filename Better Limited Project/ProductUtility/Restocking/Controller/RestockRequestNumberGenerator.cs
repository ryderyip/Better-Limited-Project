using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.Repository;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Restocking.Controller
{
    public static class RestockRequestNumberGenerator
    {
        public static string Generate(string retailStoreId)
        {
            var retailStore = new RetailStoreRepository().GetById(retailStoreId);
            return "RRR"
                   + retailStore.Id.ToUpper()
                   + DateTime.Today.ToString("yyMMdd")
                   + GetRequestNumber().PadLeft(6, '0');
        }

        private static string GetRequestNumber()
        {
            var command = new MySqlCommand(
                @"insert into restock_request_seq value ();
                    select last_insert_id() as id;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable.Rows[0].Field<ulong>("id").ToString();
        }
    }
}