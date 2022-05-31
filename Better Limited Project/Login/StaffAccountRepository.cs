using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Login
{
    public static class StaffAccountRepository
    {
        public static IEnumerable<StaffAccount> GetAll()
        {
            var command = new MySqlCommand(
                "SELECT staff_id, username, password FROM staff_account;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToStaffAccounts(dataTable);
        }

        public static string GetStaffIdByUsername(string username)
        {
            var command = new MySqlCommand(
                "SELECT staff_id FROM staff_account WHERE username = @username;");
            command.Parameters.AddWithValue("@username", username);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            return dataTable.Rows[0].Field<int>("staff_id").ToString();
        }

        private static List<StaffAccount> ConvertToStaffAccounts(DataTable dataTable)
        {
            var staffAccounts = new List<StaffAccount>();
            foreach (DataRow row in dataTable.Rows)
            {
                string staffId = row.Field<int>("staff_id").ToString();
                string username = row.Field<string>("username");
                string password = row.Field<string>("password");
                var account = new StaffAccount(staffId, username, password);
                staffAccounts.Add(account);
            }

            return staffAccounts;
        }

        public static void CreateAccount(StaffAccount account)
        {
            var command = new MySqlCommand(
                "insert into staff_account value (@id, @username, @password);");
            command.Parameters.AddWithValue("@id", account.StaffId);
            command.Parameters.AddWithValue("@username", account.Username);
            command.Parameters.AddWithValue("@password", account.Password);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void UpdatePassword(string staffId, string newPassword)
        {
            var command = new MySqlCommand(
                "update staff_account set password = @newPassword where staff_id = @staffId");
            command.Parameters.AddWithValue("@staffId", staffId);
            command.Parameters.AddWithValue("@newPassword", newPassword);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}