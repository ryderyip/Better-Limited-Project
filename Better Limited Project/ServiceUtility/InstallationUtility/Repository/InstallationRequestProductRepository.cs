using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Repository
{
    public class InstallationRequestProductRepository
    {
        public static void InsertOrUpdate(InstallationRequestProduct installationRequestProduct)
        {
            var command = new MySqlCommand(
                @"insert into installation_request_product (installation_request_id, product_id, quantity) 
                    value (@requestId, @productId, @quantity) 
                    on duplicate key update quantity = @quantity;");
            command.Parameters.AddWithValue("@requestId", installationRequestProduct.InstallationRequestId);
            command.Parameters.AddWithValue("@productId", installationRequestProduct.ProductId);
            command.Parameters.AddWithValue("@quantity", installationRequestProduct.Quantity);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<InstallationRequestProduct> FindByRequestId(string installationRequestId)
        {
            var command = new MySqlCommand(
                @"select product_id, quantity 
                    from installation_request_product 
                    where installation_request_id = @requestId;");
            command.Parameters.AddWithValue("@requestId", installationRequestId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let productId = row.Field<int>("product_id").ToString()
                let quantity = row.Field<int>("quantity")
                select new InstallationRequestProduct(installationRequestId, productId, quantity);
        }
    }
}