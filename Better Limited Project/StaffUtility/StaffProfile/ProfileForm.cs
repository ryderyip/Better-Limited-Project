using System;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public partial class ProfileForm : Form
    {
        public delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        public event LogOutClickedEventHandler LogOutClicked;
        
        public ProfileForm(StaffEntity.Staff staff)
        {
            InitializeComponent();
            SetProfileFields(staff);
        }

        private void SetProfileFields(StaffEntity.Staff staff)
        {
            string titleName = new StaffTitleMapper().Map(staff.StaffTitle);
            lblLoggedInAs.Text += " " + staff.Name;
            lblStaffId.Text += " " + staff.Id;
            lblBelongTo.Text += " " + staff.Department.Name;
            lblTitle.Text += " " + titleName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOutClicked?.Invoke(sender, e);
        }
    }
}