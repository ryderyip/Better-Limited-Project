using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class ProductRepository
    {
        public static IEnumerable<Product> GetAll()
        {
            var command = new MySqlCommand(
                @"select p.id, p.name, p.price, p.description, 
                            p.is_phasing_out, p.category_id as category_id, 
                            p.supplier_id as supplier_id
                        from product p;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            return from DataRow row in dataTable.Rows select ConvertToProduct(row);
        }
        
        private static Product ConvertToProduct(DataRow row)
        {
            var id = row.Field<int>("id").ToString();
            var name = row.Field<string>("name");
            var originalPrice = row.Field<decimal>("price");
            var description = row.Field<string>("description");
            var isPhasingOut = row.Field<bool>("is_phasing_out");
            var category = CategoryRepository.GetById(row.Field<int>("category_id").ToString());
            var supplier = SupplierRepository.GetById(row.Field<int>("supplier_id").ToString());
            var product = new Product(id, name, originalPrice, description, supplier, category, isPhasingOut);
            return product;
        }

        public static void InsertOrUpdate(Product product)
        {
            var command = new MySqlCommand(@"insert into product (id, name, price, description, is_phasing_out, category_id, supplier_id)
                values (@id, @name, @price, @description, @isPhasingOut, @categoryId, @supplierId)
                on duplicate key update name = @name, price = @price, description = @description, 
                    is_phasing_out = @isPhasingOut,
                    category_id = @categoryId, supplier_id = @supplierId;");
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.OriginalPrice);
            command.Parameters.AddWithValue("@description", product.Description);
            command.Parameters.AddWithValue("@isPhasingOut", product.IsPhasingOut);
            command.Parameters.AddWithValue("@categoryId", product.Category.Id);
            command.Parameters.AddWithValue("@supplierId", product.Supplier.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static Product FindById(string productId)
        {
            return GetAll().First(product => product.Id == productId);
        }

        public static string GetNewId()
        {
            var datatable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from product;"));
            return ((from DataRow row in datatable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static void Remove(Product product)
        {
            var command = new MySqlCommand(
                @"delete from product where id = @productId;");
            command.Parameters.AddWithValue("@productId", product.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}