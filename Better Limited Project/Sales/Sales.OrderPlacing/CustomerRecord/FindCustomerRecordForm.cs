using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord
{
    public partial class FindCustomerRecordForm : Form
    {
        public delegate void CustomerRecordRetrievedEventHandler(object sender, Customer customer);
        public event CustomerRecordRetrievedEventHandler? CustomerRecordRetrieved;
        private readonly DataTable _customerTable;
        
        public FindCustomerRecordForm()
        {
            _customerTable = GetCustomerTable();
            InitializeComponent();
            var helper = new DgvKeywordSearchHelper();
            helper.Activate(_customerTable, dgvCustomerList, txtSearchKeywords, "name");
        }   

        private DataTable GetCustomerTable()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select c.id as id,
                       c.name as name,
                       c.email as email,
                       c.phone as phone,
                       da.address1 as address1,
                       da.address2 as address2
                        from customer c
                        INNER JOIN delivery_address da on c.delivery_address_id = da.id;", conn);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return dataTable;
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count == 0)
                return; // TODO Display warning message if no row selected
            
            var customer = CollectCustomerData();
            CustomerRecordRetrieved?.Invoke(this, customer);
        }

        private Customer CollectCustomerData()
        {
            var selectedRow = dgvCustomerList.SelectedRows[0];
            string name = selectedRow.Cells["name"].Value.ToString();
            string phone = selectedRow.Cells["phone"].Value.ToString();
            string address1 = selectedRow.Cells["address1"].Value.ToString();
            string address2 = selectedRow.Cells["address2"].Value.ToString();
            
            return new Customer(name, phone)
            {
                Id = selectedRow.Cells["id"].Value.ToString(),
                Address = new Address(address1, address2),
                Email = selectedRow.Cells["email"].Value.ToString()
            };
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = _customerTable;
            dgvCustomerList.Columns["id"].Visible = false;
        }
    }
}
