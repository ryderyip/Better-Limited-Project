using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.Procedure
{
    public class LoginProcedure : IProcedure<string>
    {
        private readonly FormController _formController;

        public LoginProcedure(FormController formController)
        {
            _formController = formController;
        }

        public event IProcedure<string>.FinishedEventHandler<string>? Finished;

        public void Start()
        {
            LanguageController.SetSystemLanguage(UserSettings.GetSettings().Language);
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            var lastLoginUsername = UserSettings.GetSettings().LastLoginUsername;
            LoginController loginController = lastLoginUsername == null
                ? new LoginController()
                : new LoginController(lastLoginUsername);
            loginController.LoggedIn += (_, staffId) => Finished?.Invoke(this, staffId);
            loginController.OpenForm(_formController);
        }
    }
}