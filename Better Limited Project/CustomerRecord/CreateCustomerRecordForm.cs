using System;
using System.Windows.Forms;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.CustomerRecord
{
    public partial class CreateCustomerRecordForm : Form
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
            
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;
            var address = new Address
            {
                Address1 = address1, Address2 = address2
            };
            address.Save();
            
            var customer = GetCustomer(address);
            customer.Save();

            CustomerCreated?.Invoke(this, customer);
            Close();
        }

        private bool ValidateInputsAndDisplayMessageIfInvalid()
        {
            if (HasAnyUnfilledRequiredFields())
            {
                MessageBox.Show("Please enter all required fields");
                return false;
            }
            
            if (!CommonInformationVerifier.IsValidPhoneNumber(txtCustPhoneNumber.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter an 8-digit Hong Kong phone number. E.g. 12345678.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAddress.Text)
                && !CommonInformationVerifier.IsValidEmailAddress(txtEmailAddress.Text))
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
                   || string.IsNullOrWhiteSpace(txtAddress2.Text)
                   || string.IsNullOrWhiteSpace(txtCustPhoneNumber.Text);
        }

        private Customer GetCustomer(Address address)
        {
            string name = txtCustName.Text;
            string phone = txtCustPhoneNumber.Text;
            string email = txtEmailAddress.Text.ToLower();

            return string.IsNullOrWhiteSpace(email)
                ? new Customer
                {
                    Name = name, Phone = phone, Address = address
                }
                : new Customer
                {
                    Name = name, Phone = phone, Address = address, Email = email
                };
        }
    }
}