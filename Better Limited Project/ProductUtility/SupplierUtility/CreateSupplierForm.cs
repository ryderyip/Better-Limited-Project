using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class CreateSupplierForm : Form
    {
        public event EventHandler? SupplierCreated;
        
        public CreateSupplierForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            if (!HasFilledAllFields())
            {
                MessageBox.Show("Please fill all information.");
                return;
            }

            if (!CommonInformationVerifier.IsValidPhoneNumber(phone))
            {
                MessageBox.Show($"Phone number \"{phone}\" is not valid. " +
                                "Please enter an 8-digit Hong Kong phone number. E.g. 12345687.");
                return;
            }

            if (!CommonInformationVerifier.IsValidEmailAddress(email))
            {
                MessageBox.Show($"\"{email}\" is not a valid email address. Please re-enter.");
                return;
            }

            var supplier = new Supplier(name, phone, email);
            SupplierRepository.InsertOrUpdate(supplier);
            SupplierCreated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private bool HasFilledAllFields()
        {
            return !string.IsNullOrWhiteSpace(tbName.Text)
                   && !string.IsNullOrWhiteSpace(tbPhone.Text)
                   && !string.IsNullOrWhiteSpace(tbEmail.Text);
        }

        private void CreateSupplierForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Close();
            else if (e.KeyChar == (char) Keys.Enter)
                btnCreate.PerformClick();
        }
    }
}
