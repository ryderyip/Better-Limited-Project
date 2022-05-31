using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.OrderPlacing
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
            
            StockRepository.GetRetailStoreStocks(UserSettings.GetSettings().Workplace?.Id!)
                .ToList()
                .ForEach(stock => _pager.AddItem(stock));
        }

        private void OnPlaceOrderFormNextClicked(object sender, EventArgs e)
        {
            if (_cart.IsEmpty())
                return; // TODO prompt a non intruding message

            if (_form.checkBoxNeedDelivery.Checked || _form.checkBoxNeedInstallation.Checked)
            {
                var service = new CustomerRecordService();
                service.CustomerRecordRetrieved += (_, customer) => PlaceOrder(customer);
                service.RetrieveCustomerRecord();
            }

            else
                PlaceOrder();
        }

        private void PlaceOrder(Customer? customer = null)
        {
            var service = new PlaceOrderService(_cart, customer)
            {
                IsNeedDelivery = _form.checkBoxNeedDelivery.Checked,
                IsNeedInstallation = _form.checkBoxNeedInstallation.Checked
            };
            service.SalesOrderPlaced += (_, _) => ReinitializePlaceOrderForm();
            service.PlaceOrder();
        }

        private void ReinitializePlaceOrderForm()
        {
            Initialize();
            OpenForm();
            _cart.Clear();
        }

        public void OpenForm()
        {
            _formController.OpenFullForm(_form);
        }
    }
}