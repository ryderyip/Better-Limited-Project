using System.Text.RegularExpressions;

namespace Better_Limited_Project.Tools
{
    public static class StringHelper
    {
        public static bool IsAlphaNumeric(string stringToCheck)
        {
            return Regex.IsMatch(stringToCheck, "^[a-zA-Z0-9_]*$");
        }
    }
}