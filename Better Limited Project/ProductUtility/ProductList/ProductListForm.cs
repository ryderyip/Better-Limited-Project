using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class ProductListForm : Form
    {
        public delegate void ProductClickedEventHandler<T>(object sender, T t);
        
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {

            dgvProductList.DataSource = ProductRepository.GetProducts();
               
            
        }
    }
}
