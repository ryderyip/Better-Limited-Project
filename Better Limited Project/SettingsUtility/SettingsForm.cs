using System;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.SettingsUtility
{
    public partial class SettingsForm : Form
    {
        private bool _isSalesOrInventory;
        private readonly Department _staffDepartment;
        public delegate void ButtonClickedEventHandler<T>(object sender, T eventArgs);
        public event ButtonClickedEventHandler<UserSettings> UpdateClicked;
        public event ButtonClickedEventHandler<string> BrowseDocPathClicked;

        public SettingsForm(Department staffDepartment)
        {
            _staffDepartment = staffDepartment;
            InitializeComponent();
            ScrollPageToTop();
        }

        private void ScrollPageToTop()
        {
            Select();
        }

        public void ShowCurrentSettings(UserSettings settings)
        {
            ShowCurrentLanguage(settings.Language);
            ShowCurrentDocumentPath(settings.DefaultDocumentGenerationDirectoryPath);
            if (_staffDepartment is Department.Sales or Department.Inventory)
            {
                _isSalesOrInventory = true;
                EnableWorkplacePanel();
                FillWorkplaceComboBox();

                if (settings.Workplace != null) 
                    SelectCurrentWorkplaceInComboBox(settings.Workplace.Information.Name);
            }
        }

        private void ShowCurrentLanguage(Language language)
        {
            if (language == Language.English)
                rbEnglish.Checked = true;
            else if (language == Language.TraditionalChinese)
                rbTraditionalChinese.Checked = true;
            else if (language == Language.SimplifiedChinese) 
                rbSimplifiedChinese.Checked = true;
        }

        private void ShowCurrentDocumentPath(string documentGenerationPath)
        {
            tbDocPath.Text = documentGenerationPath;
        }
        
        private void EnableWorkplacePanel()
        {
            panWorkplace.Enabled = true;
        }

        private void FillWorkplaceComboBox()
        {
            cbWorkplace.Items.Clear();
            var workplaces = _staffDepartment == Department.Sales
                ? Workplace.GetRetailStores()
                : Workplace.GetWarehouses();
            foreach (var warehouse in workplaces)
                cbWorkplace.Items.Add(warehouse.Information.Name);
        }

        private void SelectCurrentWorkplaceInComboBox(string currentWorkplaceName)
        {
            if (cbWorkplace.Items.Count == 0)
                return;

            cbWorkplace.SelectedIndex = cbWorkplace.FindStringExact(currentWorkplaceName);
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var newSettings = CollectSettings();
            UpdateClicked?.Invoke(this, newSettings);
        }

        private UserSettings CollectSettings()
        {
            var settings = new UserSettings();
            settings.Language = CollectSelectedLanguage();
            if (_isSalesOrInventory)
                settings.Workplace = CollectSelectedWorkplace();
            return settings;
        }

        private Language CollectSelectedLanguage()
        {
            return rbEnglish.Checked ? Language.English :
                rbTraditionalChinese.Checked ? Language.TraditionalChinese :
                rbSimplifiedChinese.Checked ? Language.SimplifiedChinese :
                throw new ArgumentException("Cannot get selected language");
        }

        private Workplace CollectSelectedWorkplace()
        {
            return _staffDepartment == Department.Sales ? 
                new Workplace(WorkplaceType.RetailStore, cbWorkplace.SelectedItem.ToString()) :
                new Workplace(WorkplaceType.Warehouse, cbWorkplace.SelectedItem.ToString());
        }

        private void btnBrowseDocPath_Click(object sender, EventArgs e)
        {
            BrowseDocPathClicked?.Invoke(this, tbDocPath.Text);
        }

        private void btnSelectDocPath_Click(object sender, EventArgs e)
        {
            string browserDescription = "Select a directory for generating documents.";
            string newPath = FolderBrowser.BrowseDirectory(Environment.SpecialFolder.MyComputer, browserDescription);
            if (newPath == string.Empty)
                return;

            ShowCurrentDocumentPath(newPath);
        }
    }
}