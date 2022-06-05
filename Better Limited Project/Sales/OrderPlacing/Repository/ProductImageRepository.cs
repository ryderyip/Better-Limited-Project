using System.Data;
using System.Drawing;
using System.IO;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public static class ProductImageRepository
    {
        public static Image? GetByProductId(string productId)
        {
            var command = new MySqlCommand(
                @"select image from product_image where product_id = @productId;");
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                return null;
            var bytes = dataTable.Rows[0].Field<byte[]>("image");
            return Image.FromStream(new MemoryStream(bytes));
        }
    }
}