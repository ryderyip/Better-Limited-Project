using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Login
{
    public static class StaffAccountRepository
    {
        public static List<StaffAccount> GetStaffAccounts()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var dataReader = new MySqlCommand(
                "SELECT * FROM staff_account;", conn).ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToStaffAccounts(dataTable);
        }

        public static string GetStaffIdByUsername(string username)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT staff_id FROM staff_account WHERE username = @username;", conn);

            command.Parameters.AddWithValue("@username", username);
                
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            return dataTable.Rows[0].Field<string>("staff_id");
        }

        private static List<StaffAccount> ConvertToStaffAccounts(DataTable dataTable)
        {
            var staffAccounts = new List<StaffAccount>();
            foreach (DataRow row in dataTable.Rows)
            {

                var account = new StaffAccount
                {
                    StaffId = row.Field<string>("staff_id"),
                    Username = row.Field<string>("username"),
                    Password = row.Field<string>("password")
                };
                staffAccounts.Add(account);
            }

            return staffAccounts;
        }
    }
}