using System.Linq;

namespace Better_Limited_Project.Login
{
    public class StaffAccount
    {
        public StaffAccount(string staffId, string username, string password)
        {
            StaffId = staffId;
            Username = username;
            Password = password;
        }

        public string StaffId { get; }
        public string Username { get; }
        public string Password { get; }

        public void Save()
        {
            if (StaffAccountRepository.GetAll().All(ac => ac.StaffId != StaffId))
                StaffAccountRepository.CreateAccount(this);
        }
    }
}