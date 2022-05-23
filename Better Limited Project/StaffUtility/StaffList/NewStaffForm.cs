using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;

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

        private void cbDepartment_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var matchingHelper = new DepartmentStaffTitleMatchingHelper();
            var affiliatedTitles =
                matchingHelper.GetTitlesUnderDepartment(_departments[cbDepartment.SelectedIndex]);
            cbTitle.Items.Clear();
            var titleMapper = new StaffTitleMapper();
            affiliatedTitles.ForEach(title => cbTitle.Items.Add(titleMapper.Map(title)));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var selectedDepartment = GetSelectedDepartment();
            var selectedTitle = GetSelectedTitle();
            if (!IsSelectedTitleMatchSelectedDepartment())
            {
                MessageBox.Show($"Title \"{selectedTitle}\" does not match department \"{selectedDepartment}\"." +
                                " Please reselect the title/department.");
                return;
            }

            if (!HasFilledAllFields())
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            
            string name = tbName.Text;
            string gender = rbGenderMale.Checked ? "M"
                : rbGenderFemale.Checked ? "F"
                : rbGenderNonbinary.Checked ? "N" : throw new InvalidOperationException("No gender is selected.");
            DateTime dob = dtpDateOfBirth.Value;
            string id = new StaffIdGenerator().Generate(selectedDepartment);

            StaffRepository.CreateStaff(id, name, dob, gender, selectedDepartment, selectedTitle);
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
                   && cbDepartment.SelectedIndex != -1 && cbTitle.SelectedIndex != -1;
        }

        private bool HasSelectedGender()
        {
            return rbGenderMale.Checked || rbGenderFemale.Checked || rbGenderNonbinary.Checked;
        }
    }
}