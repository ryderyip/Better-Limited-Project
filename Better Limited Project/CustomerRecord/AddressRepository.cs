using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.CustomerRecord
{
    public class AddressRepository : IRepositoryInsert<Address>
    {
        public static Address GetAddressById(string id)
        {
            return GetAddresses().FirstOrDefault(address => address.Id == id)
                   ?? throw new ArgumentException($"Id \"{id}\" does not exist.");
        }

        public void Insert(Address address)
        {
            var command = new MySqlCommand(
                @"insert into delivery_address (address1, address2)
                        value (@address1, @address2);
                        select last_insert_id() as id;");
            command.Parameters.AddWithValue("@address1", address.Address1);
            command.Parameters.AddWithValue("@address2", address.Address2);
            var datatable = DataTableRepository.RetrieveDataTable(command);

            address.Id = datatable.Rows[0].Field<ulong>("id").ToString();
        }

        public static IEnumerable<Address> GetAddresses()
        {
            var command = new MySqlCommand(
                @"select id, address1, address2
                            from delivery_address;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows
                let id = row.Field<int>("id").ToString()
                let address1 = row.Field<string>("address1")
                let address2 = row.Field<string>("address2")
                select new Address
                {
                    Id = id, Address1 = address1, Address2 = address2
                };
        }

        public static void UpdateAddress(Address address)
        {
            var command = new MySqlCommand(
                @"update delivery_address
                        set address1 = @address1, address2 = @address2
                        where id = @id");
            command.Parameters.AddWithValue("@id", address.Id);
            command.Parameters.AddWithValue("@address1", address.Address1);
            command.Parameters.AddWithValue("@address2", address.Address2);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}