using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord.CustomerInformationValidation
{
    public static class CustomerInformationValidator
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            var hkPhoneNumberWithHyphen = new Regex("^852-[0-9]{8}$");
            var hkPhoneNumber = new Regex("^[0-9]{8}$");

            return hkPhoneNumber.IsMatch(phoneNumber)
                   || hkPhoneNumberWithHyphen.IsMatch(phoneNumber);
        }

        public static bool IsValidEmailAddress(string emailAddress)
        {
            try
            {
                var mailAddress = new MailAddress(emailAddress);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }
    }
}