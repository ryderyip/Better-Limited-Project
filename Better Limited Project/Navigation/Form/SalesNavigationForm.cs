using System;

namespace Better_Limited_Project.Navigation.Form
{
    public partial class SalesNavigationForm : System.Windows.Forms.Form
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler ProfileClicked;
        public event ButtonClickedEventHandler PlaceOrderClicked;
        public event ButtonClickedEventHandler SalesOrderClicked;
        public event ButtonClickedEventHandler ProductListClicked;
        public event ButtonClickedEventHandler SettingsClicked;

        public SalesNavigationForm()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileClicked?.Invoke(sender, e);
        }
        
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrderClicked?.Invoke(sender, e);
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            SalesOrderClicked?.Invoke(sender, e);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductListClicked?.Invoke(sender, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsClicked?.Invoke(sender, e);
        }
    }
}