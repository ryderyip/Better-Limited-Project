using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Login;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductListForm : Form
    {
        public delegate void ProductClickedEventHandler(object sender, int rowIndex);
        public delegate void UpdateStockLevelClickedEventHandler(object sender, EventArgs e);
        public event ProductClickedEventHandler ProductClicked;
        public event UpdateStockLevelClickedEventHandler UpdateStockLevelClicked;

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
    }
}