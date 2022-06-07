using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateSellingPriceForm : Form
    {
        private readonly RetailStoreStock _stock;

        public delegate void UpdateSellingPriceClickedEventHandler(object sender, EventArgs e);
        public event UpdateSellingPriceClickedEventHandler? UpdateSellingPriceClicked;

        public UpdateSellingPriceForm(string productId)
        {
            _stock = StockRepository.GetRetailStoreStocks(UserSettings.GetSettings().Workplace!.Id)
                .First(stock => stock.Product.Id == productId);
            Shown += (_, _) => tbOriginalSellingPrice.Text =
                _stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            InitializeComponent();
        }

        private void btnUpdateSellingPrice_Click(object sender, EventArgs e)
        {
            decimal newSellingPrice = nudNewSellingPrice.Value;
            _stock.SellingPrice = newSellingPrice;
            _stock.Save();

            UpdateSellingPriceClicked?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
