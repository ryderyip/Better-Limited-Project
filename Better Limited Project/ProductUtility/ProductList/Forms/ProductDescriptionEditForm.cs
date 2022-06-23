using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductDescriptionEditForm : Form
    {
        private readonly Product _product;

        public ProductDescriptionEditForm(Product product)
        {
            _product = product;
            InitializeComponent();
            Shown += (_, _) => FillTextBox();
        }

        public event EventHandler? DescriptionUpdated;

        private void FillTextBox()
        {
            tbDescription.Text = _product.Description;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _product.Description = tbDescription.Text.Trim();
            _product.Save();
            DescriptionUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}