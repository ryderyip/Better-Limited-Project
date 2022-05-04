using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public class UpdateSellingPriceController
    {
        public delegate void SellingPriceUpdatedEventHandler(object sender, EventArgs e);
        public event SellingPriceUpdatedEventHandler SellingPriceUpdated;
        private readonly string _productId;
        
        public UpdateSellingPriceController(string productId)
        {
            _productId = productId;
        }
        
        public void OpenForm()
        {
            decimal originalSellingPrice = GetOriginalSellingPrice();
            var form = new UpdateSellingPriceForm(originalSellingPrice);
            form.UpdateSellingPriceClicked += OnUpdateSellingPriceClicked;
            form.ShowDialog();
        }

        private decimal GetOriginalSellingPrice()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select price as 'Original Price'
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId
                        AND p.id = @productId;", conn);
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            command.Parameters.AddWithValue("@productId", _productId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return dataTable.Rows[0].Field<decimal>("Original Price");
        }

        private void OnUpdateSellingPriceClicked(object sender, decimal newSellingPrice)
        {
            var retailStore = GetRetailStore();
            retailStore.UpdateSellingPrice(_productId, newSellingPrice);
            SellingPriceUpdated?.Invoke(this, EventArgs.Empty);
            SellingPriceUpdated = null;
        }

        private RetailStore GetRetailStore()
        {
            var settings = UserSettings.GetSettings();
            return (RetailStore) settings.Workplace;
        }
    }
}