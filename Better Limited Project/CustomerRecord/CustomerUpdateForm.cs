using System;
using System.Windows.Forms;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.CustomerRecord
{
    public partial class CustomerUpdateForm : Form
    {
        public event EventHandler? Updated;
        private readonly Customer _customer;

        public CustomerUpdateForm(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbname.Text = _customer.Name;
            tbPhone.Text = _customer.Phone;
            tbEmailAddress.Text = _customer.Email ?? "-";
            tbAddress1.Text = _customer.Address.Address1;
            tbAddress2.Text = _customer.Address.Address2;
            
            tbNewName.Text = _customer.Name;
            tbNewPhone.Text = _customer.Phone;
            tbNewEmail.Text = _customer.Email ?? string.Empty;
            tbNewAddress1.Text = _customer.Address.Address1;
            tbNewAddress2.Text = _customer.Address.Address2;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            bool allInformationValid = VerifyFieldsAndDisplayMessage();
            if (!allInformationValid)
                return;

            _customer.Name = tbNewName.Text.Trim();
            _customer.Phone = tbNewPhone.Text.Trim();
            _customer.Email = tbNewEmail.Text.ToLower().Trim();
            _customer.Address.Address1 = tbNewAddress1.Text.Trim();
            _customer.Address.Address2 = tbNewAddress2.Text.Trim();
            _customer.Save();
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private bool VerifyFieldsAndDisplayMessage()
        {
            if (!IsAllFieldsFilledExceptEmail())
            {
                MessageBox.Show(hasUnfilledRequiredFields);
                return false;
            }
            
            if (!CommonInformationVerifier.IsValidPhoneNumber(tbNewPhone.Text))
            {
                MessageBox.Show(invalidPhoneNumberMessage);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(tbNewEmail.Text)
                && !CommonInformationVerifier.IsValidEmailAddress(tbNewEmail.Text))
            {
                MessageBox.Show(invalidEmailAddressMessage);
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
    }
}
