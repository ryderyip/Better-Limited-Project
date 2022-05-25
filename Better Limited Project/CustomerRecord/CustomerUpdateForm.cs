using System;
using System.Windows.Forms;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.CustomerRecord
{
    public partial class CustomerUpdateForm : Form
    {
        public event EventHandler? Updated;
        private readonly CustomerEntity _customer;

        public CustomerUpdateForm(CustomerEntity customer)
        {
            _customer = customer;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbname.Text = _customer.Customer.Name;
            tbPhone.Text = _customer.Customer.Phone;
            tbEmailAddress.Text = _customer.Customer.Email ?? "-";
            tbAddress1.Text = _customer.Customer.AddressEntity.Address.Address1;
            tbAddress2.Text = _customer.Customer.AddressEntity.Address.Address2;
            
            tbNewName.Text = _customer.Customer.Name;
            tbNewPhone.Text = _customer.Customer.Phone;
            tbNewEmail.Text = _customer.Customer.Email ?? string.Empty;
            tbNewAddress1.Text = _customer.Customer.AddressEntity.Address.Address1;
            tbNewAddress2.Text = _customer.Customer.AddressEntity.Address.Address2;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            bool allInformationValid = VerifyFieldsAndDisplayMessage();
            if (!allInformationValid)
                return;

            _customer.Customer.Name = tbNewName.Text;
            _customer.Customer.Phone = tbNewPhone.Text;
            _customer.Customer.Email = tbNewEmail.Text;
            _customer.Customer.AddressEntity.Address.Address1 = tbNewAddress1.Text;
            _customer.Customer.AddressEntity.Address.Address2 = tbNewAddress2.Text;
            CustomerRepository.Update(_customer);
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private bool VerifyFieldsAndDisplayMessage()
        {
            if (!IsAllFieldsFilledExceptEmail())
            {
                MessageBox.Show("Please enter all required fields");
                return false;
            }
            
            if (!CommonInformationVerifier.IsValidPhoneNumber(tbNewPhone.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter an 8-digit Hong Kong phone number. E.g. 12345678.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(tbNewEmail.Text)
                && !CommonInformationVerifier.IsValidEmailAddress(tbNewEmail.Text))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email address or " +
                                "leave it blank.");
                return false;
            }

            return true;
        }
        
        private bool IsAllFieldsFilledExceptEmail()
        {
            return !string.IsNullOrWhiteSpace(tbNewName.Text)
                   && !string.IsNullOrWhiteSpace(tbNewPhone.Text)
                   && !string.IsNullOrWhiteSpace(tbNewAddress1.Text)
                   && !string.IsNullOrWhiteSpace(tbNewAddress2.Text);
        }

        private void CustomerUpdateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Close();
            else if (e.KeyChar == (char) Keys.Enter)
                btnUpdateInfo.PerformClick();
        }
    }
}
