using System;
using System.Windows.Forms;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public partial class ProfileForm : Form
    {
        public delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        public event LogOutClickedEventHandler LogOutClicked;
        
        public ProfileForm(Staff staff, string workplaceName)
        {
            InitializeComponent();
            SetProfileFields(staff, workplaceName);
        }

        private void SetProfileFields(Staff staff, string workplaceName)
        {
            string titleName = new StaffTitleMapper().Map(staff.StaffTitle);
            lblLoggedInAs.Text += " " + staff.Name;
            lblStaffId.Text += " " + staff.Id;
            lblBelongTo.Text += " " + DepartmentEnumMapper.GetDepartmentName(staff.Department);
            lblTitle.Text += " " + titleName;
            lblWorkplaceLocation.Text += " " + workplaceName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOutClicked?.Invoke(sender, e);
        }
    }
}