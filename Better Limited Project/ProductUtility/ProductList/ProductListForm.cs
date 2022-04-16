using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            productBindingSource.Add(new Product()
            {
                ProductID = "S00001",
                ProductName = "Item X.1",
                Price = "Item X.2",
                SellingPrice = "Item X.3",
                Description = "Item X.4",
                Supplier = "Item X.5"
            });

            productBindingSource.Add(new Product()
            {
                ProductID = "S00002",
                ProductName = "Item X.1",
                Price = "Item X.2",
                SellingPrice = "Item X.3",
                Description = "Item X.4",
                Supplier = "Item X.5"
            });

        }

        
    }
}
