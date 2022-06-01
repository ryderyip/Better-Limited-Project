using MySql.Data.MySqlClient;

namespace Better_Limited_Project.DatabaseUtility
{
    public static class Database
    {
        private const string ConnectString =
            "datasource=localhost; " +
            "username=root; " +
            "password=; " +
            "database=better_limited;" +
            "convert zero datetime=True;" +
            "old guids=true;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectString);
        }
    }
}