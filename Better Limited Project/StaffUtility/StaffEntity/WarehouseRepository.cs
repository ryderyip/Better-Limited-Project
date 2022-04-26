using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class WarehouseRepository
    {
        public static List<Warehouse> GetWarehouses()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var dataReader = new MySqlCommand(
                "SELECT id, name, address FROM warehouse;", conn).ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToWarehouses(dataTable);
        }
        
        public static Warehouse GetWarehouse(string warehouseName)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"SELECT id, name, address 
                        FROM warehouse
                        WHERE name = @warehouseName;", conn);
            command.Parameters.AddWithValue("@warehouseName", warehouseName);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToWarehouses(dataTable).First();
        }
        
        private static List<Warehouse> ConvertToWarehouses(DataTable dataTable)
        {
            var warehouses = new List<Warehouse>();
            foreach (DataRow row in dataTable.Rows)
            {
                string id = row.Field<string>("id");
                string name = row.Field<string>("name");
                string address = row.Field<string>("address");
                var warehouse = new Warehouse(id, name, address);
                warehouses.Add(warehouse);
            }

            return warehouses;
        }
    }
}