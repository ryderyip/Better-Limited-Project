using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.SupplierUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class SupplierRepository
    {
        public static IEnumerable<Supplier> GetSuppliers()
        {
            var command = new MySqlCommand(
                "select id, name, phone, email from supplier;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows
                select ConvertToSupplier(row);
        }

        public static Supplier GetById(string id)
        {
            var command = new MySqlCommand(
                "select id, name, phone, email from supplier where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return (from DataRow row in dataTable.Rows select ConvertToSupplier(row)).FirstOrDefault()
                   ?? throw new ArgumentException($"Supplier Id \"{id}\" does not exist.");
        }

        public static Supplier ConvertToSupplier(DataRow row)
        {
            return new Supplier(row.Field<int>("id").ToString(),
                row.Field<string>("name"),
                row.Field<string>("phone"),
                row.Field<string>("email"));
        }

        public static void InsertOrUpdate(Supplier supplier)
        {
            var command = new MySqlCommand(
                @"insert into supplier (name, phone, email) 
                        value (@name, @phone, @email)
                on duplicate key update name = @name, email = @email, phone = @phone;");
            command.Parameters.AddWithValue("@name", supplier.Name);
            command.Parameters.AddWithValue("@phone", supplier.Phone);
            command.Parameters.AddWithValue("@email", supplier.Email);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void Remove(Supplier supplier)
        {
            var command = new MySqlCommand(
                @"delete from supplier where id = @id;");
            command.Parameters.AddWithValue("@id", supplier.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static string GetNewId()
        {
            var datatable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from supplier;"));
            return ((from DataRow row in datatable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }
    }
}