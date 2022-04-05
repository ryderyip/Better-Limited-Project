using System.Linq;

namespace Better_Limited_Project.Login
{
    public static class LoginVerifier
    {
        public static LoginStatus VerifyLogin(LoginCredentials credentials)
        {
            string username = credentials.Username;
            string password = credentials.Password;

            if (IsEmptyUsername(username))
                return LoginStatus.EmptyUsername;
            if (IsEmptyPassword(password))
                return LoginStatus.EmptyPassword;

            var account = FindAccount(username);
            if (account == null)
                return LoginStatus.WrongUsername;

            if (IsWrongPassword(password, account.Password))
                return LoginStatus.WrongPassword;

            return LoginStatus.Successful;
        }

        private static bool IsEmptyUsername(string username)
        {
            return string.IsNullOrWhiteSpace(username);
        }

        private static bool IsEmptyPassword(string password)
        {
            return string.IsNullOrWhiteSpace(password);
        }

        private static StaffAccount FindAccount(string username)
        {
            var accounts = StaffAccountRepository.GetStaffAccounts();
            return accounts.FirstOrDefault(account => Equals(account, new StaffAccount {Username = username}));
        }

        private static bool IsWrongPassword(string enteredPassword, string accountPassword)
        {
            return enteredPassword != accountPassword;
        }
    }
}