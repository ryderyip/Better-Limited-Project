using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class NewStaffForm : Form
    {
        public event EventHandler? StaffAdded;

        private readonly List<Department> _departments;
        private readonly List<StaffTitle> _titles;

        public NewStaffForm()
        {
            _departments = DepartmentRepository.GetDepartments().ToList();
            _titles = StaffTitleRepository.GetTitles().ToList();
            InitializeComponent();
        }

        private void NewStaffForm_Shown(object sender, EventArgs e)
        {
            _departments.ForEach(department => cbDepartment.Items.Add(DepartmentMapper.Map(department)));
            var titleMapper = new StaffTitleMapper();
            _titles.ForEach(title => cbTitle.Items.Add(titleMapper.Map(title)));
            InitializeDateOfBirthPicker();
        }

        private void InitializeDateOfBirthPicker()
        {
            dtpDateOfBirth.MaxDate = DateTimePickerHelper.GetBirthdayMaximumDate();
            dtpDateOfBirth.MinDate = DateTimePickerHelper.GetBirthdayMinimumDate();
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var affiliatedTitles =
                DepartmentStaffTitleMatchingHelper.GetTitlesUnderDepartment(GetSelectedDepartment());
            cbTitle.Items.Clear();
            var titleMapper = new StaffTitleMapper();
            affiliatedTitles.ForEach(title => cbTitle.Items.Add(titleMapper.Map(title)));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!HasFilledAllFields())
            {
                MessageBox.Show(StaffUtilityStringResources.not_all_fields_filled);
                return;
            }

            var selectedDepartment = GetSelectedDepartment();
            var selectedTitle = GetSelectedTitle();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (!IsSelectedTitleMatchSelectedDepartment())
            {
                MessageBox.Show(string.Format(StaffUtilityStringResources.selected_department_title_dont_match, selectedTitle, selectedDepartment));
                return;
            }

            var accountVerifier = new StaffAccountCreationVerifier();
            if (!accountVerifier.IsUsernameValid(username))
            {
                MessageBox.Show(string.Format(StaffUtilityStringResources.username_not_valid, username));
                return;
            }

            if (!accountVerifier.IsUsernameUnique(username))
            {
                MessageBox.Show(string.Format(StaffUtilityStringResources.username_not_unique, username));
                return;
            }

            if (!accountVerifier.IsPasswordValid(password))
            {
                MessageBox.Show(StaffUtilityStringResources.password_not_valid);
                return;
            }

            string name = tbName.Text.Trim();
            IGender gender = rbGenderMale.Checked ? new Male()
                : rbGenderFemale.Checked ? new Female()
                : rbGenderNonbinary.Checked ? new NonBinary()
                : throw new InvalidOperationException("No gender is selected.");
            DateTime dob = dtpDateOfBirth.Value;

            var staff = new Staff(name, dob, DateTime.Now, gender, selectedDepartment, selectedTitle);
            staff.Save();

            var staffAccount = new StaffAccount(staff.Id, username, password);
            staffAccount.Save();

            var image = pbImage.Image;
            if (image != null)
                StaffImageRepository.InsertOrUpdate(staff, image);
            
            StaffAdded?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private Department GetSelectedDepartment()
        {
            return _departments[cbDepartment.SelectedIndex];
        }

        private StaffTitle GetSelectedTitle()
        {
            var mapper = new StaffTitleMapper();
            return _titles.Find(title => mapper.Map(title) == cbTitle.SelectedItem.ToString());
        }

        private bool IsSelectedTitleMatchSelectedDepartment()
        {
            return GetSelectedDepartment() ==
                   DepartmentStaffTitleMatchingHelper.GetDepartmentOverTitle(GetSelectedTitle());
        }

        private bool HasFilledAllFields()
        {
            return tbName.Text.Length != 0 && HasSelectedGender()
                                           && cbDepartment.SelectedIndex != -1 && cbTitle.SelectedIndex != -1
                                           && tbUsername.Text.Length != 0 && tbPassword.Text.Length != 0;
        }

        private bool HasSelectedGender()
        {
            return rbGenderMale.Checked || rbGenderFemale.Checked || rbGenderNonbinary.Checked;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            string browserDescription = "Select a Product Image";
            var path = ImageFileBrowser.Browse(browserDescription);
            if (path == null) return;
            
            tbStaffImagePath.Text = path;
            var image = ImageRetriever.Retrieve(path);
            if (image != null)
                pbImage.Image = image;
        }
    }
}