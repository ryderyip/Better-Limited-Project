using System;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class CourierUpdateForm : Form
    {
        private readonly Courier _courier;

        public CourierUpdateForm(Courier courier)
        {
            _courier = courier;
            InitializeComponent();
            Shown += (_, _) => FillOldInfo();
        }

        private void FillOldInfo()
        {
            tbOriginalName.Text = _courier.Name;
            tbOriginalPhone.Text = _courier.Phone;
            tbOriginalGender.Text = EnumToStringHelper.GetDisplayValue(_courier.Gender);

            tbNewName.Text = _courier.Name;
            tbNewPhoneNumber.Text = _courier.Phone;
            if (_courier.Gender is Gender.NonBinary)
                rbGenderNonbinary.Checked = true;
            else if (_courier.Gender is Gender.Female)
                rbGenderFemale.Checked = true;
            else
                rbGenderMale.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbNewName.Text.Trim();
            string phone = tbNewPhoneNumber.Text.Trim();

            if (!IsAllFieldsFilled(name, phone))
            {
                MessageBox.Show("Please enter all required fields");
                return;
            }

            if (!CommonInformationVerifier.IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number. Please enter an 8-digit Hong Kong phone number. E.g. 12345678.");
                return;
            }

            var gender = GetSelectedGender();
            _courier.Name = name;
            _courier.Phone = phone;
            _courier.Gender = gender;
            _courier.Save();
            DialogResult = DialogResult.OK;
        }

        private Gender GetSelectedGender()
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