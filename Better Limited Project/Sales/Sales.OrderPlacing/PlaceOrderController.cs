using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.Payment;
using Better_Limited_Project.Sales.Sales.Payment;
using Better_Limited_Project.Sales.Sales.SalesOrder;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public class PlaceOrderController
    {
        private PlaceOrderForm _form;
        private Pager<RetailStoreStock> _pager;
        private const int PageSize = 6;
        private readonly FormController _formController;
        private string? _customerName;
        private DeliverySession? _deliverySession;
        private PaymentMethod? _paymentMethod;
        private readonly Cart _cart;

        public PlaceOrderController()
        {
            _cart = new Cart();
            _pager = new Pager<RetailStoreStock>(PageSize);
            _form = new PlaceOrderForm(_pager, _cart);
            _formController = new FormController(OuterFormGenerator.Generate());
            Initialize();
        }

        private void Initialize()
        {
            _pager = new Pager<RetailStoreStock>(PageSize);
            _form = new PlaceOrderForm(_pager, _cart);
            _form.Shown += SetCartDgvSchemaOnFormShown;
            _form.btnNext.Click += OnPlaceOrderFormNextClicked;
            PopulatePagerWithProducts();
        }

        private void SetCartDgvSchemaOnFormShown(object sender, EventArgs e)
        {
            _form.dgvCart.Columns.Add("name", "Name");
            _form.dgvCart.Columns.Add("price", "Price");
            _form.dgvCart.Columns.Add("quantity", "Qty");
            _form.dgvCart.Columns.Add("category", "Category");
        }

        private void OnPlaceOrderFormNextClicked(object sender, EventArgs e)
        {
            if (_cart.IsEmpty())
                return; // TODO prompt a non intruding message

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
            form.StartPosition = FormStartPosition.CenterScreen;
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
            throw new NotImplementedException("after payment method selected");
            /*_paymentMethod = paymentMethod;
            ConfirmPlacingOrderForm form = IsNeedDelivery() || IsNeedInstallation()
                ? new ConfirmPlacingOrderForm(_productQuantities, _customerName)
                : new ConfirmPlacingOrderForm(_productQuantities);

            form.StartPosition = FormStartPosition.CenterParent;
            form.OrderConfirmed += OnPlacingOrderConfirmed;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();*/
        }

        private void OnPlacingOrderConfirmed(object sender, EventArgs e)
        {
            throw new NotImplementedException("after order confirmed");
            /*var procedure = PaymentProcedureFactory.GeneratePaymentProcedure(_paymentMethod!.Value,
                _formController, _productQuantities!);

            procedure.PaymentCompleted += OnPaymentCompleted;
            procedure.Start();*/
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
                ReinitializePlaceOrderForm();
        }

        private void ReinitializePlaceOrderForm()
        {
            Initialize();
            OpenForm();
        }

        private void PopulatePagerWithProducts()
        {
            GetStocks().ForEach(stock => _pager.AddItem(stock));
        }
        
        private List<RetailStoreStock> GetStocks()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id!;
            return StockRepository.GetRetailStoreStocks(retailStoreId).ToList();
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