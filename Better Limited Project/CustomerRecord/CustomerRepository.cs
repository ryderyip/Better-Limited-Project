using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.CustomerRecord
{
    public static class CustomerRepository
    {
        private static CustomerEntity ConvertToCustomer(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string name = row.Field<string>("name");
            string phone = row.Field<string>("phone");
            string addressId = row.Field<int>("address_id").ToString();
            var address = AddressRepository.GetAddressById(addressId);
            string? email = row["email"] != DBNull.Value
                ? row.Field<string>("email")
                : null;

            var customer = new Customer(name, phone, address, email);
            return new CustomerEntity(customer, id);
        }

        public static CustomerEntity CreateAndRetrieve(Customer customer)
        {
            var addressEntity = AddressRepository.CreateAndReturn(customer.AddressEntity.Address);

            var command = new MySqlCommand(
                @"insert into customer (name, delivery_address_id, phone, email) 
                                value (@name, @addressId, @phone, @email);
                            select last_insert_id() as id;");
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@addressId", addressEntity.Id);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email != null ? customer.Email : DBNull.Value);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            string customerId = dataTable.Rows[0].Field<ulong>("id").ToString();
            return new CustomerEntity(customer, customerId);
        }

        public static IEnumerable<CustomerEntity> GetCustomers()
        {
            var command = new MySqlCommand(@"select id, name, delivery_address_id as address_id, phone, email from customer;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            if (dataTable.Rows.Count == 0)
                throw new ArgumentException("No customer record with the provided customer name is found.");
            return from DataRow row in dataTable.Rows select ConvertToCustomer(row);
        }

        public static void RemoveCustomer(string customerId)
        {
            var command = new MySqlCommand(@"delete from customer where id = @id;");
            command.Parameters.AddWithValue("@id", customerId);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void Update(CustomerEntity customerEntity)
        {
            var customer = customerEntity.Customer;
            var command = new MySqlCommand(
                @"update customer 
                        set name = @name, email = @email, phone = @phone
                        where id = @id;");
            command.Parameters.AddWithValue("@id", customerEntity.Id);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            DataTableRepository.ExecuteNonQuery(command);

            AddressRepository.UpdateAddress(customer.AddressEntity);
        }
    }
}