using System;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public partial class ProfileForm : Form
    {
        public delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        public event LogOutClickedEventHandler? LogOutClicked;
        
        public ProfileForm(Staff staff, string workplaceName)
        {
            InitializeComponent();
            SetProfileFields(staff, workplaceName);
        }

        private void SetProfileFields(Staff staff, string workplaceName)
        {
            string space = " ";
            string titleName = new StaffTitleMapper().Map(staff.Title);
            lblLoggedInAs.Text += space + staff.Name;
            lblStaffId.Text += space + staff.Id;
            lblBelongTo.Text += space + DepartmentMapper.Map(staff.Department);
            lblTitle.Text += space + titleName;

            if (staff.Department is not Department.Sales or Department.Inventory)
                lblWorkplaceLocation.Visible = false;
            else
                lblWorkplaceLocation.Text += space + workplaceName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOutClicked?.Invoke(sender, e);
        }
    }
}