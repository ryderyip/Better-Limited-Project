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
        public void Insert(Address address)
        {
            var command = new MySqlCommand(
                @"insert into delivery_address (id, address1, address2) value (@id, @address1, @address2)
                on duplicate key update address1 = @address1, address2 = @address2;");
            command.Parameters.AddWithValue("@id", address.Id);
            command.Parameters.AddWithValue("@address1", address.Address1);
            command.Parameters.AddWithValue("@address2", address.Address2);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static Address GetById(string id)
        {
            return GetAddresses().FirstOrDefault(address => address.Id == id)
                   ?? throw new ArgumentException($"Id \"{id}\" does not exist.");
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
                select new Address(address1, address2)
                {
                    Id = id
                };
        }

        public string GetNewId()
        {
            var datatable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from delivery_address;"));
            return ((from DataRow row in datatable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public void Remove(Address address)
        {
            var command = new MySqlCommand(@"delete from delivery_address where id = @id;");
            command.Parameters.AddWithValue("@id", address.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}