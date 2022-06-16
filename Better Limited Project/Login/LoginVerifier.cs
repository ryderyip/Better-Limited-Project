namespace Better_Limited_Project.Login
{
    public class LoginVerifier
    {
        private readonly IStaffAccountRepository _repository;

        public LoginVerifier(IStaffAccountRepository repository)
        {
            _repository = repository;
        }

        public LoginStatus VerifyLogin(LoginCredentials credentials)
        {
            string username = credentials.Username;
            string password = credentials.Password;

            if (IsEmptyUsername(username))
                return LoginStatus.EmptyUsername;
            if (IsEmptyPassword(password))
                return LoginStatus.EmptyPassword;

            var account = _repository.FindByKey(username);
            if (account == null || IsWrongPassword(password, account.Password))
                return LoginStatus.WrongUsernameOrPassword;

            return LoginStatus.Successful;
        }

        private bool IsEmptyUsername(string username)
        {
            return string.IsNullOrWhiteSpace(username);
        }

        private bool IsEmptyPassword(string password)
        {
            return string.IsNullOrWhiteSpace(password);
        }

        private bool IsWrongPassword(string enteredPassword, string accountPassword)
        {
            return enteredPassword != accountPassword;
        }
    }
}