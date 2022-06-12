using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateProductAdminForm : Form, IUpdateProductForm
    {
        private readonly List<Category> _categories;
        private readonly List<Supplier> _suppliers;
        private readonly IStock _stock;
        public event EventHandler? ProductUpdated;
        
        public UpdateProductAdminForm(IStock stock)
        {
            _suppliers = SupplierRepository.GetSuppliers().ToList();
            _categories = CategoryRepository.GetAll().ToList();
            _stock = stock;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        public void ShowForm()
        {
            ShowDialog();
        }
        
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            var verifier = new ProductCreationDataVerifier();
            string name = tbNewName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(ProductList.updateProductNameNotFilled);
                return;
            }

            if (!verifier.IsNameUnique(name) && name != _stock.Product.Name)
            {
                MessageBox.Show(string.Format(ProductList.updateProductNameNotUnique, name));
                return;
            }
            
            decimal newSellingPrice = nudNewSellingPirce.Value;
            decimal newOriginalPrice = nudNewOriginalPrice.Value;
            int newReorderLevel = (int) nudNewReorderLevel.Value;
            int newStockLevel = (int) nudNewStockLevel.Value;
            bool phasingOut = rbPhasingOutOn.Checked;

            if (_stock is RetailStoreStock retailStoreStock)
                retailStoreStock.SellingPrice = newSellingPrice;
            _stock.Product.OriginalPrice = newOriginalPrice;
            _stock.Product.Name = name;
            _stock.RestockLevel = newReorderLevel;
            _stock.Product.IsPhasingOut = phasingOut;
            _stock.Quantity = newStockLevel;
            _stock.Product.Category = _categories.Find(c => c.Name == cbCategory.SelectedItem.ToString());
            _stock.Product.Supplier = _suppliers.Find(s => s.Name == cbSupplier.SelectedItem.ToString());
            
            _stock.Save();
            _stock.Product.Save();

            ProductUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void UpdateProductAdminForm_Shown(object sender, EventArgs e)
        {
            nudNewSellingPirce.Maximum = Product.MaximumPrice;
            nudNewSellingPirce.DecimalPlaces = 2;
            nudNewSellingPirce.ThousandsSeparator = true;

            nudNewOriginalPrice.Maximum = Product.MaximumPrice;
            nudNewOriginalPrice.DecimalPlaces = 2;
            nudNewOriginalPrice.ThousandsSeparator = true;
            
            nudNewReorderLevel.Maximum = Product.MaximumReorderLevel;
            nudNewReorderLevel.DecimalPlaces = 0;
            nudNewReorderLevel.Increment = 1;
            
            nudNewStockLevel.Maximum = Product.MaximumReorderLevel;
            nudNewStockLevel.DecimalPlaces = 0;
            nudNewStockLevel.Increment = 1;
            
            _suppliers.ForEach(s => cbSupplier.Items.Add(s.Name));
            _categories.ForEach(c => cbCategory.Items.Add(c.Name));

            FillFields();
        }
        
        private void FillFields()
        {
            nudNewStockLevel.Value = _stock.Quantity;
            tbStockLevel.Text = _stock.Quantity.ToString();
            var product = _stock.Product;
            txtName.Text = product.Name;
            tbNewName.Text = product.Name;

            if (_stock is RetailStoreStock stock)
            {
                txtSellingPrice.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                nudNewSellingPirce.Value = stock.SellingPrice;
            }
            else
                HideSellingPrice();

            nudNewOriginalPrice.Value = product.OriginalPrice;
            txtOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            txtPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            txtReorderLevel.Text = _stock.RestockLevel.ToString();
            nudNewReorderLevel.Value = _stock.RestockLevel;
            if (product.IsPhasingOut)
                rbPhasingOutOn.Checked = true;
            else
                rbPhasingOutOff.Checked = true;
            tbCategory.Text = _stock.Product.Category.Name;
            tbSupplier.Text = _stock.Product.Supplier.Name;
            cbSupplier.SelectedIndex = _suppliers.FindIndex(s => s.Id == _stock.Product.Supplier.Id);
            cbCategory.SelectedIndex = _categories.FindIndex(c => c.Id == _stock.Product.Category.Id);
        }
        
        private void HideSellingPrice()
        {
            txtSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
            lblNewSellingPrice.Visible = false;
            nudNewSellingPirce.Visible = false;
        }
    }
}
