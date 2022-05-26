using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public partial class CashPaymentForm : Form, IPaymentForm
    {
        private readonly SalesOrder _salesOrder;

        public CashPaymentForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void ShowForm()
        {
            ShowDialog();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {

        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            
        }

        private void CashPaymentForm_Shown(object sender, System.EventArgs e)
        {
            tbCashOwned.Text = _salesOrder.Cart.HasNeedDepositItem()
                ? _salesOrder.Cart.GetTotalDepositPrice().ToString("C", new CultureInfo("zh-HK"))
                : _salesOrder.Cart.GetTotalPrice().ToString("C", new CultureInfo("zh-HK"));
            nudAmountTendered.Maximum = Product.MaximumPrice;
            nudAmountTendered.DecimalPlaces = 2;
        }
    }
}
