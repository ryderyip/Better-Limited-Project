using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    public partial class IsFirstTimeCustomerSelectionForm : Form
    {
        public delegate void ButtonClickedEventHandler(object sender, bool isFirstTimeCustomer);
        public event ButtonClickedEventHandler ButtonClicked;

        public IsFirstTimeCustomerSelectionForm()
        {
            InitializeComponent();
        }

        private void btnFirstTime_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, true);
            Close();
        }

        private void btnOldCustomer_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, false);
            Close();
        }
    }
}
