using System.Windows.Forms;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.FormControlling
{
    public class FormController
    {
        private readonly UserSettings _settings;
        private readonly MainForm _mainForm;

        public FormController(UserSettings settings, MainForm mainForm)
        {
            _settings = settings;
            _mainForm = mainForm;
            _mainForm.IsMdiContainer = true;
        }

        public void OpenForm(Form subform, DockStyle dockStyle)
        {
            subform.MdiParent = _mainForm;
            subform.Dock = dockStyle;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Show();
            
            // TODO Set language and theme
        }
    }
}