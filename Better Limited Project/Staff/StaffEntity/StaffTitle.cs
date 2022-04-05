using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Staff.StaffEntity
{
    public class StaffTitle
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public static class StaffTitleRepository
    {
        public static StaffTitle GetTitle(string titleId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                "SELECT * FROM staff_title WHERE id = $id;", conn);
            command.Parameters.AddWithValue("id", titleId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            return Convert(dataTable.Rows[0]);
        }
        
        private static StaffTitle Convert(DataRow row)
        {
            return new StaffTitle
            {
                Id = row.Field<string>("id"),
                Name = row.Field<string>("name")
            };
        }
    }
}