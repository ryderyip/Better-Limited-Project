using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;
using Better_Limited_Project.StaffUtility.Repository;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class NewProductForm : Form
    {
        public event EventHandler? ProductCreated;
        private const int MaximumDescriptionLength = 1200;
        private readonly List<Category> _categories;
        private readonly List<Supplier> _suppliers;
        private Image? _productImage;

        public NewProductForm()
        {
            _categories = CategoryRepository.GetCategories().ToList();
            _suppliers = SupplierRepository.GetSuppliers().ToList();
            InitializeComponent();
            Shown += InitializeControls;
        }

        private void InitializeControls(object sender, EventArgs e)
        {
            nudPrice.Maximum = Product.MaximumPrice;
            tbDescription.MaxLength = MaximumDescriptionLength;
            _categories.ForEach(category => cbCategory.Items.Add(category.Name));
            _suppliers.ForEach(supplier => cbSupplier.Items.Add(supplier.Name));
            cbCategory.SelectedIndex = 0;
            cbSupplier.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var verifier = new ProductCreationDataVerifier();
            string name = tbName.Text.Trim();
            decimal price = nudPrice.Value;
            string description = tbDescription.Text.Trim();
            var selectedCategory = _categories[cbCategory.SelectedIndex];
            var selectedSupplier = _suppliers[cbSupplier.SelectedIndex];
            bool isPhasingOut = false;

            if (!IsAllFieldsFilled())
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!verifier.IsNameUnique(name))
            {
                MessageBox.Show($"Name \"{name}\" already exists. Please choose another one.");
                return;
            }

            var product = new Product(name, price, description, selectedSupplier, selectedCategory, isPhasingOut);
            product.Save();
            
            if (_productImage != null)
                product.SetImage(_productImage);

            ProductCreated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private bool IsAllFieldsFilled()
        {
            string name = tbName.Text;
            decimal price = nudPrice.Value;
            string description = tbDescription.Text;

            return !string.IsNullOrWhiteSpace(name)
                   && price != decimal.Zero
                   && !string.IsNullOrWhiteSpace(description);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            string browserDescription = "Select a Product Image";
            var path = ImageFileBrowser.Browse(browserDescription);
            if (path == null) return;
            _productImage = Image.FromFile(path);
            tbImagePath.Text = path;
        }
    }
}