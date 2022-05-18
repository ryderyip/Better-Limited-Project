using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.Sales.Payment
{
    public partial class PaymentMethodSelectionForm : Form
    {
        public delegate void ButtonClickedEventHandler(object sender, PaymentMethod paymentMethod);
        public event ButtonClickedEventHandler NextClicked;
        
        public PaymentMethodSelectionForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!HasSelectedPaymentMethod())
                return; // TODO display warning message if no method selected
            
            NextClicked?.Invoke(this, GetSelectedPaymentMethod());
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
