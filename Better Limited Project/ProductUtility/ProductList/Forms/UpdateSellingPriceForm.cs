using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class UpdateSellingPriceForm : Form
    {
        private readonly string _productId;

        public delegate void UpdateSellingPriceClickedEventHandler(object sender, EventArgs e);
        public event UpdateSellingPriceClickedEventHandler? UpdateSellingPriceClicked;
        
        public UpdateSellingPriceForm(string productId)
        {
            _productId = productId;
            decimal originalSellingPrice = GetOriginalSellingPrice(productId);

            InitializeComponent();
            Shown += (_, _) => tbOriginalSellingPrice.Text = 
                originalSellingPrice.ToString("C", new CultureInfo("zh-HK"));
        }
        
        private decimal GetOriginalSellingPrice(string productId)
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            var command = new MySqlCommand(
                @"select selling_price
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId
                        AND p.id = @productId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            command.Parameters.AddWithValue("@productId", productId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable.Rows[0].Field<decimal>("selling_price");
        }

        private void btnUpdateSellingPrice_Click(object sender, EventArgs e)
        {
            var retailStore = GetRetailStore();
            retailStore.UpdateSellingPrice(_productId, nudNewSellingPrice.Value);
            UpdateSellingPriceClicked?.Invoke(this, EventArgs.Empty);
            Close();
        }
        
        private RetailStore GetRetailStore()
        {
            var settings = UserSettings.GetSettings();
            return (RetailStore) settings.Workplace;
        }
    }
}
