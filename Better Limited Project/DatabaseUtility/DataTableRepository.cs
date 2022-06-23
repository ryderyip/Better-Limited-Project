using System.Data;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.DatabaseUtility
{
    /// <summary>
    ///     Provide functionality for basic database operations
    /// </summary>
    public static class DataTableRepository
    {
        public static DataTable RetrieveDataTable(MySqlCommand mySqlCommand)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            mySqlCommand.Connection = conn;
            var dataReader = mySqlCommand.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return dataTable;
        }

        public static void ExecuteNonQuery(params MySqlCommand[] mySqlCommand)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            foreach (var command in mySqlCommand)
            {
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
        }
    }
}