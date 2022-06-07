using System;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffList;

namespace Better_Limited_Project.CustomerRecord
{
    public partial class CustomerDetailsForm : Form
    {
        public event EventHandler? Updated;
        private Customer _customer;

        public CustomerDetailsForm(Customer customer)
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
            _customer = new CustomerRepository().FindById(_customer.Id);
            FillFields();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (_customer.HasDuePayment() || _customer.HasYetToArriveDelivery())
            {
                MessageBox.Show(removeCustomerFailed);
                return;
            }
            
            var form = new ConfirmRemovalForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Confirmed += (_, _) =>
            {
                new CustomerRepository().Delete(_customer);
                Updated?.Invoke(this, EventArgs.Empty);
                Close();
            };
            form.ShowDialog();
        }
    }
}
