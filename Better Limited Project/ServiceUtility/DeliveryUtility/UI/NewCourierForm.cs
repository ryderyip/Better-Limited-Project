using System;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class NewCourierForm : Form
    {
        public NewCourierForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string phone = tbPhoneNumber.Text.Trim();

            if (!IsAllFieldsFilled(name, phone))
            {
                MessageBox.Show(CreateCustomerRecordForm.hasUnfilledRequiredFieldsMessage);
                return;
            }

            if (!CommonInformationVerifier.IsValidPhoneNumber(phone))
            {
                MessageBox.Show(CreateCustomerRecordForm.invalidPhoneNumberMessage);
                return;
            }

            var gender = GetGender();
            var courier = new Courier(name, gender, phone);
            courier.Save();
            DialogResult = DialogResult.OK;
        }

        private Gender GetGender()
        {
            return rbGenderMale.Checked ? Gender.Male
                : rbGenderFemale.Checked ? Gender.Female
                : Gender.NonBinary;
        }

        private bool IsAllFieldsFilled(string name, string phone)
        {
            return !string.IsNullOrWhiteSpace(name)
                   && !string.IsNullOrWhiteSpace(phone)
                   && (rbGenderMale.Checked
                       || rbGenderFemale.Checked
                       || rbGenderNonbinary.Checked);
        }
    }
}
