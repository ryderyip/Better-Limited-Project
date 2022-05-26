using System;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class IsFirstTimeCustomerSelectionForm : Form
    {
        private readonly FormController _formController;
        private readonly Cart _cart;

        public IsFirstTimeCustomerSelectionForm(FormController formController, Cart cart)
        {
            _formController = formController;
            _cart = cart;
            InitializeComponent();
        }

        private void btnFirstTime_Click(object sender, EventArgs e)
        {
            var form = new CreateCustomerRecordForm();
            // form.CustomerCreated
            _formController.OpenFullForm(form);
            Close();
        }

        private void btnOldCustomer_Click(object sender, EventArgs e)
        {
            var form = new FindCustomerRecordForm(_formController, _cart);
            _formController.OpenFullForm(form);
            Close();
            _formController.ContentForm?.Close();
        }

        private void IsFirstTimeCustomerSelectionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Close();
        }
    }
}
