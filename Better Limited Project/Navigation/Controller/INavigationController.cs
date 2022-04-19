using System;

namespace Better_Limited_Project.Navigation.Controller
{
    public interface INavigationController
    {
        public delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        public event LogOutClickedEventHandler LogOutClicked;
        
        void OpenForm();

        void CloseForm();
    }
}