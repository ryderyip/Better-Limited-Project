using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Payment;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public class PlaceOrderController
    {
        private PlaceOrderForm _form;
        private Pager<ProductQuantity> _pager;
        private const int PageSize = 6;
        private readonly FormController _formController;

        public PlaceOrderController()
        {
            _pager = new Pager<ProductQuantity>(PageSize);
            _form = new PlaceOrderForm(_pager);
            _formController = new FormController(CreateBlankForm());
            Initialize();
        }

        private Form CreateBlankForm()
        {
            var form = new Form();
            form.Size = new Size(1280, 720);
            return form;
        }

        private void Initialize()
        {
            _pager = new Pager<ProductQuantity>(PageSize);
            _form = new PlaceOrderForm(_pager);
            _form.btnNext.Click += OnNextClicked;
            _form.Shown += SetCartDgvSchemaOnShown;
            PopulatePagerWithProductData();
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            if (_form.dgvCart.Rows.Count == 0)
                return; // TODO prompt a non intruding message
            
            var paymentCreator = new PaymentCreator(_formController);
            paymentCreator.PaymentCompleted += OnPaymentCompleted;
            paymentCreator.CreatePayment();
        }

        private void OnPaymentCompleted(object sender, PaymentStatus status)
        {
            if (status == PaymentStatus.Successful)
            {
                _form.Closed += (_, _) =>
                {
                    Initialize();
                    OpenForm();
                };
                _form.Close();
            }
            else
            {
                Initialize();
                OpenForm();
            }
        }

        private void PopulatePagerWithProductData()
        {
            var productTable = GetProductTable();
            foreach (DataRow productRow in productTable.Rows)
            {
                var quantity = productRow.Field<int>("quantity");
                var product = new Product
                {
                    Id = productRow.Field<string>("id"),
                    Name = productRow.Field<string>("name"),
                    SellingPrice = productRow.Field<decimal>("price"),
                    Category = productRow.Field<string>("category")
                };
                _pager.AddItem(new ProductQuantity(product, quantity));
            }
        }
        
        private DataTable GetProductTable()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select p.id as id,
                       p.name as name, 
                       rss.quantity as quantity, 
                       rss.selling_price as price, 
                       pc.name as category
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;", conn);
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return dataTable;
        }

        public void OpenForm()
        {
            _formController.OpenFullForm(_form);
        }

        private void SetCartDgvSchemaOnShown(object sender, EventArgs e)
        {
            _form.dgvCart.Columns.Add("name", "Name");
            _form.dgvCart.Columns.Add("price", "Price");
            _form.dgvCart.Columns.Add("quantity", "Qty");
            _form.dgvCart.Columns.Add("category", "Category");
        }
    }
}