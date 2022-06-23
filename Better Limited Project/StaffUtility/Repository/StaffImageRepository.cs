using System.Data;
using System.Drawing;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.Repository
{
    public class StaffImageRepository
    {
        public static Image? GetByStaffId(string staffId)
        {
            var command = new MySqlCommand(
                @"select image from staff_image where staff_id = @staffId;");
            command.Parameters.AddWithValue("@staffId", staffId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                return null;
            var bytes = dataTable.Rows[0].Field<byte[]>("image");
            return new ImageConverter().ConvertFrom(bytes) as Image;
        }

        public static void InsertOrUpdate(Staff staff, Image image)
        {
            var command = new MySqlCommand(
                @"insert into staff_image 
                    set staff_id = @staffId, image = @image
                    on duplicate key update image = @image;");
            command.Parameters.AddWithValue("@staffId", staff.Id);
            command.Parameters.AddWithValue("@image", ImageToBytesConverter.Convert(image));

            DataTableRepository.ExecuteNonQuery(command);
        }

        public static void Delete(string staffId)
        {
            var command = new MySqlCommand(
                @"delete from staff_image 
                    where staff_id = @staffId;");
            command.Parameters.AddWithValue("@staffId", staffId);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}