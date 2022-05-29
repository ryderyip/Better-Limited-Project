using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class ConfirmRemoveStaffForm : Form
    {
        public event EventHandler? Confirmed;
        private readonly StaffAccount _currentLoggedInAdminAccount;
        
        public ConfirmRemoveStaffForm()
        {
            string currentAdminId = LoginSession.GetSession().CurrentStaff.Id;
            _currentLoggedInAdminAccount = StaffAccountRepository.GetStaffAccounts().First(ac => ac.StaffId == currentAdminId);
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_currentLoggedInAdminAccount.Password != tbPassword.Text)
            {
                MessageBox.Show("Wrong password!");
                return;
            }
            Confirmed?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void ConfirmRemoveStaffForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Close();
            else if (e.KeyChar == (char) Keys.Enter)
                btnRemove.PerformClick();
        }
    }
}
