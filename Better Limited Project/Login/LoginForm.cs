using System;
using System.Windows.Forms;
using Better_Limited_Project.DevTools.AutoLogin;
using Better_Limited_Project.Properties;

namespace Better_Limited_Project.Login
{
    public partial class LoginForm : Form
    {
        public delegate void LoginClickedEventHandler<T>(object sender, T t);

        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Shown += (_, _) => Initialize();
        }

        public event LoginClickedEventHandler<LoginCredentials>? LoginClicked;

        private void Initialize()
        {
            pbLogo.Image = Resources.BL_Logo_Rectangle;
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            // AutoLogin();
        }

        private void AutoLogin()
        {
            var helper = new AutoLoginHelper(tbUsername, tbPassword, btnLogin_Click);
            helper.Login();
        }

        public void LoginFailed(LoginStatus status)
        {
            switch (status)
            {
                case LoginStatus.EmptyUsername or LoginStatus.EmptyPassword:
                    ShowFillAllFieldMessage();
                    break;

                case LoginStatus.WrongUsernameOrPassword:
                    ShowWrongUsernameOrPasswordMessage();
                    break;
            }
        }

        public void FillLastLoginUsername(string username)
        {
            tbUsername.Text = username;
            tbUsername.SelectionStart = tbUsername.Text.Length;
        }

        private void ShowFillAllFieldMessage()
        {
            lblLoginFailedMessage.Visible = true;
            lblLoginFailedMessage.Text = "Please enter both username and password";
        }

        private void ShowWrongUsernameOrPasswordMessage()
        {
            lblLoginFailedMessage.Visible = true;
            lblLoginFailedMessage.Text = "Username or password incorrect";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            LoginClicked?.Invoke(this, new LoginCredentials(username, password));
        }
    }
}