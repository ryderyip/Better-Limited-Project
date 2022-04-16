using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.SettingsUtility
{
    public static class RetailStoreRepository
    {
        public static List<Workplace> GetRetailStores()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var dataReader = new MySqlCommand(
                "SELECT name, address FROM retail_store;", conn).ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToRetailStores(dataTable);
        }

        public static string GetRetailStoreAddress(string retailStoreName)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT address FROM retail_store WHERE name=@name;", conn);
            command.Parameters.AddWithValue("@name", retailStoreName);
            var dataReader = command.ExecuteReader();
            
            dataTable.Load(dataReader);
            dataReader.Close();

            return dataTable.Rows[0]["address"].ToString();
        }
        
        private static List<Workplace> ConvertToRetailStores(DataTable dataTable)
        {
            var retailStores = new List<Workplace>();
            foreach (DataRow row in dataTable.Rows)
            {
                string retailStoreName = row.Field<string>("name");
                var retailStore = new Workplace(WorkplaceType.RetailStore, retailStoreName);
                retailStores.Add(retailStore);
            }

            return retailStores;
        }
    }
}