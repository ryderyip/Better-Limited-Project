using System;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class StaffDetailsForm : Form
    {
        public event EventHandler? Updated;
        private readonly Staff _staff;

        public StaffDetailsForm(Staff staff)
        {
            _staff = staff;
            InitializeComponent();
        }

        private void StaffDetailsForm_Shown(object sender, EventArgs e)
        {
            tbId.Text = _staff.Id;
            tbName.Text = _staff.Name;
            tbGender.Text = _staff.Gender.Name;
            tbDateOfBirth.Text = _staff.DateOfBirth.ToShortDateString();
            tbHiredOn.Text = _staff.HiredOn.ToShortDateString();
            tbTitle.Text = new StaffTitleMapper().Map(_staff.Title);
            tbDepartment.Text = DepartmentMapper.Map(_staff.Department);

            if (_staff.Id == LoginSession.GetSession().StaffId)
                btnRemove.Visible = false;
        }

        private void btnUpdateStaffInfo_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var form = new ConfirmRemoveStaffForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Confirmed += (_, _) => RemoveStaff();
            form.ShowDialog();
        }

        private void RemoveStaff()
        {
            StaffRepository.RemoveStaff(_staff.Id);
            Updated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
