using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.OrderPlacing.Controller
{
    public class PlaceOrderController
    {
        private PlaceOrderForm _form;
        private Pager<RetailStoreStock> _pager;
        private const int PageSize = 6;
        private readonly Cart _cart;

        public PlaceOrderController()
        {
            _cart = new Cart(UserSettings.GetSettings().Workplace!.Id);
            _pager = new Pager<RetailStoreStock>(PageSize);
            _form = new PlaceOrderForm(_pager, _cart);
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
            _cart.Clear();
            OpenForm();
        }

        public void OpenForm()
        {
            _form.StartPosition = FormStartPosition.CenterParent;
            _form.ShowDialog();
        }
    }
}