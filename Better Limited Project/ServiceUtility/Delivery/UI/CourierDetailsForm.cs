using System;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.Delivery.Entity;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    public partial class CourierDetailsForm : Form
    {
        public event EventHandler? CourierUpdated;
        
        private Courier _courier;

        public CourierDetailsForm(Courier courier)
        {
            _courier = courier;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }

        private void FillFields()
        {
            tbName.Text = _courier.Name;
            tbGender.Text = EnumToStringHelper.GetDisplayValue(_courier.Gender);
            tbHiredOn.Text = _courier.HiredOn.ToLongDateString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new CourierUpdateForm(_courier);
            form.StartPosition = FormStartPosition.CenterScreen;
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
            {
                _courier = CourierRepository.FindById(_courier.Id);
                FillFields();
                CourierUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
