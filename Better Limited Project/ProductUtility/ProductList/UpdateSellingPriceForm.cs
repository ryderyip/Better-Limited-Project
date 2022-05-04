using System;
using System.Globalization;
using System.Windows.Forms;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class UpdateSellingPriceForm : Form
    {
        public delegate void UpdateSellingPriceClickedEventHandler(object sender, decimal newSellingPrice);
        public event UpdateSellingPriceClickedEventHandler UpdateSellingPriceClicked;
        
        public UpdateSellingPriceForm(decimal originalSellingPrice)
        {
            InitializeComponent();
            Shown += (_, _) => tbOriginalSellingPrice.Text = 
                originalSellingPrice.ToString("C", new CultureInfo("zh-HK"));
        }

        private void btnUpdateSellingPrice_Click(object sender, EventArgs e)
        {
            UpdateSellingPriceClicked?.Invoke(this, nudNewSellingPrice.Value);
            Close();
        }
    }
}
