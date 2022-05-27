using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public partial class OctopusCardPaymentForm : Form, IPaymentForm
    {
        public OctopusCardPaymentForm(decimal amount)
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
