using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.SettingsUtility
{
    public static class WarehouseRepository
    {
        public static List<Warehouse> GetWarehouses()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var dataReader = new MySqlCommand(
                "SELECT name, address FROM warehouse;", conn).ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToWarehouses(dataTable);
        }

        private static List<Warehouse> ConvertToWarehouses(DataTable dataTable)
        {
            var warehouses = new List<Warehouse>();
            foreach (DataRow row in dataTable.Rows)
            {
                string name = row.Field<string>("name");
                string address = row.Field<string>("address");
                var warehouse = new Warehouse(name, address);
                warehouses.Add(warehouse);
            }

            return warehouses;
        }
    }
}