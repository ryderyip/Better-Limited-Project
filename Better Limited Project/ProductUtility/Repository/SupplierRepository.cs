using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public class SupplierRepository
    {
        public static IEnumerable<Supplier> GetSuppliers()
        {
            var command = new MySqlCommand(
                "select id, name, phone, email from supplier;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            return from DataRow row in dataTable.Rows 
                select new Supplier(row.Field<int>("id").ToString(),
                    row.Field<string>("name"),
                    row.Field<string>("phone"),
                    row.Field<string>("email"));
        }

        public static Supplier GetById(string id)
        {
            var command = new MySqlCommand(
                "select id, name, phone, email from supplier where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            return (from DataRow row in dataTable.Rows
                select new Supplier(id,
                    row.Field<string>("name"),
                    row.Field<string>("phone"),
                    row.Field<string>("email"))).FirstOrDefault()
                ?? throw new ArgumentException($"Supplier Id \"{id}\" does not exist.");
        }
    }
}