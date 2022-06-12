using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.Repository;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestNumberGenerator
    {
        public static string Generate(string warehouseId)
        {
            var warehouse = WarehouseRepository.GetById(warehouseId);
            return warehouse.Abbreviation.ToUpper() + DateTime.Today.ToString("yyMMdd") + GetRequestNumber().PadLeft(6, '0');
        }

        private static string GetRequestNumber()
        {
            var command = new MySqlCommand(
                @"select max(id) as id from reorder_request_seq;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            var maxId = dataTable.Rows[0].Field<int?>("id");
            return maxId is null ? "1" : maxId.Value.ToString();
        }
    }
}