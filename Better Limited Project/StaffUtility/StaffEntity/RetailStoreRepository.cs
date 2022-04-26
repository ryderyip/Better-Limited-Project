using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
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

        public static RetailStore GetRetailStore(string retailStoreName)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select id, name, address
                        from retail_store
                        where name = @retailStoreName;", conn);
            command.Parameters.AddWithValue("@retailStoreName", retailStoreName);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            var s = ConvertToRetailStores(dataTable).First();
            return s;
        }

        private static List<RetailStore> ConvertToRetailStores(DataTable dataTable)
        {
            var retailStores = new List<RetailStore>();
            foreach (DataRow row in dataTable.Rows)
            {
                string id = row.Field<string>("id");
                string name = row.Field<string>("name");
                string address = row.Field<string>("address");
                var retailStore = new RetailStore(id, name, address);
                retailStores.Add(retailStore);
            }

            return retailStores;
        }
    }
}