using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    public partial class CashPaymentForm : Form, IPaymentForm
    {
        public event EventHandler<Payment>? PaymentCompleted;
        private readonly Payment _payment;

        public CashPaymentForm(decimal amount)
        {
            _payment = new Payment(amount, PaymentMethod.Cash);
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void ShowForm()
        {
            ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            decimal owned = _payment.Amount;
            decimal tendered = nudAmountTendered.Value;
            if (tendered < owned)
            {
                MessageBox.Show("Please pay enough cash.");
                return;
            }

            _payment.PaidOn = DateTime.Now;
            _payment.Save();
            PaymentCompleted?.Invoke(this, _payment);
            Close();
        }

        private void CashPaymentForm_Shown(object sender, EventArgs e)
        {
            tbCashOwned.Text = _payment.Amount.ToString("C", new CultureInfo("zh-HK"));
            nudAmountTendered.Maximum = Product.MaximumPrice;
            nudAmountTendered.DecimalPlaces = 2;
            tbChange.Text = decimal.Zero.ToString("C", new CultureInfo("zh-HK"));
        }

        private void nudAmountTendered_ValueChanged(object sender, EventArgs e)
        {
            decimal owned = _payment.Amount;
            decimal tendered = nudAmountTendered.Value;
            if (tendered < owned)
                return;
            tbChange.Text = (tendered - owned).ToString("C", new CultureInfo("zh-HK"));
        }
    }
}