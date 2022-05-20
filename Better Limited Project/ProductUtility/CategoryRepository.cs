using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility
{
    public static class CategoryRepository
    {
        public static Category GetById(string categoryId)
        {
            var command = new MySqlCommand(
                "select name from product_category WHERE id = @categoryId;");
            command.Parameters.AddWithValue("@categoryId", categoryId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return new Category(categoryId, dataTable.Rows[0].ToString());
        }
    }
}