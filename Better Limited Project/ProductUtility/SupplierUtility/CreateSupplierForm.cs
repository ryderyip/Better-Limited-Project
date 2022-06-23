using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class CreateSupplierForm : Form
    {
        public CreateSupplierForm()
        {
            InitializeComponent();
        }

        public event EventHandler? SupplierCreated;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            if (!HasFilledAllFields())
            {
                MessageBox.Show(SupplierResource.notAllFieldsFilled);
                return;
            }

            if (!CommonInformationVerifier.IsValidPhoneNumber(phone))
            {
                MessageBox.Show(string.Format(SupplierResource.phone_number_invalid, phone));
                return;
            }

            if (!CommonInformationVerifier.IsValidEmailAddress(email))
            {
                MessageBox.Show(string.Format(SupplierResource.email_invalid, email));
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