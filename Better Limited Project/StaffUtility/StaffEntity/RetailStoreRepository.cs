using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class RetailStoreRepository
    {
        public static List<RetailStore> GetRetailStores()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var dataReader = new MySqlCommand(
                "SELECT id, name, address FROM retail_store;", conn).ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToRetailStores(dataTable);
        }

        private static List<RetailStore> ConvertToRetailStores(DataTable dataTable)
        {
            var retailStores = new List<RetailStore>();
            foreach (DataRow row in dataTable.Rows)
            {
                string name = row.Field<string>("name");
                string address = row.Field<string>("address");
                var retailStore = new RetailStore(name, address);
                retailStores.Add(retailStore);
            }

            return retailStores;
        }
    }
}