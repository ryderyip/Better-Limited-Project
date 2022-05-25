using System;
using System.Windows.Forms;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public partial class DeliverySessionSelectionForm : Form
    {
        private readonly Cart _cart;
        private readonly Customer _customer;

        public DeliverySessionSelectionForm(Cart cart, Customer customer)
        {
            _cart = cart;
            _customer = customer;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!HasSelectedSession())
            {
                MessageBox.Show("Please select a delivery session!");
                return;
            }

            var session = GetSelectedSession();
            var form = new PaymentMethodSelectionForm(_cart, _customer, session);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            Close();
        }

        private bool HasSelectedSession()
        {
            return radioButtonMorning.Checked
                   || radioButtonAfternoon.Checked
                   || radioButtonEvening.Checked;
        }
        
        private DeliverySession GetSelectedSession()
        {
            if (radioButtonMorning.Checked)
                return DeliverySession.Morning;
            if (radioButtonAfternoon.Checked)
                return DeliverySession.Afternoon;
            return DeliverySession.Evening;
        }
    }
}
