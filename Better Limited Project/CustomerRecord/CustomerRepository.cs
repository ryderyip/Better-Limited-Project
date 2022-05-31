using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.CustomerRecord
{
    public class CustomerRepository : IRepository<Customer>, IRepositoryInsert<Customer>, IRepositoryDelete<Customer>
    {
        private Customer ConvertToCustomer(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string name = row.Field<string>("name");
            string phone = row.Field<string>("phone");
            string addressId = row.Field<int>("address_id").ToString();
            var address = AddressRepository.GetAddressById(addressId);
            string? email = row["email"] != DBNull.Value
                ? row.Field<string>("email")
                : null;

            return new Customer(name, phone, address, email)
            {
                Id = id
            };
        }

        public void Insert(Customer customer)
        {
            new AddressRepository().Insert(customer.Address);

            var command = new MySqlCommand(
                @"insert into customer (name, delivery_address_id, phone, email) 
                                value (@name, @addressId, @phone, @email)
                on duplicate key update name = @name, email = @email, phone = @phone, delivery_address_id = @addressId;");
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@addressId", customer.Address.Id);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email != null ? customer.Email : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public void Delete(Customer customer)
        {
            var command = new MySqlCommand(@"delete from customer where id = @id;");
            command.Parameters.AddWithValue("@id", customer.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public Customer FindById(string id)
        {
            return FindAll(ce => ce.Id == id).FirstOrDefault()
                ?? throw new ArgumentException($"Customer ID \"{id}\" does not exist.");
        }

        public IEnumerable<Customer> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, name, delivery_address_id as address_id, phone, email 
                        from customer;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToCustomer(row);
        }

        public IEnumerable<Customer> FindAll(Predicate<Customer> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public string GetId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select last_insert_id() as id from customer;"));
            return (from DataRow row in dataTable.Rows select row.Field<ulong>("id").ToString()).First();
        }
    }
}