using System;
using System.Windows.Forms;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.SupplierUtility
{
    public partial class UpdateSupplierForm : Form
    {
        private readonly Supplier _supplier;
        public event EventHandler? Updated;
        
        public UpdateSupplierForm(Supplier supplier)
        {
            _supplier = supplier;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbname.Text = _supplier.Name;
            tbPhone.Text = _supplier.Phone;
            tbEmailAddress.Text = _supplier.Email;
            tbNewName.Text = _supplier.Name;
            tbNewPhone.Text = _supplier.Phone;
            tbNewEmail.Text = _supplier.Email;
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

            _supplier.Name = name;
            _supplier.Phone = phone;
            _supplier.Email = email;
            _supplier.Save();
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
