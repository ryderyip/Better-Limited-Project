using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class StaffTitleRepository
    {
        public static StaffTitle GetTitle(string titleId)
        {
            string titleName = FindTitleName(titleId);
            return new StaffTitleMapper().Map(titleName);
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