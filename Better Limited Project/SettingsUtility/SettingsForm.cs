using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DocumentUtility;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.SettingsUtility
{
    public partial class SettingsForm : Form
    {
        private readonly List<IWorkplace> _workplaces;
        private bool _isSalesOrInventory;
        private readonly Department _staffDepartment;
        public event EventHandler<UserSettings>? UpdateClicked;
        public event EventHandler<string>? BrowseDocPathClicked;

        public SettingsForm(Department staffDepartment)
        {
            _workplaces = new RetailStoreRepository().GetAll().Cast<IWorkplace>()
                .Concat(WarehouseRepository.GetAll()).ToList();
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
            CheckCurrentLanguageRadioButton(settings.Language);
            tbDocPath.Text = settings.DocumentGenerationDirectoryPath;
            if (_staffDepartment is not (Department.Sales or Department.Inventory)) 
                return;
            
            _isSalesOrInventory = true;
            panWorkplace.Enabled = true;
            ShowLabelAccordingToWorkplace();
            FillWorkplaceComboBox();

            cbWorkplace.SelectedIndex = settings.Workplace != null
                ? cbWorkplace.FindStringExact(settings.Workplace.Name)
                : 0;
            if (cbWorkplace.SelectedIndex == -1)
                cbWorkplace.SelectedIndex = 0;
        }

        private void ShowLabelAccordingToWorkplace()
        {
            if (_staffDepartment is Department.Sales)
                lblWorkplaceSelectRetailStore.Visible = true;
            else
                lblWorkplaceSelectWarehouse.Visible = true;
        }

        private void CheckCurrentLanguageRadioButton(Language language)
        {
            if (language == Language.English)
                rbEnglish.Checked = true;
            else if (language == Language.TraditionalChinese)
                rbTraditionalChinese.Checked = true;
            else if (language == Language.SimplifiedChinese)
                rbSimplifiedChinese.Checked = true;
        }

        private void FillWorkplaceComboBox()
        {
            cbWorkplace.Items.Clear();
            List<IWorkplace> workplaces = _staffDepartment == Department.Sales
                ? _workplaces.Where(w => w is RetailStore).ToList()
                : _workplaces.Where(w => w is Warehouse).ToList();
            foreach (var workplace in workplaces)
                cbWorkplace.Items.Add(workplace.Name);
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
            settings.DocumentGenerationDirectoryPath = tbDocPath.Text;
            return settings;
        }

        private Language CollectSelectedLanguage()
        {
            return rbEnglish.Checked ? Language.English :
                rbTraditionalChinese.Checked ? Language.TraditionalChinese :
                rbSimplifiedChinese.Checked ? Language.SimplifiedChinese :
                throw new ArgumentException("Cannot get selected language");
        }

        private IWorkplace CollectSelectedWorkplace()
        {
            string selectedWorkplaceName = cbWorkplace.SelectedItem.ToString();
            return _workplaces.Find(w => w.Name == selectedWorkplaceName);
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

            tbDocPath.Text = newPath;
        }

        private void btnDefaultDocumentPath_Click(object sender, EventArgs e)
        {
            tbDocPath.Text = UserSettings.CreateDefaultSettings().DocumentGenerationDirectoryPath;
        }
    }
}