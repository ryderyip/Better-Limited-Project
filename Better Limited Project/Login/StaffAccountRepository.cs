using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Login
{
    public static class StaffAccountRepository
    {
        public static IEnumerable<StaffAccount> GetStaffAccounts()
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
            
            return dataTable.Rows[0].Field<string>("staff_id");
        }

        private static List<StaffAccount> ConvertToStaffAccounts(DataTable dataTable)
        {
            var staffAccounts = new List<StaffAccount>();
            foreach (DataRow row in dataTable.Rows)
            {
                string staffId = row.Field<string>("staff_id");
                string username = row.Field<string>("username");
                string password = row.Field<string>("password");
                var account = new StaffAccount(staffId, username, password);
                staffAccounts.Add(account);
            }

            return staffAccounts;
        }
    }
}