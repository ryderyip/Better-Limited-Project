using System;
using System.Globalization;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.PaymentUtility.UI
{
    public partial class OctopusCardPaymentForm : Form, IPaymentForm
    {
        public event EventHandler<PaymentMethod>? PaymentCompleted;
        private readonly decimal _amount;
        private readonly Timer _timer;
   
        public OctopusCardPaymentForm(decimal amount)
        {
            _amount = amount;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _timer = new();
            _timer.Interval = 3000;
            _timer.Tick += OnTimerEnds;
            Shown += (_, _) => tbCashOwned.Text = _amount.ToString("C", new CultureInfo("zh-HK"));
            Shown += (_, _) => _timer.Start();
        }
        
        private void OnTimerEnds(object sender, EventArgs e)
        {
            _timer.Stop();
            PaymentCompleted?.Invoke(this, PaymentMethod.Octopus);
            Close();
        }
        
        public void ShowForm()
        {
            ShowDialog();
        }
    }
}
