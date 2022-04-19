using System;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.SettingsUtility
{
    public class SettingsController
    {
        private readonly SettingsForm _settingsForm;
        private readonly UserSettings _settings;

        public SettingsController(Staff staff)
        {
            _settingsForm = new SettingsForm(staff.Department);
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
            oldSettings.DefaultDocumentGenerationDirectoryPath = newSettings.DefaultDocumentGenerationDirectoryPath;
            oldSettings.Save();
        }

        private void OnBrowseDocPathClicked(object sender, string path)
        {
            WindowsExplorer.OpenDirectory(path);
        }
        
        public void OpenForm(FormController formController)
        {
            formController.OpenContentForm(_settingsForm);
        }
    }
}