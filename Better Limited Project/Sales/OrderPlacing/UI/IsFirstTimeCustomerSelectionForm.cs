using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class IsFirstTimeCustomerSelectionForm : Form
    {
        public IsFirstTimeCustomerSelectionForm()
        {
            InitializeComponent();
        }

        public event EventHandler<bool>? IsFirstTimeCustomerSelected;

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