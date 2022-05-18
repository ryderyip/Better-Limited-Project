using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    public static class CustomerRepository
    {
        public static Customer GetCustomerById(string customerId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            string sql = @"select id as id, 
                            name as name, 
                            delivery_address_id as address_id, 
                            phone as phone, 
                            email as email
                            from customer where id = @id;";
            var command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", customerId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            if (dataTable.Rows.Count == 0)
                throw new ArgumentException("No customer record with the provided customer name is found.");
            return ConvertToCustomer(dataTable.Rows[0]);
        }
        
        public static Customer GetCustomerByName(string customerName)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            string sql = @"select id as id, 
                            name as name, 
                            delivery_address_id as address_id, 
                            phone as phone, 
                            email as email
                            from customer where name = @name;";
            var command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@name", customerName);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            if (dataTable.Rows.Count == 0)
                throw new ArgumentException("No customer record with the provided customer name is found.");
            return ConvertToCustomer(dataTable.Rows[0]);
        }

        private static Customer ConvertToCustomer(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string name = row.Field<string>("name");
            string phone = row.Field<string>("phone");
            string addressId = row.Field<int>("address_id").ToString();
            string email = row.Field<string>("email");

            return new Customer(name, phone)
            {
                Id = id,
                Address = AddressRepository.GetAddressById(addressId),
                Email = email
            };
        }
    }
}