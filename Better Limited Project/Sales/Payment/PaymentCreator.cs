using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord;

namespace Better_Limited_Project.Sales.Payment
{
    public class PaymentCreator
    {
        private readonly FormController _formController;

        public delegate void PaymentCompletedClickedEventHandler(object sender, PaymentStatus status);
        public event PaymentCompletedClickedEventHandler PaymentCompleted;

        public PaymentCreator(FormController formController)
        {
            _formController = formController;
        }
        
        public void CreatePayment()
        {
            ShowCustomerRecordForm();
        }

        private void ShowCustomerRecordForm()
        {
            var form = new IsFirstTimeCustomerSelectionForm();
            form.ButtonClicked += OnCustomerTypeChosen;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void OnCustomerTypeChosen(object sender, bool isFirstTimeCustomer)
        {
            if (isFirstTimeCustomer)
            {
                var controller = new CreateCustomerRecordController(_formController);
                controller.NextClicked += OnCustomerRecordRetrieved;
                controller.BackClicked += (_, _) => PaymentCompleted?.Invoke(this, PaymentStatus.Cancelled);
                controller.OpenForm();
            }
            else
            {
                var controller = new FindCustomerRecordController(_formController);
                controller.NextClicked += OnCustomerRecordRetrieved;
                controller.BackClicked += (_, _) => PaymentCompleted?.Invoke(this, PaymentStatus.Cancelled);
                controller.OpenForm();
            }
        }

        private void OnCustomerRecordRetrieved(object sender, Customer customer)
        {
            throw new NotImplementedException("FUCK YOU");
        }
    }
}