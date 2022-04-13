using System.Windows.Forms;
using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.SettingsUtility
{
    public class SettingsController
    {
        private readonly SettingsForm _settingsForm;

        public SettingsController()
        {
            _settingsForm = new SettingsForm(UserSettings.GetSettings());
        }

        public void OpenForm(FormController formController)
        {
            formController.OpenContentForm(_settingsForm);
        }
    }
}