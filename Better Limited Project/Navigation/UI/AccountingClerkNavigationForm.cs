using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class AccountingClerkNavigationForm : Form
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler? ProfileClicked;
        public event ButtonClickedEventHandler? PlaceOrderClicked;
        public event ButtonClickedEventHandler? SalesOrderClicked;
        public event ButtonClickedEventHandler? ProductListClicked;
        public event ButtonClickedEventHandler? SettingsClicked;
        
        public AccountingClerkNavigationForm(string staffName)
        {
            InitializeComponent();
            Shown += (_, _) => btnProfile.Text = staffName;
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnGoodsReceived_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnGoodsReturned_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
