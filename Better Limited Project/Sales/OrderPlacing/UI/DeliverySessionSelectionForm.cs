using System;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class DeliverySessionSelectionForm : Form
    {
        public DeliverySessionSelectionForm()
        {
            InitializeComponent();
        }

        public event EventHandler<DeliverySession>? SessionSelected;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!HasSelectedSession())
            {
                MessageBox.Show(PaymentStringResources.pleaseSelectDeliverySession);
                return;
            }

            var session = GetSelectedSession();
            SessionSelected?.Invoke(this, session);
            Close();
        }

        private bool HasSelectedSession()
        {
            return radioButtonMorning.Checked
                   || radioButtonAfternoon.Checked
                   || radioButtonEvening.Checked;
        }

        private DeliverySession GetSelectedSession()
        {
            if (radioButtonMorning.Checked)
                return DeliverySession.Morning;
            if (radioButtonAfternoon.Checked)
                return DeliverySession.Afternoon;
            return DeliverySession.Evening;
        }
    }
}