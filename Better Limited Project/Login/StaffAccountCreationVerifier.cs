using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Login
{
    public class StaffAccountCreationVerifier
    {
        private readonly List<StaffAccount> _accounts;

        public StaffAccountCreationVerifier(IStaffAccountRepository repository)
        {
            _accounts = repository.GetAll().ToList();
        }

        public bool IsUsernameValid(string username)
        {
            return username.Length >= 4 && StringHelper.IsAlphaNumericPlusUnderscore(username);
        }

        public bool IsUsernameUnique(string username)
        {
            return _accounts.All(acc => acc.Username != username);
        }

        public bool IsPasswordValid(string password)
        {
            return password.Length >= 8 && StringHelper.IsAlphaNumericPlusUnderscore(password);
        }
    }
}