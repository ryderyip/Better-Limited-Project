using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public class RetailStoreRepository
    {
        public IEnumerable<RetailStore> GetRetailStores()
        {
            return FindAll(_ => true);
        }

        public RetailStore GetById(string id)
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

        private IEnumerable<RetailStore> ConvertToRetailStores(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
                return Enumerable.Empty<RetailStore>();

            return (from DataRow row in dataTable.Rows
                let id = row.Field<string>("id")
                let name = row.Field<string>("name")
                let address = row.Field<string>("address")
                select new RetailStore(id, name, address)).ToList();
        }

        public IEnumerable<RetailStore> GetAll()
        {
            var command = new MySqlCommand(
                "SELECT id, name, address FROM retail_store;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToRetailStores(dataTable);
        }

        public IEnumerable<RetailStore> FindAll(Predicate<RetailStore> filter)
        {
            return GetAll().Where(filter.Invoke);
        }
    }
}