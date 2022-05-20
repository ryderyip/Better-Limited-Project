using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class UpdateProductInfoForm : Form
    {
        private readonly Product _product;
        public delegate void UpdateProductInfoClickedEventHandler(object sender, EventArgs e);
        public event UpdateProductInfoClickedEventHandler? UpdateProductInfoClicked;
      
        public UpdateProductInfoForm(string productId)
        {
            _product =      ProductRepository.GetProduct(productId);

            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            txtProductID.Text = _product.Id;
            txtName.Text = _product.Name;
            
            // TODO deal with this fucking annoying cultureinfo shit
            txtSellingPrice.Text = _product.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            txtOriginalPrice.Text = _product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            txtPhasingOut.Text = _product.IsPhasingOut ? "Yes" : "No";
            // TODO txtReorderLevel.Text = _product.
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            _product.Update();
            UpdateProductInfoClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
