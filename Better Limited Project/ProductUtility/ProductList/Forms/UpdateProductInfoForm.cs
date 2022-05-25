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
        private readonly string _workplaceId;
        private readonly IStock _stock;
        public delegate void UpdateProductInfoClickedEventHandler(object sender, EventArgs e);
        public event UpdateProductInfoClickedEventHandler? UpdateProductInfoClicked;

        public UpdateProductInfoForm(string productId, string workplaceId)
        {
            _workplaceId = workplaceId;
            _stock = StockRepository.GetStocks(workplaceId).FirstOrDefault(stock => stock.Product.Id == productId)
                     ?? throw new ArgumentNullException($"Product id \'{productId}\' does not exist.");
            InitializeComponent();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            nudNewSellingPirce.Maximum = Product.MaximumPrice;
            nudNewSellingPirce.DecimalPlaces = 2;
            nudNewSellingPirce.ThousandsSeparator = true;

            nudNewReorderLevel.Maximum = Product.MaximumReorderLevel;
            nudNewReorderLevel.DecimalPlaces = 0;
            nudNewReorderLevel.Increment = 1;
            FillFields();
        }

        private void FillFields()
        {
            var product = _stock.Product;
            txtProductID.Text = product.Id;
            txtName.Text = product.Name;

            // TODO deal with this fucking annoying cultureinfo shit
            if (_stock is RetailStoreStock stock)
            {
                txtSellingPrice.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                nudNewSellingPirce.Value = stock.SellingPrice;
            }
            else
                HideSellingPrice();

            txtOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            txtPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            txtReorderLevel.Text = _stock.RestockLevel.ToString();
            nudNewReorderLevel.Value = _stock.RestockLevel;
            if (product.IsPhasingOut)
                radioBtnPhasing_Out_On.Checked = true;
            else
                radioBtnPhasing_Out_Off.Checked = true;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            decimal newSellingPrice = nudNewSellingPirce.Value;
            int newReorderLevel = (int)nudNewReorderLevel.Value;
            bool phasingOut = radioBtnPhasing_Out_On.Checked;

            if (_stock is RetailStoreStock retailStoreStock)
                retailStoreStock.SellingPrice = newSellingPrice;
            _stock.RestockLevel = newReorderLevel;
            _stock.Product.IsPhasingOut = phasingOut;
            _stock.Update();
            UpdateProductInfoClicked?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void HideSellingPrice()
        {
            txtSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
            lblNewSpellingPrice.Visible = false;
            nudNewSellingPirce.Visible = false;
        }
    }
}
