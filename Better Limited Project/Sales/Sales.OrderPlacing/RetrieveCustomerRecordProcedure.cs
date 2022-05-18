using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Sales.Payment;
using Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public  class RetrieveCustomerRecordProcedure
    {
        private readonly FormController _formController;
        public delegate void CustomerRecordRetrievedEventHandler(object sender, string customerName);
        public event CustomerRecordRetrievedEventHandler? CustomerRecordRetrieved;
        
        public delegate void CancelledEventHandler(object sender, EventArgs e);
        public event CancelledEventHandler? Cancelled;
        
        public RetrieveCustomerRecordProcedure(FormController formController)
        {
            _formController = formController;
        }
        
        public void Start()
        {
            ShowIsFirstTimeCustomerForm();
        }

        private void ShowIsFirstTimeCustomerForm()
        {
            var form = new IsFirstTimeCustomerSelectionForm();
            form.ButtonClicked += OnIsFirstTimeChosen;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
        
        private void OnIsFirstTimeChosen(object sender, bool isFirstTimeCustomer)
        {
            /*var productQuantities = GetProductsInCart();
            
            var paymentCreator = new PaymentCreator(_formController, productQuantities);
            paymentCreator.PaymentCompleted += OnPaymentCompleted;*/
            
            if (isFirstTimeCustomer)
            {
                var controller = new CreateCustomerRecordController(_formController);
                controller.NextClicked += OnCustomerRecordRetrieved;
                controller.BackClicked += (_, _) => Cancelled?.Invoke(this, EventArgs.Empty);
                controller.OpenForm();

            }
            else
            {
                var controller = new FindCustomerRecordController(_formController);
                controller.NextClicked += OnCustomerRecordRetrieved;
                controller.BackClicked += (_, _) => Cancelled?.Invoke(this, EventArgs.Empty);
                controller.OpenForm();
            }
        }

        private void OnCustomerRecordRetrieved(object sender, Customer customer)
        {
            CustomerRecordRetrieved?.Invoke(this, customer.Name);
        }
    }
}