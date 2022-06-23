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
            _account = new StaffAccountRepository().GetAll()
                           .FirstOrDefault(account => account.StaffId == staffId)
                       ?? throw new ArgumentException($"Staff ID \"{staffId}\" does not exist.");
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!IsPasswordValid())
            {
                MessageBox.Show(StaffUtilityStringResources
                    .ChangePasswordForm_btnApply_Click_New_password_does_not_meet_requirement__Passwords_must_consist_of_at_least_8_characters_of_a_combination_of_English_character_and_or_numbers_);
                return;
            }

            if (!DoesReEnteredPasswordMatch())
            {
                MessageBox.Show(StaffUtilityStringResources.reentered_password_dont_match);
                return;
            }

            _account.Password = tbNewPassword.Text;
            _account.Save(new StaffAccountRepository());
            Close();
        }

        private bool IsPasswordValid()
        {
            string password = tbNewPassword.Text;
            var verifier = new StaffAccountCreationVerifier(new StaffAccountRepository());
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