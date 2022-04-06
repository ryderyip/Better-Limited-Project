using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Staff.StaffEntity
{
    public static class StaffTitleRepository
    {
        private static class StaffTitleMapper
        {
            public static StaffTitle Map(string titleName)
            {
                return titleName.ToLower() switch
                {
                    "sales representative" => StaffTitle.SalesRepresentative,
                    "sales manager" => StaffTitle.SalesManager,
                    "accounting clerk" => StaffTitle.AccountingClerk,
                    "accounting manager" => StaffTitle.AccountingManager,
                    "purchase clerk" => StaffTitle.PurchaseClerk,
                    "purchase manager" => StaffTitle.PurchaseManager,
                    "inventory clerk" => StaffTitle.InventoryClerk,
                    "receiving clerk" => StaffTitle.ReceivingClerk,
                    "technical support clerk" => StaffTitle.TechnicalSupportClerk,
                    "technical support manager" => StaffTitle.TechnicalSupportManager,
                    _ => StaffTitle.Unknown
                };
            }
        }
        
        public static StaffTitle GetTitle(string titleId)
        {
            string titleName = FindTitleName(titleId);
            return StaffTitleMapper.Map(titleName);
        }

        private static string FindTitleName(string titleId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT * FROM staff_title WHERE id = @id;", conn);
            command.Parameters.AddWithValue("@id", titleId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            return dataTable.Rows[0].Field<string>("name");
        }
    }
}