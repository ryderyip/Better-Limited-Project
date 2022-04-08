using System;
using System.Windows.Forms;

namespace Better_Limited_Project.DevTools
{
    /// <summary>
    /// Only for facilitating login progress
    /// </summary>
    public static class AutoLoginHelper
    {
        private const string Username = "issac";
        private const string Password = "newton";
        
        /// <summary>
        /// Automatically fill the username and password text box in the login form and clicks
        /// the login button.
        /// </summary>
        public static void Login(TextBox tbUsername, TextBox tbPassword, Action<object, EventArgs> btnLoginClicked)
        {
            tbUsername.Text = Username;
            tbPassword.Text = Password;
            btnLoginClicked.Invoke(null, EventArgs.Empty);
        }
    }
}