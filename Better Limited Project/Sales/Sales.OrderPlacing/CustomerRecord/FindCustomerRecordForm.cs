using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord
{
    public partial class FindCustomerRecordForm : Form
    {
        private readonly FormController _formController;
        private readonly Cart _cart;
        private readonly List<CustomerEntity> _customers;

        public FindCustomerRecordForm(FormController formController, Cart cart)
        {
            _formController = formController;
            _cart = cart;
            _customers = CustomerRepository.GetCustomers().ToList();
            InitializeComponent();
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
                return; // TODO Display warning message if no row selected

            var customer = GetSelectedCustomer();


            var form = new ConfirmPlacingOrderForm(_cart, customer);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private CustomerEntity GetSelectedCustomer()
        {
            string selectedCustomerPhone = dgvCustomer.SelectedRows[0].Cells["phone"].Value.ToString();
            return _customers.Find(customer => customer.Customer.Phone == selectedCustomerPhone);
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            _customers.ConvertAll(entity => entity.Customer)
                .ForEach(customer => dgvCustomer.Rows.Add(customer.Name,
                customer.Phone, customer.Email, customer.Address.Address1, customer.Address.Address2));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _formController.Close();
            var controller = new PlaceOrderController(_cart);
            controller.OpenForm();
        }
    }
}