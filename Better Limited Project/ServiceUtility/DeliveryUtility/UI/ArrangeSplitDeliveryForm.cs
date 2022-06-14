using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class ArrangeSplitDeliveryForm : Form, IArrangeDeliveryForm
    {
        public event EventHandler? SwitchFormClicked;
        public event EventHandler? DeliveryArranged;
        private readonly DeliveryRequest _deliveryRequest;
        private readonly List<Courier> _selectedCouriers;

        public ArrangeSplitDeliveryForm(DeliveryRequest deliveryRequest, List<Courier> selectedCouriers)
        {
            _deliveryRequest = deliveryRequest;
            _selectedCouriers = selectedCouriers;
            InitializeComponent();
        }
        
        public void ShowForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            ShowDialog();
        }

        public void CloseForm()
        {
            Close();
        }

        private void btnSingleDelivery_Click(object sender, EventArgs e)
        {
            SwitchFormClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
