using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord;
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
        private readonly Cart _cart;

        public PlaceOrderController()
        {
            _cart = new Cart(UserSettings.GetSettings().Workplace!.Id);
            _pager = new Pager<RetailStoreStock>(PageSize);
            _form = new PlaceOrderForm(_pager, _cart);
            _formController = new FormController(OuterFormGenerator.Generate());
            Initialize();
        }
        
        public PlaceOrderController(Cart cart)
        {
            _cart = cart;
            _pager = new Pager<RetailStoreStock>(PageSize);
            _form = new PlaceOrderForm(_pager, _cart);
            _formController = new FormController(OuterFormGenerator.Generate());
            Initialize();
        }

        private void Initialize()
        {
            _pager = new Pager<RetailStoreStock>(PageSize);
            _form = new PlaceOrderForm(_pager, _cart);
            _form.btnNext.Click += OnPlaceOrderFormNextClicked;
            PopulatePagerWithProducts();
        }

        private void OnPlaceOrderFormNextClicked(object sender, EventArgs e)
        {
            if (_cart.IsEmpty())
                return; // TODO prompt a non intruding message

            if (IsNeedDelivery() || IsNeedInstallation())
            {
                var form = new IsFirstTimeCustomerSelectionForm(_formController, _cart);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }

            else
            {
                var form = new ConfirmPlacingOrderForm(_cart);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
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
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id!;
            StockRepository.GetRetailStoreStocks(retailStoreId).ToList()
                .ForEach(stock => _pager.AddItem(stock));
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