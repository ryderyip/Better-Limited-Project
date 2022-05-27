using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Better_Limited_Project.CustomerRecord
{
    public partial class CustomerListForm : Form
    {
        private List<Customer> _customers;

        public CustomerListForm()
        {
            InitializeComponent();
            _customers = new CustomerRepository().GetAll().ToList();
            Shown += (_, _) => LoadCustomerDgv(_customers);
        }

        private void LoadCustomerDgv(List<Customer> customer)
        {
            dgvCustomer.Rows.Clear();
            customer.ForEach(c => dgvCustomer.Rows.Add(c.Name,
                c.Phone, c.Email));
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            var form = new CreateCustomerRecordForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.CustomerCreated += (_, _) => ReloadCustomerDgv();
            form.ShowDialog();
        }

        private void ReloadCustomerDgv()
        {
            _customers = new CustomerRepository().FindAll(_ => true).ToList();
            tbSearchBox.Text = "";
            LoadCustomerDgv(_customers);
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = tbSearchBox.Text.ToLower();
            var customers = _customers
                .Where(customer => customer.Name.ToLower().Contains(searchKeyword)
                || customer.Phone.Contains(searchKeyword)
                || customer.Email != null && customer.Email.ToLower().Contains(searchKeyword)).ToList();
            LoadCustomerDgv(customers);
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedCustomerPhone = dgvCustomer.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            var selectedCustomer = _customers.Find(customer => customer.Phone == selectedCustomerPhone);
            var form = new CustomerDetailsForm(selectedCustomer);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Updated += (_, _) => ReloadCustomerDgv();
            form.ShowDialog();
        }
    }
}