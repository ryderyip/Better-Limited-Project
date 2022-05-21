using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility
{
    public static class ProductRepository
    {
        public static Product GetProductById(string productId)
        {
            var command = new MySqlCommand(
                @"select p.id, p.name, p.price, p.description, 
                            p.is_phasing_out, pc.id as category_id, 
                            s.name as supplier, s.phone as supplier_phone, s.email as supplier_email
                        from product p
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        WHERE p.id = @productId;");
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToProduct(dataTable.Rows[0]);
        }
        
        public static Product GetProductByName(string productName)
        {
            var command = new MySqlCommand(
                @"select p.id, p.name, p.price, p.description, 
                            p.is_phasing_out, pc.id as category_id, 
                            s.name as supplier, s.phone as supplier_phone, s.email as supplier_email
                        from product p
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        WHERE p.name = @productName;");
            command.Parameters.AddWithValue("@productName", productName);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToProduct(dataTable.Rows[0]);
        }

        private static Product ConvertToProduct(DataRow row)
        {
            string supplierName = row.Field<string>("supplier");
            string supplierPhone = row.Field<string>("supplier_phone");
            string supplierEmail = row.Field<string>("supplier_email");

            var product = new Product();
            product.Id = row.Field<string>("id");
            product.Name = row.Field<string>("name");
            product.OriginalPrice = row.Field<decimal>("price");
            product.Description = row.Field<string>("description");
            product.IsPhasingOut = row.Field<bool>("is_phasing_out");
            product.Category = CategoryRepository.GetById(row.Field<int>("category_id").ToString());
            product.Supplier = new Supplier(supplierName, supplierPhone, supplierEmail);
            return product;
        }

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
            command.Parameters.AddWithValue("@categoryId", product.Category!.Id);
            command.Parameters.AddWithValue("@supplierId", product.Name);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}