using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateSellingPriceForm : Form
    {
        private readonly RetailStoreStock _stock;

        public UpdateSellingPriceForm(string productId)
        {
            _stock = (RetailStoreStock) UserSettings.GetSettings().Workplace!.GetProductStock(productId);
            Shown += (_, _) => tbOriginalSellingPrice.Text =
                _stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            InitializeComponent();
        }

        private void btnUpdateSellingPrice_Click(object sender, EventArgs e)
        {
            var newSellingPrice = nudNewSellingPrice.Value;
            _stock.SellingPrice = newSellingPrice;
            _stock.Save();
            Close();
        }
    }
}