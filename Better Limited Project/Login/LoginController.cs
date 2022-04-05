namespace Better_Limited_Project.Login
{
    public class LoginController
    {
        private LoginForm _loginForm;
        
        public LoginController(LoginForm loginForm)
        {
            _loginForm = loginForm;
            loginForm.LoginClicked += OnLoginClicked;
        }

        private void OnLoginClicked(object sender, LoginCredentials credentials)
        {
            LoginStatus status = LoginVerifier.VerifyLogin(credentials);
            if (status is not LoginStatus.Successful)
            {
                _loginForm.LoginFailed(status);
                return;
            }
            
            _loginForm.Close();
            var session = CreateLoginSession(credentials.Username);
            MainController controller = new MainController();
            controller.OpenForm(session);
        }

        private LoginSession CreateLoginSession(string username)
        {
            var staffId = StaffAccountRepository.GetStaffIdByUsername(username);
            var session = new LoginSession();
            session.Staff = StaffRepository.GetStaff(staffId);
            
            // TODO set session settings
            return session;
        }
    }
}