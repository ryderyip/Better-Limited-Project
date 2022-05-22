using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class CategoryRepository
    {
        public static Category GetById(string categoryId)
        {
            var command = new MySqlCommand(
                "select name from product_category WHERE id = @categoryId;");
            command.Parameters.AddWithValue("@categoryId", categoryId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            if (dataTable.Rows.Count == 0)
                throw new InvalidOperationException($"Category id {categoryId} doesn't exist in database.");
            return new Category(categoryId, dataTable.Rows[0].ToString());
        }

        public static IEnumerable<Category> GetCategories()
        {
            var command = new MySqlCommand(
                "select id, name from product_category;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            
            
            return from DataRow row in dataTable.Rows 
                select new Category(row.Field<int>("id").ToString(),
                    row.Field<string>("name"));
        }
    }
}