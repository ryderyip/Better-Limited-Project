using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Payment;
using Better_Limited_Project.Sales.Sales.Payment;
using Better_Limited_Project.Sales.Sales.SalesOrder;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public class PlaceOrderController
    {
        private PlaceOrderForm _form;
        private Pager<ProductQuantity> _pager;
        private const int PageSize = 6;
        private readonly FormController _formController;
        private string _customerName;
        private DeliverySession? _deliverySession;
        private PaymentMethod? _paymentMethod;
        private IEnumerable<ProductQuantity>? _productQuantities; 

        public PlaceOrderController()
        {
            _pager = new Pager<ProductQuantity>(PageSize);
            _form = new PlaceOrderForm(_pager);
            _formController = new FormController(OuterFormGenerator.Generate());
            Initialize();
        }

        private void Initialize()
        {
            _pager = new Pager<ProductQuantity>(PageSize);
            _form = new PlaceOrderForm(_pager);
            _form.Shown += SetCartDgvSchemaOnShown;
            _form.btnNext.Click += OnPlaceOrderFormNextClicked;
            PopulatePagerWithProductData();
        }

        private void SetCartDgvSchemaOnShown(object sender, EventArgs e)
        {
            _form.dgvCart.Columns.Add("name", "Name");
            _form.dgvCart.Columns.Add("price", "Price");
            _form.dgvCart.Columns.Add("quantity", "Qty");
            _form.dgvCart.Columns.Add("category", "Category");
        }

        private void OnPlaceOrderFormNextClicked(object sender, EventArgs e)
        {
            if (_form.dgvCart.Rows.Count == 0)
                return; // TODO prompt a non intruding message

            _productQuantities = GetProductsInCart();
            
            if (IsNeedDelivery() || IsNeedInstallation())
            {
                var procedure = new RetrieveCustomerRecordProcedure(_formController);
                procedure.CustomerRecordRetrieved += OnCustomerRecordRetrieved;
                procedure.Cancelled += (_, _) => ReinitializePlaceOrderForm();
                procedure.Start();
            }

            else
                StartPaymentProcedure();
        }

        private void OnCustomerRecordRetrieved(object sender, string customerName)
        {
            _customerName = customerName;
            var form = new DeliverySessionSelectionForm();
            form.NextClicked += DeliverySessionSelected;
            form.ShowDialog();
        }

        private void DeliverySessionSelected(object sender, DeliverySession deliverySession)
        {
            _deliverySession = deliverySession;
            StartPaymentProcedure();
        }

        private void StartPaymentProcedure()
        {
            var form = new PaymentMethodSelectionForm();
            form.NextClicked += PaymentMethodSelected;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void PaymentMethodSelected(object sender, PaymentMethod paymentMethod)
        {
            if (_productQuantities == null)
                throw new InvalidOperationException("Product quantity is null.");
            
            _paymentMethod = paymentMethod;
            ConfirmPlacingOrderForm form = IsNeedDelivery() || IsNeedInstallation()
                ? new ConfirmPlacingOrderForm(_productQuantities, _customerName)
                : new ConfirmPlacingOrderForm(_productQuantities);

            form.StartPosition = FormStartPosition.CenterParent;
            form.OrderConfirmed += OnPlacingOrderConfirmed;
            form.ShowDialog();
        }

        private void OnPlacingOrderConfirmed(object sender, EventArgs e)
        {
            var procedure = PaymentProcedureFactory.GeneratePaymentProcedure(_paymentMethod!.Value,
                _formController, _productQuantities!);

            procedure.PaymentCompleted += OnPaymentCompleted;
            procedure.Start();
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
                // TODO send delivery request
                // TODO send installation request
            }
            else
            {
                ReinitializePlaceOrderForm();
            }
        }

        private void ReinitializePlaceOrderForm()
        {
            Initialize();
            OpenForm();
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
                    Category = CategoryRepository.GetById(productRow.Field<string>("category"))
                };
                _pager.AddItem(new ProductQuantity(product, quantity));
            }
        }

        private IEnumerable<ProductQuantity> GetProductsInCart()
        {
            List<ProductQuantity> productQuantities = new();
            foreach (DataGridViewRow row in _form.dgvCart.Rows)
            {
                var product = new Product();
                product.Name = row.Cells["name"].ToString();
                product.SellingPrice = decimal.Parse(row.Cells["price"].Value.ToString());

                int quantity = int.Parse(row.Cells["quantity"].Value.ToString());

                productQuantities.Add(new ProductQuantity(product, quantity));
            }

            return productQuantities;
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

        private bool IsNeedDelivery()
        {
            return _form.checkBoxNeedDelivery.Checked;
        }

        private bool IsNeedInstallation()
        {
            return _form.checkBoxNeedInstallation.Checked;
        }
    }
}