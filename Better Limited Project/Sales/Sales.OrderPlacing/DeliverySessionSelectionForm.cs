using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public partial class DeliverySessionSelectionForm : Form
    {
        public delegate void ButtonClickedEventHandler(object sender, DeliverySession deliverySession);
        public event ButtonClickedEventHandler NextClicked;

        public DeliverySessionSelectionForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!HasSelectedSession())
            {
                MessageBox.Show("Please select a delivery session!");
                return;
            }
            NextClicked?.Invoke(this, GetSelectedSession());
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
