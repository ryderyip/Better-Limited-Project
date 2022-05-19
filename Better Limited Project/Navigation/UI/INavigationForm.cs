using System;

namespace Better_Limited_Project.Navigation.UI
{
    public interface INavigationForm
    {
        public delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        public event LogOutClickedEventHandler? LogOutClicked;
    }
}