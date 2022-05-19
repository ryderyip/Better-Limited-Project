using System;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.DevTools.AutoLogin
{
    /// <summary>
    /// Only for facilitating login progress
    /// </summary>
    public class AutoLoginHelper
    {
        private readonly TextBox _tbUsername;
        private readonly TextBox _tbPassword;
        private readonly Action<object, EventArgs> _btnLoginClicked;
        private readonly StaffRoleChooserForm _form;

        public AutoLoginHelper(TextBox tbUsername, TextBox tbPassword, Action<object, EventArgs> btnLoginClicked)
        {
            _tbUsername = tbUsername;
            _tbPassword = tbPassword;
            _btnLoginClicked = btnLoginClicked;
            _form = new StaffRoleChooserForm();
        }

        /// <summary>
        /// Automatically fill the username and password text box in the login form and clicks
        /// the login button.
        /// </summary>
        public void Login()
        {
            _form.TitleSelected += LoginOnTitleSelected;
            _form.StartPosition = FormStartPosition.CenterScreen;
            _form.ShowDialog();
        }

        private void LoginOnTitleSelected(object sender, StaffTitle title)
        {
            string username = "";
            string password = "";
            switch (title)
            {
                case StaffTitle.Admin:
                    username = "odin";
                    password = "odin";
                    break;
                case StaffTitle.SalesRepresentative:
                    username = "homer";
                    password = "homer";
                    break;
                case StaffTitle.SalesManager:
                    username = "newton";
                    password = "newton";
                    break;
                case StaffTitle.AccountingClerk:
                    username = "saul";
                    password = "saul";
                    break;
                case StaffTitle.AccountingManager:
                    username = "doggo";
                    password = "doggo";
                    break;
                case StaffTitle.PurchaseClerk:
                    username = "walter";
                    password = "walter";
                    break;
                case StaffTitle.PurchaseManager:
                    username = "gato";
                    password = "gato";
                    break;
                case StaffTitle.InventoryClerk:
                    username = "euler";
                    password = "euler";
                    break;
                case StaffTitle.ReceivingClerk:
                    username = "joris";
                    password = "joris";
                    break;
                case StaffTitle.TechnicalSupportClerk:
                    username = "kiryu";
                    password = "kiryu";
                    break;
                case StaffTitle.TechnicalSupportManager:
                    username = "turing";
                    password = "turing";
                    break;
            }
            _tbUsername.Text = username;
            _tbPassword.Text = password;
            _btnLoginClicked.Invoke(null, EventArgs.Empty);
            _form.Close();
        }
    }
}