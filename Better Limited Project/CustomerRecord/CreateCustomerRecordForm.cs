using System;
using System.Windows.Forms;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.CustomerRecord
{
    partial class CreateCustomerRecordForm : Form
    {
        public event EventHandler<Customer>? CustomerCreated;

        public CreateCustomerRecordForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool isValidInputs = ValidateInputsAndDisplayMessageIfInvalid();
            if (!isValidInputs)
                return;

            var customer = GetCustomer();
            customer.Save();

            CustomerCreated?.Invoke(this, customer);
            Close();
        }

        private bool ValidateInputsAndDisplayMessageIfInvalid()
        {
            if (HasAnyUnfilledRequiredFields())
            {
                MessageBox.Show(hasUnfilledRequiredFieldsMessage);
                return false;
            }

            if (!CommonInformationVerifier.IsValidPhoneNumber(txtCustPhoneNumber.Text))
            {
                MessageBox.Show(invalidPhoneNumberMessage);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAddress.Text)
                && !CommonInformationVerifier.IsValidEmailAddress(txtEmailAddress.Text))
            {
                MessageBox.Show(invalidEmailMessage);
                return false;
            }

            return true;
        }

        private bool HasAnyUnfilledRequiredFields()
        {
            return string.IsNullOrWhiteSpace(txtCustName.Text)
                   || string.IsNullOrWhiteSpace(txtAddress1.Text)
                   || string.IsNullOrWhiteSpace(txtAddress2.Text)
                   || string.IsNullOrWhiteSpace(txtCustPhoneNumber.Text);
        }

        private Customer GetCustomer()
        {
            string address1 = txtAddress1.Text.Trim();
            string address2 = txtAddress2.Text.Trim();
            var address = new Address(address1, address2);

            string name = txtCustName.Text.Trim();
            string phone = txtCustPhoneNumber.Text.Trim();
            string? email = string.IsNullOrWhiteSpace(txtEmailAddress.Text) ?
                null : txtEmailAddress.Text.ToLower().Trim();

            return new Customer(name, phone, address, email);
        }
    }
}