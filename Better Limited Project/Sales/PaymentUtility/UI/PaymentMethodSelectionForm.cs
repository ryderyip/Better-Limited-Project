using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    public partial class PaymentMethodSelectionForm : Form
    {
        public PaymentMethodSelectionForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Shown += (_, _) => rbCash.Checked = true;
        }

        public event EventHandler<PaymentMethod>? Selected;

        private void btnNext_Click(object sender, EventArgs e)
        {
            var method = GetSelectedPaymentMethod();
            Selected?.Invoke(this, method);
            Close();
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