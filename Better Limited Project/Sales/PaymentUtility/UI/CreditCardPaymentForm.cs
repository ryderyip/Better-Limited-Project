using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    public partial class CreditCardPaymentForm : Form, IPaymentForm
    {
        public CreditCardPaymentForm(decimal amount)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        public event EventHandler<Payment>? PaymentCompleted;

        public void ShowForm()
        {
            throw new NotImplementedException();
            ShowDialog();
        }
    }
}
