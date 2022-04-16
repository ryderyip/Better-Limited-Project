using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.SettingsUtility
{
    public static class WarehouseRepository
    {
        public static List<Workplace> GetWarehouses()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var dataReader = new MySqlCommand(
                "SELECT name FROM warehouse;", conn).ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToWarehouses(dataTable);
        }

        /// <summary>
        /// Retrieve the address of the warehouse
        /// </summary>
        /// <param name="warehouseName">Name of the warehouse</param>
        /// <returns>Address of the warehouse. Return empty string if warehouse not found</returns>
        public static string GetWarehouseAddress(string warehouseName)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT address FROM warehouse WHERE name=@name;", conn);
            command.Parameters.AddWithValue("@name", warehouseName);
            var dataReader = command.ExecuteReader();
            
            dataTable.Load(dataReader);
            dataReader.Close();

            return dataTable.Rows[0]["address"].ToString();
        }

        private static List<Workplace> ConvertToWarehouses(DataTable dataTable)
        {
            var warehouses = new List<Workplace>();
            foreach (DataRow row in dataTable.Rows)
            {
                string name = row.Field<string>("name");
                var warehouse = new Workplace(WorkplaceType.Warehouse, name);
                warehouses.Add(warehouse);
            }

            return warehouses;
        }
    }
}