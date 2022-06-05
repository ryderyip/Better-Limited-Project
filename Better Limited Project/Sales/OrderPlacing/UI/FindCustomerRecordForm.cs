using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class FindCustomerRecordForm : Form
    {
        public event EventHandler<Customer>? CustomerRecordFound;
        private readonly List<Customer> _customers;

        public FindCustomerRecordForm()
        {
            _customers = new CustomerRepository().GetAll().ToList();
            InitializeComponent();
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
                return; // TODO Display warning message if no row selected

            CustomerRecordFound?.Invoke(this, GetSelectedCustomer());
            Close();
        }

        private Customer GetSelectedCustomer()
        {
            string selectedCustomerPhone = dgvCustomer.SelectedRows[0].Cells["phone"].Value.ToString();
            return _customers.Find(customer => customer.Phone == selectedCustomerPhone);
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            _customers.ForEach(customer => dgvCustomer.Rows.Add(customer.Name,
                customer.Phone, customer.Email, customer.Address.Address1,
                customer.Address.Address2));
        }
    }
}