using System;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public partial class OctopusCardPaymentForm : Form, IPaymentForm
    {
        public OctopusCardPaymentForm(SalesOrder salesOrder)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        public void ShowForm()
        {
            throw new NotImplementedException();
            ShowDialog();
        }
    }
}
