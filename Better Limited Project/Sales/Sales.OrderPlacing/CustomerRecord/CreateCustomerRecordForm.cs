using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord.CustomerInformationValidation;
using MySql.Data.MySqlClient;

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
            bool isValidInputs = ValidateInputsAndDisplayMessageIfInvalid();
            if (!isValidInputs)
                return;

            var customer = CollectInputs();
            CreateDatabaseRecords(customer);
            CustomerRecordCreated?.Invoke(this, customer);
        }

        private bool ValidateInputsAndDisplayMessageIfInvalid()
        {
            if (!CustomerInformationValidator.IsValidPhoneNumber(txtCustPhoneNumber.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter a 8-digit Hong Kong phone number." +
                                "\n852-12345678 or 12345678");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAddress.Text))
                if (!CustomerInformationValidator.IsValidEmailAddress(txtEmailAddress.Text))
                {
                    MessageBox.Show("Invalid email address. Please enter a valid email address or " +
                                    "leave it blank.");
                    return false;
                }
                

            if (HasAnyUnfilledRequiredFields())
            {
                MessageBox.Show("Please enter all required fields");
                return false;
            }

            return true;
        }

        private bool HasAnyUnfilledRequiredFields()
        {
            return string.IsNullOrWhiteSpace(txtCustName.Text)
                   || string.IsNullOrWhiteSpace(txtAddress1.Text)
                   || string.IsNullOrWhiteSpace(txtAddress2.Text);
        }

        private Customer CollectInputs()
        {
            string name = txtCustName.Text;
            string phone = txtCustPhoneNumber.Text;
            string? email = txtEmailAddress.Text;
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;

            var customer = new Customer(name, phone);
            customer.Email = string.IsNullOrWhiteSpace(email) ? null : email;
            var address = new Address(address1, address2);
            customer.Address = address;

            return customer;
        }

        private void CreateDatabaseRecords(Customer customer)
        {
            CreateAddressRecord(customer.Address);
            string deliveryAddressId = GetAddressRecordId();
            CreateCustomerRecord(customer, deliveryAddressId);
        }

        private string GetAddressRecordId()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();

            var command1 = new MySqlCommand(
                @"SELECT max(id) as id FROM delivery_address;", conn);
            var dataReader = command1.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return dataTable.Rows[0].Field<int>("id").ToString();
        }

        private void CreateAddressRecord(Address? customerAddress)
        {
            if (customerAddress == null)
                throw new InvalidOperationException("Address cannot be null");

            using var conn = Database.GetConnection();
            conn.Open();
            var command = new MySqlCommand(
                @"insert into delivery_address (address1, address2)
                        value (@address1, @address2);", conn);
            command.Parameters.AddWithValue("@address1", customerAddress.Address1);
            command.Parameters.AddWithValue("@address2", customerAddress.Address2);
            command.ExecuteNonQuery();
        }

        private void CreateCustomerRecord(Customer customer, string deliveryAddressId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var command2 = new MySqlCommand(
                @"insert into customer (name, delivery_address_id, phone, email)
                        value (@name, @delivery_address_id, @phone, @email);", conn);
            command2.Parameters.AddWithValue("@name", customer.Name);
            command2.Parameters.AddWithValue("@delivery_address_id", deliveryAddressId);
            command2.Parameters.AddWithValue("@phone", customer.Phone);
            command2.Parameters.AddWithValue("@email",
                customer.Email == null ? DBNull.Value : customer.Email);
            command2.ExecuteNonQuery();
        }
    }
}