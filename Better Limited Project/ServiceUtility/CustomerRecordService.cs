using System;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.UI;

namespace Better_Limited_Project.ServiceUtility
{
    public class CustomerRecordService
    {
        public event EventHandler<Customer>? CustomerRecordRetrieved;

        public void RetrieveCustomerRecord()
        {
            var form = new IsFirstTimeCustomerSelectionForm();
            form.IsFirstTimeCustomerSelected += OnIsFirstTimeCustomerSelected;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void OnIsFirstTimeCustomerSelected(object sender, bool isFirstTime)
        {
            if (isFirstTime)
            {
                var form = new CreateCustomerRecordForm();
                form.CustomerCreated += (_, customer) => CustomerRecordRetrieved?.Invoke(this, customer);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
            else
            {
                var form = new FindCustomerRecordForm();
                form.CustomerRecordFound += (_, customer) => CustomerRecordRetrieved?.Invoke(this, customer);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
        }
    }
}