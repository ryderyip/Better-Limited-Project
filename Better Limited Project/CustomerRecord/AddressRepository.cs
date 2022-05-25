using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.CustomerRecord
{
    public static class AddressRepository
    {
        public static AddressEntity GetAddressById(string id)
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

        private static AddressEntity ConvertToAddress(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string address1 = row.Field<string>("address1");
            string address2 = row.Field<string>("address2");
            var address = new Address(address1, address2);
            return new AddressEntity(id, address);
        }

        public static AddressEntity CreateAndReturn(Address address)
        {
            var command = new MySqlCommand(
                @"insert into delivery_address (address1, address2)
                        value (@address1, @address2);
                        select last_insert_id() as id;");
            command.Parameters.AddWithValue("@address1", address.Address1);
            command.Parameters.AddWithValue("@address2", address.Address2);
            var datatable = DataTableRepository.RetrieveDataTable(command);
            return new AddressEntity(datatable.Rows[0]["id"].ToString(), address);
        }

        public static IEnumerable<AddressEntity> GetAddresses()
        {
            var command = new MySqlCommand(
                @"select id, address1, address2
                            from delivery_address;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows select ConvertToAddress(row);
        }

        public static void UpdateAddress(AddressEntity addressEntity)
        {
            var address = addressEntity.Address;
            var command = new MySqlCommand(
                @"update delivery_address
                        set address1 = @address1, address2 = @address2
                        where id = @id");
            command.Parameters.AddWithValue("@id", addressEntity.Id);
            command.Parameters.AddWithValue("@address1", address.Address1);
            command.Parameters.AddWithValue("@address2", address.Address2);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}