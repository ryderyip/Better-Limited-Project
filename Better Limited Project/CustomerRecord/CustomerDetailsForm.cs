using System;
using System.Linq;
using System.Windows.Forms;

namespace Better_Limited_Project.CustomerRecord
{
    public partial class CustomerDetailsForm : Form
    {
        public event EventHandler? Updated;
        private CustomerEntity _customer;

        public CustomerDetailsForm(CustomerEntity customer)
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
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            var form = new CustomerUpdateForm(_customer);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Updated += (_, _) => RefreshAllFields();
            form.ShowDialog();
            Updated?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshAllFields()
        {
            _customer = CustomerRepository.GetCustomers().First(customer => customer.Id == _customer.Id);
            FillFields();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            CustomerRepository.RemoveCustomer(_customer.Id);
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
