using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord;

namespace Better_Limited_Project.Sales.Payment
{
    public class CreateCustomerRecordController
    {
        private readonly FormController _formController;
        public delegate void ButtonClickedEventHandler<T>(object sender, T args);
        public event ButtonClickedEventHandler<Customer> NextClicked;
        public event ButtonClickedEventHandler<EventArgs> BackClicked;

        public CreateCustomerRecordController(FormController formController)
        {
            _formController = formController;
        }

        public void OpenForm()
        {
            var form = new CreateCustomerRecordForm();
            form.CustomerRecordCreated += (_, c) => NextClicked?.Invoke(this, c);
            form.btnBack.Click += (_, _) => BackClicked?.Invoke(this, EventArgs.Empty);
            _formController.OpenFullForm(form);
        }
    }
}