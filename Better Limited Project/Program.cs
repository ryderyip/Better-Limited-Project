using System;
using System.Windows.Forms;
using Better_Limited_Project.DataAnalytics;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ServieUtility.Installation;
using Better_Limited_Project.ServieUtility.Reordering;

namespace Better_Limited_Project
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            var mainController = new MainController(mainForm);

            Application.Run(mainForm);
        }
    }
}
