using System;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class UpdateStaffDetailsForm : Form
    {
        private readonly Staff _staff;
        public event EventHandler? Updated;
        
        public UpdateStaffDetailsForm(Staff staff)
        {
            _staff = staff;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            IGender gender = rbGenderMale.Checked ? new Male()
                : rbGenderFemale.Checked ? new Female()
                : new NonBinary();
            DateTime dob = dtpDateOfBirth.Value;
            StaffTitle title = new StaffTitleMapper().Map(cbTitle.SelectedItem.ToString());
            
            _staff.Name = name;
            _staff.Gender = gender;
            _staff.DateOfBirth = dob;
            _staff.Title = title;
            _staff.Save();    
            
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            tbName.Text = _staff.Name;
            ToggleGenderRadioButtonWithCurrentGender();
            dtpDateOfBirth.MaxDate = DateTimePickerHelper.GetBirthdayMaximumDate();
            dtpDateOfBirth.MinDate = DateTimePickerHelper.GetBirthdayMinimumDate();
            dtpDateOfBirth.Value = _staff.DateOfBirth;
            var titles = DepartmentStaffTitleMatchingHelper.GetTitlesUnderDepartment(_staff.Department);
            titles.ForEach(title => cbTitle.Items.Add(new StaffTitleMapper().Map(title)));
            cbTitle.SelectedIndex = titles.IndexOf(_staff.Title);
        }

        private void ToggleGenderRadioButtonWithCurrentGender()
        {
            switch (_staff.Gender)
            {
                case Male:
                    rbGenderMale.Checked = true;
                    break;
                case Female:
                    rbGenderFemale.Checked = true;
                    break;
                default:
                    rbGenderNonbinary.Checked = true;
                    break;
            }
        }
    }
}
