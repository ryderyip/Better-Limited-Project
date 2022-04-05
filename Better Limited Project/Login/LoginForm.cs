using System;
using System.Windows.Forms;

namespace Better_Limited_Project.Login
{
    public partial class LoginForm : Form
    {
        public delegate void LoginClickedEventHandler<T>(object sender, T t);
        public event LoginClickedEventHandler<LoginCredentials> LoginClicked;
        
        public LoginForm()
        {
            InitializeComponent();
        }

        public void LoginFailed(LoginStatus status)
        {
            switch (status)
            {
                case LoginStatus.EmptyUsername or LoginStatus.EmptyPassword:
                    ShowFillAllFieldMessage();
                    break;
                
                case LoginStatus.WrongUsername:
                    ShowWrongUsernameMessage();
                    break;
                
                case LoginStatus.WrongPassword:
                    ShowWrongPasswordMessage();
                    break;
            }
        }

        private void ShowFillAllFieldMessage()
        {
            lblLoginFailedMessage.Visible = true;
            lblLoginFailedMessage.Text = "Please Fill In All Information";
        }
        
        private void ShowWrongUsernameMessage()
        {
            lblLoginFailedMessage.Visible = true;
            lblLoginFailedMessage.Text = "Username Not Found";
        }

        private void ShowWrongPasswordMessage()
        {
            lblLoginFailedMessage.Visible = true;
            lblLoginFailedMessage.Text = "Incorrect Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            
            LoginClicked?.Invoke(this, new LoginCredentials(username, password));
        }
    }
}
