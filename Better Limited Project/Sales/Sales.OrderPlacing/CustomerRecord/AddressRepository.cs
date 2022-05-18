using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    public static class AddressRepository
    {
        public static Address GetAddressById(string id)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            string sql = @"select id as id,
                           address1 as address1,
                           address2 as address2
                            from delivery_address where id = @id;";
            var command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            if (dataTable.Rows.Count == 0)
                throw new ArgumentException("No address record with the provided address id is found.");
            return ConvertToAddress(dataTable.Rows[0]);
        }

        private static Address ConvertToAddress(DataRow row)
        {
            string address1 = row.Field<string>("address1");
            string address2 = row.Field<string>("address2");
            
            return new Address(address1, address2);
        }
    }
}