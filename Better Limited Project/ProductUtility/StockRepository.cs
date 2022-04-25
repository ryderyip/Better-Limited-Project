using System.Collections.Generic;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility
{
    public static class StockRepository
    {
        
        public static List<ProductQuantity> GetStock(string retailStoreName)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select p.name as name, 
       price as original_price, 
       description, 
       is_phasing_out, 
       rss.quantity, 
       rss.selling_price, 
       pc.name as category, 
       s.name as supplier_name, 
       s.phone as supplier_phone, 
       s.email as supplier_email,
       rs.name as retail_store_name
from retail_store_stock rss
INNER JOIN product p on rss.product_id = p.id
INNER JOIN product_category pc on p.category_id = pc.id
INNER JOIN supplier s on p.supplier_id = s.id
INNER JOIN retail_store rs on rss.retail_store_id = rs.id
WHERE rs.name = @retailStoreName;", conn);
            command.Parameters.AddWithValue("@retailStoreName", retailStoreName);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return ConvertToStock(dataTable);
        }

        private static List<ProductQuantity> ConvertToStock(DataTable dataTable)
        {
            var stock = new List<ProductQuantity>();
            foreach (DataRow row in dataTable.Rows)
            {
                var product = new Product
                {
                    Name = row.Field<string>("name"),
                    OriginalPrice = row.Field<decimal>("original_price"),
                    SellingPrice = row.Field<decimal>("selling_price"),
                    Description = row.Field<string>("description"),
                    Category = row.Field<string>("category"),
                    IsPhasingOut = row.Field<bool>("is_phasing_out"),
                    Supplier = new Supplier
                    {
                        Name = row.Field<string>("supplier_name"),
                        Phone = row.Field<string>("supplier_phone"),
                        Email = row.Field<string>("supplier_email")
                    }
                };
                int quantity = row.Field<int>("quantity");
                stock.Add(new ProductQuantity(product, quantity));
            }

            return stock;
        }

    }
}