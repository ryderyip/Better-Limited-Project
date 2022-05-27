using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.CustomerRecord
{
    public class CustomerRepository : IRepository<Customer>, IRepositoryInsert<Customer>, IRepositoryDelete<Customer>,
        IRepositoryUpdate<Customer>
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

            return new Customer
            {
                Id = id,
                Email = email,
                Name = name, Phone = phone, Address = address
            };
        }

        public void Insert(Customer customer)
        {
            new AddressRepository().Insert(customer.Address);

            var command = new MySqlCommand(
                @"insert into customer (name, delivery_address_id, phone, email) 
                                value (@name, @addressId, @phone, @email);
                            select last_insert_id() as id;");
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@addressId", customer.Address.Id);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email != null ? customer.Email : DBNull.Value);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            customer.Id = dataTable.Rows[0].Field<ulong>("id").ToString();
        }

        public void Delete(Customer customer)
        {
            var command = new MySqlCommand(@"delete from customer where id = @id;");
            command.Parameters.AddWithValue("@id", customer.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public void Update(Customer customer)
        {
            var command = new MySqlCommand(
                @"update customer 
                        set name = @name, email = @email, phone = @phone
                        where id = @id;");
            command.Parameters.AddWithValue("@id", customer.Id);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            DataTableRepository.ExecuteNonQuery(command);

            AddressRepository.UpdateAddress(customer.Address);
        }

        public Customer? FindById(string id)
        {
            return FindAll(ce => ce.Id == id).FirstOrDefault();
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
    }
}