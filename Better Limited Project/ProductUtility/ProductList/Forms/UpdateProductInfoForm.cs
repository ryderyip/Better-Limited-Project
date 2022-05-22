using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateProductInfoForm : Form
    {
        private readonly IStock _stock;
        public delegate void UpdateProductInfoClickedEventHandler(object sender, EventArgs e);
        public event UpdateProductInfoClickedEventHandler? UpdateProductInfoClicked;
      
        public UpdateProductInfoForm(string productId, string workplaceId)
        {
            _stock = StockRepository.GetStocks(workplaceId).FirstOrDefault(stock => stock.Product.Id == productId)
                     ?? throw new ArgumentNullException($"Product id \'{productId}\' does not exist.");
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            var product = _stock.Product;
            txtProductID.Text = product.Id;
            txtName.Text = product.Name;
            
            // TODO deal with this fucking annoying cultureinfo shit
            if (_stock is RetailStoreStock stock)
                txtSellingPrice.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            else
                HideSellingPrice();

            txtOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            txtPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            // TODO txtReorderLevel.Text = _product.
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            _stock.Product.Update();
            UpdateProductInfoClicked?.Invoke(this, EventArgs.Empty);
        }
        
        private void HideSellingPrice()
        {
            txtSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
        }
    }
}
