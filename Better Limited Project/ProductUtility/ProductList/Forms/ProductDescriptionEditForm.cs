using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductDescriptionEditForm : Form
    {
        private readonly Product _product;
        public event EventHandler? DescriptionUpdated;
        
        public ProductDescriptionEditForm(Product product)
        {
            _product = product;
            InitializeComponent();
            Shown += (_, _) => FillTextBox();
        }

        private void FillTextBox()
        {
            tbDescription.Text = _product.Description;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string newDescription = tbDescription.Text.Trim();
            _product.Description = newDescription;
            _product.Update();
            DescriptionUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
