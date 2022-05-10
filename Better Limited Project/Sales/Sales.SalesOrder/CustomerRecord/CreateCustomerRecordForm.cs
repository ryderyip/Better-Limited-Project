using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord
{
    public partial class CreateCustomerRecordForm : Form
    {
        public delegate void CustomerRecordCreatedEventHandler(object sender, Customer customer);
        public event CustomerRecordCreatedEventHandler CustomerRecordCreated;
        
        public CreateCustomerRecordForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = txtCustName.Text;
            string phone = txtCustPhoneNumber.Text;
            string? email = txtEmailAddress.Text;
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;
            string city = txtCity.Text;

            var customer = new Customer(name, phone);
            customer.Email = string.IsNullOrWhiteSpace(email) ? null : email;
            var address = new Address(city, address1, address2);
            customer.Address = address;
            
            CustomerRecordCreated?.Invoke(this, customer);
        }
    }
}
