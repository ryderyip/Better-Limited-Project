using System;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.Sales.OrderPlacing;
using Better_Limited_Project.Sales.Sales.OrderPlacing.CustomerRecord;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public partial class PaymentMethodSelectionForm : Form
    {
        private readonly Cart _cart;
        private readonly Customer? _customer;
        private readonly DeliverySession? _session;

        public PaymentMethodSelectionForm(Cart cart)
        {
            _cart = cart;
            InitializeComponent();
        }

        public PaymentMethodSelectionForm(Cart cart, Customer customer, DeliverySession session) : this(cart)
        {
            _customer = customer;
            _session = session;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!HasSelectedPaymentMethod())
                return; // TODO display warning message if no method selected

            var method = GetSelectedPaymentMethod();
            
            /*form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();*/
            Close();
        }

        private bool HasSelectedPaymentMethod()
        {
            return rbCash.Checked || rbOctopus.Checked || rbCreditCard.Checked;
        }

        private PaymentMethod GetSelectedPaymentMethod()
        {
            if (rbCash.Checked)
                return PaymentMethod.Cash;
            if (rbOctopus.Checked)
                return PaymentMethod.Octopus;
            return PaymentMethod.CreditCard;
        }
    }
}