using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public static class ProductRepository
    {
        public static string GetProducts()
        {
            using var conn = Database.GetConnection();
     
            conn.Open();
            var dataTable = new DataTable();
            
            var dataReader = new MySqlCommand(
                "SELECT * FROM product;", conn).ExecuteReader();
            dataTable.Load(dataReader);

            dataReader.Close();

            return ConvertToProducts(dataTable);
        }
        
        private static string ConvertToProducts(DataTable dataTable)
        {
            List<Product> products = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                var product = new Product()
                {
                    ProductID = row.Field<string>("id"),
                    ProductName = row.Field<string>("name"),
                    Description = row.Field<string>("description"),
                    Price = row.Field<decimal>("price"),
         

                };
                products.Add(product);
            }
            return dataTable.ToString();
        }
    }
}