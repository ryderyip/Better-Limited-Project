using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.Repository
{
    public static class ProductRepository
    {
        public static void UpdateProduct(Product product)
        {
            var command = new MySqlCommand(@"update product 
                    set name = @name, price = @price, description = @desc, 
                    is_phasing_out = @isPhasingOut,
                    category_id = @categoryId, supplier_id = @supplierId
                    where id = @id");
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.OriginalPrice);
            command.Parameters.AddWithValue("@desc", product.Description);
            command.Parameters.AddWithValue("@isPhasingOut", product.IsPhasingOut);
            command.Parameters.AddWithValue("@categoryId", product.Category.Id);
            command.Parameters.AddWithValue("@supplierId", product.SupplierEntity.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<Product> GetProducts()
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
            var id = row.Field<string>("id");
            var name = row.Field<string>("name");
            var originalPrice = row.Field<decimal>("price");
            var description = row.Field<string>("description");
            var isPhasingOut = row.Field<bool>("is_phasing_out");
            var category = CategoryRepository.GetById(row.Field<int>("category_id").ToString());
            var supplier = SupplierRepository.GetById(row.Field<int>("supplier_id").ToString());
            var product = new Product(id, name, originalPrice, description, supplier, category, isPhasingOut);
            return product;
        }

        public static void CreateNewProduct(string id, string name, decimal price, string description,
            bool isPhasingOut, string categoryId, string supplierId)
        {
            var command = new MySqlCommand(@"insert into product 
                values (@id, @name, @price, @description, @isPhasingOut, @categoryId, @supplierId)");
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@isPhasingOut", isPhasingOut);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            command.Parameters.AddWithValue("@supplierId", supplierId);
            DataTableRepository.ExecuteNonQuery(command);

            foreach (var retailStore in RetailStoreRepository.GetRetailStores())
            {
                command = new MySqlCommand(@"insert into retail_store_stock (product_id, retail_store_id, quantity)
                    value (@productId, @retailStoreId, @quantity)");
                command.Parameters.AddWithValue("@productId", id);
                command.Parameters.AddWithValue("@retailStoreId", retailStore.Id);
                command.Parameters.AddWithValue("@quantity", 0);
                DataTableRepository.ExecuteNonQuery(command);
            }
            
            foreach (var warehouse in WarehouseRepository.GetWarehouses())
            {
                command = new MySqlCommand(@"insert into warehouse_stock (product_id, warehouse_id, quantity)
                    value (@productId, @warehouse_id, @quantity)");
                command.Parameters.AddWithValue("@productId", id);
                command.Parameters.AddWithValue("@warehouse_id", warehouse.Id);
                command.Parameters.AddWithValue("@quantity", 0);
                DataTableRepository.ExecuteNonQuery(command);
            }
        }

        public static void DeleteProduct(Product product)
        {
            var command = new MySqlCommand(@"delete from product where id = @id;");
            command.Parameters.AddWithValue("@id", product.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}