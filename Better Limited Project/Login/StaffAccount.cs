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
        public string Username { get; set; }
        public string Password { get; set; }

        public void Save()
        {
            StaffAccountRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            StaffAccountRepository.Delete(this);
        }
    }
}