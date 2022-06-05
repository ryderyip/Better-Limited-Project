using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class ChangePasswordForm : Form
    {
        private readonly StaffAccount _account;
        
        public ChangePasswordForm(string staffId)
        {
            _account = StaffAccountRepository.GetAll()
                           .FirstOrDefault(account => account.StaffId == staffId)
                       ?? throw new ArgumentException($"Staff ID \"{staffId}\" does not exist.");
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!IsPasswordValid())
            {
                MessageBox.Show("New password does not meet requirement! " +
                                "Passwords must consist of at least 8 characters of a combination of English character and/or numbers.");
                return;
            }
            
            if (!DoesReEnteredPasswordMatch())
            {
                MessageBox.Show("Re-entered password does not match! Please retry!");
                return;
            }

            _account.Password = tbNewPassword.Text;
            _account.Save();
            Close();
        }

        private bool IsPasswordValid()
        {
            string password = tbNewPassword.Text;
            var verifier = new StaffAccountCreationVerifier();
            return verifier.IsPasswordValid(password);
        }

        private bool DoesReEnteredPasswordMatch()
        {
            string newPassword = tbNewPassword.Text;
            string reEnteredPassword = tbNewPasswordReEnter.Text;
            return newPassword == reEnteredPassword;
        }
    }
}
