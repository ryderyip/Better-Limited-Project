using System.Data;
using System.Drawing;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Tools;
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
            var image = new ImageConverter().ConvertFrom(bytes);
            return image != null ? (Bitmap) image : null;
        }

        public static void InsertOrUpdate(string productId, Image image)
        {
            var command = new MySqlCommand(
                @"insert into product_image 
                    set product_id = @productId, image = @image
                    on duplicate key update image = @image;");
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@image", ImageToBytesConverter.Convert(image));
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void Delete(string productId)
        {
            var command = new MySqlCommand(
                @"delete from product_image 
                    where product_id = @productId;");
            command.Parameters.AddWithValue("@productId", productId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}