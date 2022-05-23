using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffEntity.Gender;

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
            int daysInAYear = 365;
            dtpDateOfBirth.MaxDate = DateTime.Today - TimeSpan.FromDays(daysInAYear * 18);
            dtpDateOfBirth.MinDate = DateTime.Today - TimeSpan.FromDays(daysInAYear * 200);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matchingHelper = new DepartmentStaffTitleMatchingHelper();
            var affiliatedTitles =
                matchingHelper.GetTitlesUnderDepartment(GetSelectedDepartment());
            cbTitle.Items.Clear();
            var titleMapper = new StaffTitleMapper();
            affiliatedTitles.ForEach(title => cbTitle.Items.Add(titleMapper.Map(title)));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!HasFilledAllFields())
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            var selectedDepartment = GetSelectedDepartment();
            var selectedTitle = GetSelectedTitle();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (!IsSelectedTitleMatchSelectedDepartment())
            {
                MessageBox.Show($"Title \"{selectedTitle}\" does not match department \"{selectedDepartment}\"." +
                                " Please reselect the title/department.");
                return;
            }

            var accountVerifier = new StaffAccountCreationVerifier();
            if (!accountVerifier.IsUsernameValid(username))
            {
                MessageBox.Show($"Username \"{username}\" is not valid. " +
                                "Usernames must consist of at least 4 characters of a combination of English character and/or numbers.");
                return;
            }

            if (!accountVerifier.IsUsernameUnique(username))
            {
                MessageBox.Show($"Username \"{username}\" has been taken. Please choose another one.");
                return;
            }

            if (!accountVerifier.IsPasswordValid(password))
            {
                MessageBox.Show($"Passowrd \"{password}\" is not valid. " +
                                "Passwords must consist of at least 8 characters of a combination of English character and/or numbers.");
                return;
            }

            string name = tbName.Text;
            IGender gender = rbGenderMale.Checked ? new Male()
                : rbGenderFemale.Checked ? new Female()
                : rbGenderNonbinary.Checked ? new NonBinary()
                : throw new InvalidOperationException("No gender is selected.");
            DateTime dob = dtpDateOfBirth.Value;
            string id = new StaffIdGenerator().Generate(selectedDepartment);

            StaffRepository.CreateStaff(id, name, dob, gender, selectedDepartment, selectedTitle);
            StaffAccountRepository.CreateAccount(id, username, password);
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
            var matchingHelper = new DepartmentStaffTitleMatchingHelper();
            return GetSelectedDepartment() ==
                   matchingHelper.GetDepartmentOverTitle(GetSelectedTitle());
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
    }
}