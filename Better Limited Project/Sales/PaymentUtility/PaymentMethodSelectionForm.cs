using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Sales.OrderPlacing;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public partial class PaymentMethodSelectionForm : Form
    {
        private readonly SalesOrder _order;

        public PaymentMethodSelectionForm(SalesOrder order)
        {
            _order = order;
            InitializeComponent();
            Shown += (_, _) => rbCash.Checked = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var method = GetSelectedPaymentMethod();
            var form = PaymentFormFactory.Generate(method, _order);
            form.ShowForm();
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