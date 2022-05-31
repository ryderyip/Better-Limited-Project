using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Better_Limited_Project.Tools
{
    public static class CommonInformationVerifier
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            var hkPhoneNumber = new Regex("^[0-9]{8}$");
            return hkPhoneNumber.IsMatch(phoneNumber);
        }

        public static bool IsValidEmailAddress(string emailAddress)
        {
            try
            {
                var dummy = new MailAddress(emailAddress);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }
    }
}