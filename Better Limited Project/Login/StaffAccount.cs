using System.Collections.Generic;

namespace Better_Limited_Project.Login
{
    public class StaffAccount
    {
        public string StaffId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            return Username == ((StaffAccount) obj)?.Username;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}