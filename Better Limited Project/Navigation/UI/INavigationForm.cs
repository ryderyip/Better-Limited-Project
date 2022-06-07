using System;

namespace Better_Limited_Project.Navigation.UI
{
    public interface INavigationForm
    {
        delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        event LogOutClickedEventHandler? LogOutClicked;
    }
}