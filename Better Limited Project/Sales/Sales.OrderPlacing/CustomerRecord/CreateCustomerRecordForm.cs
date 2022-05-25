using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord.CustomerInformationValidation;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord
{
    public partial class CreateCustomerRecordForm : Form
    {
        private readonly FormController _formController;
        private readonly Cart _cart;

        public CreateCustomerRecordForm(FormController formController, Cart cart)
        {
            _formController = formController;
            _cart = cart;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool isValidInputs = ValidateInputsAndDisplayMessageIfInvalid();
            if (!isValidInputs)
                return;

            var customer = CollectInputs();
            var customerEntity = CustomerRepository.CreateAndRetrieve(customer);

            var form = new ConfirmPlacingOrderForm(_cart, customerEntity);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private bool ValidateInputsAndDisplayMessageIfInvalid()
        {
            if (HasAnyUnfilledRequiredFields())
            {
                MessageBox.Show("Please enter all required fields");
                return false;
            }
            
            if (!CustomerInformationValidator.IsValidPhoneNumber(txtCustPhoneNumber.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter an 8-digit Hong Kong phone number. E.g. 12345678.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAddress.Text)
                && !CustomerInformationValidator.IsValidEmailAddress(txtEmailAddress.Text))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email address or " +
                                "leave it blank.");
                return false;
            }

            return true;
        }

        private bool HasAnyUnfilledRequiredFields()
        {
            return string.IsNullOrWhiteSpace(txtCustName.Text)
                   || string.IsNullOrWhiteSpace(txtAddress1.Text)
                   || string.IsNullOrWhiteSpace(txtAddress2.Text);
        }

        private Customer CollectInputs()
        {
            string name = txtCustName.Text;
            string phone = txtCustPhoneNumber.Text;
            string email = txtEmailAddress.Text;
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;

            var address = new Address(address1, address2);
            return string.IsNullOrWhiteSpace(email)
                ? new Customer(name, phone, address)
                : new Customer(name, phone, address, email);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _formController.Close();
            var controller = new PlaceOrderController(_cart);
            controller.OpenForm();
        }
    }
}