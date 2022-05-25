using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class UpdateSupplierForm : Form
    {
        private readonly SupplierEntity _supplier;
        public event EventHandler? Updated;
        
        public UpdateSupplierForm(SupplierEntity supplier)
        {
            _supplier = supplier;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbname.Text = _supplier.Supplier.Name;
            tbPhone.Text = _supplier.Supplier.Phone;
            tbEmailAddress.Text = _supplier.Supplier.Email;
            
            tbNewName.Text = _supplier.Supplier.Name;
            tbNewPhone.Text = _supplier.Supplier.Phone;
            tbNewEmail.Text = _supplier.Supplier.Email;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string name = tbNewName.Text;
            string phone = tbNewPhone.Text;
            string email = tbNewEmail.Text;
            
            if (!IsAllFieldsFilled())
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            
            if (!CommonInformationVerifier.IsValidPhoneNumber(phone))
            {
                MessageBox.Show($"Phone number \"{phone}\" is not valid. Please enter a valid one." +
                                $"\nE.g. 12344567");
                return;
            }
            
            if (!CommonInformationVerifier.IsValidEmailAddress(email))
            {
                MessageBox.Show($"Email address \"{email}\" is not valid. Please enter a valid one.");
                return;
            }

            _supplier.Supplier.Name = name;
            _supplier.Supplier.Phone = phone;
            _supplier.Supplier.Email = email;
            SupplierRepository.UpdateSupplier(_supplier);
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private bool IsAllFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(tbNewName.Text)
                   && !string.IsNullOrWhiteSpace(tbNewPhone.Text)
                   && !string.IsNullOrWhiteSpace(tbNewEmail.Text);
        }
    }
}
