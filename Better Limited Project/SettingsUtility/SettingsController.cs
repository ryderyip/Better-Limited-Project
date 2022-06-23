using System;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;

namespace Better_Limited_Project.SettingsUtility
{
    public class SettingsController
    {
        private readonly FormController _formController;
        private readonly UserSettings _settings;
        private readonly SettingsForm _settingsForm;

        public SettingsController(FormController formController)
        {
            _formController = formController;
            _settingsForm = new SettingsForm(LoginSession.GetSession().CurrentStaff.Department);
            _settings = UserSettings.GetSettings();

            _settingsForm.Shown += OnSettingsFormShown;
            _settingsForm.UpdateClicked += OnUpdateSettingsClicked;
            _settingsForm.BrowseDocPathClicked += OnBrowseDocPathClicked;
        }

        private void OnSettingsFormShown(object sender, EventArgs e)
        {
            _settingsForm.ShowCurrentSettings(_settings);
        }

        private void OnUpdateSettingsClicked(object sender, UserSettings newSettings)
        {
            var oldSettings = _settings;
            oldSettings.Language = newSettings.Language;
            oldSettings.Theme = newSettings.Theme;
            oldSettings.Workplace = newSettings.Workplace;
            oldSettings.DocumentGenerationDirectoryPath = newSettings.DocumentGenerationDirectoryPath;
            oldSettings.Save();
            ReOpenForm();
        }

        private void ReOpenForm()
        {
            var controller = new SettingsController(_formController);
            controller.OpenForm();
        }

        private void OnBrowseDocPathClicked(object sender, string path)
        {
            WindowsExplorer.OpenDirectory(path);
        }

        public void OpenForm()
        {
            _formController.OpenContentForm(_settingsForm);
        }
    }
}