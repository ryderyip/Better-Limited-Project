namespace Better_Limited_Project.Login
{
    public class StaffAccount
    {
        public StaffAccount()
        {
            StaffId = "";
            Username = "";
            Password = "";
        }

        public StaffAccount(string staffId, string username, string password)
        {
            StaffId = staffId;
            Username = username;
            Password = password;
        }

        public string StaffId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Save(IStaffAccountRepository repository)
        {
            repository.InsertOrUpdate(this);
        }

        public void Remove(IStaffAccountRepository repository)
        {
            repository.Delete(this);
        }
    }
}