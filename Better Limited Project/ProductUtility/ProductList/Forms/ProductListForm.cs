using System;
using System.Windows.Forms;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductListForm : Form
    {
        public delegate void ProductClickedEventHandler(object sender, int rowIndex);
        public event ProductClickedEventHandler ProductClicked;
        public event EventHandler UpdateStockLevelClicked;
        public event EventHandler NewProductClicked;

        public ProductListForm()
        {
            InitializeComponent();
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductClicked?.Invoke(this, e.RowIndex);
        }

        private void btnUpdateStockLevel_Click(object sender, EventArgs e)
        {
            UpdateStockLevelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var form = new NewProductForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void ProductListForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("/"))
                txtSearchKeywords.Focus();
        }
    }
}