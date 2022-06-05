using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.Repository;
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
            var account = title switch
            {
                StaffTitle.Admin => new StaffRepository().FindAll(s => s.Title == StaffTitle.Admin).First()
                    .GetLoginAccount(),
                StaffTitle.SalesRepresentative => new StaffRepository()
                    .FindAll(s => s.Title == StaffTitle.SalesRepresentative).First().GetLoginAccount(),
                StaffTitle.SalesManager => new StaffRepository().FindAll(s => s.Title == StaffTitle.SalesManager)
                    .First().GetLoginAccount(),
                StaffTitle.PurchaseClerk => new StaffRepository().FindAll(s => s.Title == StaffTitle.PurchaseClerk)
                    .First().GetLoginAccount(),
                StaffTitle.PurchaseManager => new StaffRepository().FindAll(s => s.Title == StaffTitle.PurchaseManager)
                    .First().GetLoginAccount(),
                StaffTitle.AccountingClerk => new StaffRepository().FindAll(s => s.Title == StaffTitle.AccountingClerk)
                    .First().GetLoginAccount(),
                StaffTitle.AccountingManager => new StaffRepository()
                    .FindAll(s => s.Title == StaffTitle.AccountingManager).First().GetLoginAccount(),
                StaffTitle.InventoryClerk => new StaffRepository().FindAll(s => s.Title == StaffTitle.InventoryClerk)
                    .First().GetLoginAccount(),
                StaffTitle.ReceivingClerk => new StaffRepository().FindAll(s => s.Title == StaffTitle.ReceivingClerk)
                    .First().GetLoginAccount(),
                StaffTitle.TechnicalSupportClerk => new StaffRepository()
                    .FindAll(s => s.Title == StaffTitle.TechnicalSupportClerk).First().GetLoginAccount(),
                StaffTitle.TechnicalSupportManager => new StaffRepository()
                    .FindAll(s => s.Title == StaffTitle.TechnicalSupportManager).First().GetLoginAccount()
            };
            _tbUsername.Text = account.Username;
            _tbPassword.Text = account.Password;
            _btnLoginClicked.Invoke(null, EventArgs.Empty);
            _form.Close();
        }
    }
}