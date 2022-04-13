using System;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;

namespace Better_Limited_Project.SettingsUtility
{
    public partial class SettingsForm : Form
    {
        private readonly UserSettings _settings;
        
        public SettingsForm(UserSettings settings)
        {
            InitializeComponent();
            _settings = settings;
            Shown += OnFormShow;
            Select();
        }

        private void OnFormShow(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            UpdateLanguageControls();
            UpdateDocumentPathControls();
        }

        private void UpdateLanguageControls()
        {
            switch (_settings.Language)
            {
                case Language.English:
                    rbEnglish.Checked = true;
                    break;
                case Language.TraditionalChinese:
                    rbTraditionalChinese.Checked = true;
                    break;
                case Language.SimplifiedChinese:
                    rbSimplifiedChinese.Checked = true;
                    break;
            }
        }

        private void UpdateDocumentPathControls()
        {
            tbDocPath.Text = _settings.DefaultDocumentGenerationDirectoryPath;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetAllChangesFromForm();
            _settings.Save();
        }

        private void GetAllChangesFromForm()
        {
            _settings.Language = GetSelectedLanguage();
            
        }

        private Language GetSelectedLanguage()
        {
            return rbEnglish.Checked ? Language.English :
                rbTraditionalChinese.Checked ? Language.TraditionalChinese :
                rbSimplifiedChinese.Checked ? Language.SimplifiedChinese :
                throw new ArgumentException("Cannot get selected language");
        }

        private void btnBrowseDocPath_Click(object sender, EventArgs e)
        {
            WindowsExplorer.OpenDirectory(_settings.DefaultDocumentGenerationDirectoryPath);
        }

        private void btnSelectDocPath_Click(object sender, EventArgs e)
        {
            string browserDescription = "Select a directory for generating documents.";
            string newPath = FolderBrowser.BrowseDirectory(Environment.SpecialFolder.MyComputer, browserDescription);
            if (newPath == string.Empty)
                return;
            
            _settings.DefaultDocumentGenerationDirectoryPath = newPath;
            UpdateDocumentPathControls();
        }
    }
}