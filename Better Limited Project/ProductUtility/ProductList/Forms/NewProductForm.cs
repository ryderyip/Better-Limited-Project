using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class NewProductForm : Form
    {
        private const int MaximumDescriptionLength = 1200;
        private readonly List<Category> _categories;
        private readonly List<SupplierEntity> _suppliers;

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
            _suppliers.ForEach(supplier => cbSupplier.Items.Add(supplier.Supplier.Name));
            cbCategory.SelectedIndex = 0;
            cbSupplier.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var verifier = new ProductCreationDataVerifier();
            string id = tbId.Text;
            string name = tbName.Text;
            decimal price = nudPrice.Value;
            string description = tbDescription.Text;
            string selectedCategoryId = _categories[cbCategory.SelectedIndex].Id;
            string selectedSupplierId = _suppliers[cbSupplier.SelectedIndex].Id;
            bool isPhasingOut = false;

            if (!IsAllFieldsFilled())
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!verifier.IsIdValid(id))
            {
                MessageBox.Show($"Id \"{id}\" is not valid. Id must contain at least 4 English characters or numbers.");
                return;
            }

            if (!verifier.IsIdUnique(id))
            {
                MessageBox.Show($"Id \"{id}\" already exists. Please choose another one.");
                return;
            }

            if (!verifier.IsNameValid(name))
            {
                MessageBox.Show(
                    $"Name \"{name}\" is not valid. Id must contain at least 4 English characters or numbers.");
                return;
            }

            if (!verifier.IsNameUnique(name))
            {
                MessageBox.Show($"Name \"{name}\" already exists. Please choose another one.");
                return;
            }

            ProductRepository.CreateNewProduct(id, name, price, description, isPhasingOut,
                selectedCategoryId, selectedSupplierId);
            
            Close();
        }

        private bool IsAllFieldsFilled()
        {
            string id = tbId.Text;
            string name = tbName.Text;
            decimal price = nudPrice.Value;
            string description = tbDescription.Text;

            return id.Length != 0
                   && name.Length != 0
                   && price != decimal.Zero
                   && description.Length != 0;
        }
    }
}