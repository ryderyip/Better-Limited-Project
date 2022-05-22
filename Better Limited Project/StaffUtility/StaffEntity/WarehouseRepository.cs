using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class WarehouseRepository
    {
        public static IEnumerable<Warehouse> GetWarehouses()
        {
            var command = new MySqlCommand(
                "SELECT id, name, address FROM warehouse;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToWarehouses(dataTable);
        }
        
        private static IEnumerable<Warehouse> ConvertToWarehouses(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
                return Enumerable.Empty<Warehouse>();

            return (from DataRow row in dataTable.Rows 
                let id = row.Field<string>("id") 
                let name = row.Field<string>("name") 
                let address = row.Field<string>("address") 
                select new Warehouse(id, name, address)).ToList();
        }
        
        public static Warehouse GetWarehouseById(string id)
        {
            var command = new MySqlCommand(
                @"select id, name, address
                        from warehouse
                        where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToWarehouses(dataTable).FirstOrDefault()
                   ?? throw new ArgumentException($"Warehouse id \'{id}\' does not exist.");
        }
    }
}