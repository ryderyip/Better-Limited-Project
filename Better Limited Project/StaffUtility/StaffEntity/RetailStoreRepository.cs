using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class RetailStoreRepository
    {
        public static IEnumerable<RetailStore> GetRetailStores()
        {
            var command = new MySqlCommand(
                "SELECT id, name, address FROM retail_store;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToRetailStores(dataTable);
        }

        public static RetailStore GetRetailStoreById(string id)
        {
            var command = new MySqlCommand(
                @"select id, name, address
                        from retail_store
                        where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToRetailStores(dataTable).FirstOrDefault()
                   ?? throw new ArgumentException($"Retail store id \'{id}\' does not exist.");
        }

        private static IEnumerable<RetailStore> ConvertToRetailStores(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
                return Enumerable.Empty<RetailStore>();

            return (from DataRow row in dataTable.Rows 
                let id = row.Field<string>("id") 
                let name = row.Field<string>("name") 
                let address = row.Field<string>("address") 
                select new RetailStore(id, name, address)).ToList();
        }
    }
}