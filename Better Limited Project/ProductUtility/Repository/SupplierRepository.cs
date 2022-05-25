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
        public static IEnumerable<SupplierEntity> GetSuppliers()
        {
            var command = new MySqlCommand(
                "select id, name, phone, email from supplier;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            return from DataRow row in dataTable.Rows 
                select new SupplierEntity(row.Field<int>("id").ToString(),
                    new Supplier(row.Field<string>("name"),
                        row.Field<string>("phone"),
                        row.Field<string>("email")));
        }

        public static SupplierEntity GetById(string id)
        {
            var command = new MySqlCommand(
                "select id, name, phone, email from supplier where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            return (from DataRow row in dataTable.Rows
                select new SupplierEntity(id,
                    new Supplier(row.Field<string>("name"),
                        row.Field<string>("phone"),
                        row.Field<string>("email")))).FirstOrDefault()
                ?? throw new ArgumentException($"Supplier Id \"{id}\" does not exist.");
        }

        public static void CreateSupplier(Supplier supplier)
        {
            var command = new MySqlCommand(
                @"insert into supplier (name, phone, email) 
                        value (@name, @phone, @email);");
            command.Parameters.AddWithValue("@name", supplier.Name);
            command.Parameters.AddWithValue("@phone", supplier.Phone);
            command.Parameters.AddWithValue("@email", supplier.Email);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void RemoveSupplier(string supplierId)
        {
            var command = new MySqlCommand(
                @"delete from supplier where id = @id;");
            command.Parameters.AddWithValue("@id", supplierId);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void UpdateSupplier(SupplierEntity supplier)
        {
            var command = new MySqlCommand(
                @"update supplier 
                        set name = @name, email = @email, phone = @phone
                        where id = @id");
            command.Parameters.AddWithValue("@id", supplier.Id);
            command.Parameters.AddWithValue("@name", supplier.Supplier.Name);
            command.Parameters.AddWithValue("@email", supplier.Supplier.Email);
            command.Parameters.AddWithValue("@phone", supplier.Supplier.Phone);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}