using System;
using System.Globalization;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    public partial class OctopusCardPaymentForm : Form, IPaymentForm
    {
        private readonly Timer _timer;

        public OctopusCardPaymentForm(decimal amount)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _timer = new Timer();
            _timer.Interval = 3000;
            _timer.Tick += OnTimerEnds;
            Shown += (_, _) => tbCashOwned.Text = amount.ToString("C", new CultureInfo("zh-HK"));
            Shown += (_, _) => _timer.Start();
        }

        public event EventHandler<PaymentMethod>? PaymentCompleted;

        public void ShowForm()
        {
            ShowDialog();
        }

        private void OnTimerEnds(object sender, EventArgs e)
        {
            _timer.Stop();
            PaymentCompleted?.Invoke(this, PaymentMethod.Octopus);
            Close();
        }
    }
}