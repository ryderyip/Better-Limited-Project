using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class StaffDetailsForm : Form
    {
        private Staff _staff;

        public StaffDetailsForm(string staffId)
        {
            _staff = new StaffRepository().FindById(staffId);
            Shown += (_, _) => Initialize();
            InitializeComponent();
        }

        public event EventHandler? Updated;

        private bool DoesCurrentStaffHaveAccount()
        {
            return new StaffAccountRepository().GetAll()
                .Any(account => account.StaffId == _staff.Id);
        }

        private void Initialize()
        {
            tbId.Text = "-";
            tbName.Text = _staff.Name;
            tbGender.Text = EnumToStringHelper.GetDisplayValue(_staff.Gender);
            tbDateOfBirth.Text = _staff.DateOfBirth.ToShortDateString();
            tbHiredOn.Text = _staff.HiredOn.ToShortDateString();
            tbTitle.Text = new StaffTitleMapper().Map(_staff.Title);
            tbDepartment.Text = DepartmentMapper.Map(_staff.Department);
            tbUsername.Text = _staff.GetLoginAccount().Username;
            pbImage.Image = _staff.GetImage();
        }

        private void RefreshAllFields()
        {
            _staff = new StaffRepository().FindById(_staff.Id);
            Initialize();
        }

        private void btnUpdateStaffInfo_Click(object sender, EventArgs e)
        {
            var form = new UpdateStaffDetailsForm(_staff);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Updated += OnStaffInfoUpdated;
            form.Updated += (_, _) => RefreshAllFields();
            form.ShowDialog();
        }

        private void OnStaffInfoUpdated(object sender, EventArgs e)
        {
            RefreshAllFields();
            Updated?.Invoke(this, EventArgs.Empty);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!DoesCurrentStaffHaveAccount())
            {
                MessageBox.Show(StaffUtilityStringResources.no_staff_account_when_try_to_change_password);
                return;
            }

            var form = new ChangePasswordForm(_staff.Id);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            var form = new UploadImageForm(_staff.GetImage());
            form.Uploaded += (_, image) =>
            {
                if (image == null) return;
                _staff.SetImage(image);
                RefreshAllFields();
            };
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}