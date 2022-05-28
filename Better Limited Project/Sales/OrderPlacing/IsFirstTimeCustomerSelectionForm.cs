using System;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class IsFirstTimeCustomerSelectionForm : Form
    {
        public event EventHandler<bool>? IsFirstTimeCustomerSelected;
        
        public IsFirstTimeCustomerSelectionForm()
        {
            InitializeComponent();
        }

        private void btnFirstTime_Click(object sender, EventArgs e)
        {
            IsFirstTimeCustomerSelected?.Invoke(this, true);
            Close();
        }

        private void btnOldCustomer_Click(object sender, EventArgs e)
        {
            IsFirstTimeCustomerSelected?.Invoke(this, false);
            Close();
        }

        private void IsFirstTimeCustomerSelectionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Close();
        }
    }
}
