using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ServiceUtility.InstallationUtility.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class TechnicalSupportNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;

        public TechnicalSupportNavigationForm(FormController formController)
        {
            _formController = formController;
            Shown += (_, _) => btnProfile.Text = LoginSession.GetSession().CurrentStaff.Name;
            InitializeComponent();
        }

        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_formController);
            controller.OpenForm();
        }

        private void btnInstallationDuty_Click(object sender, EventArgs e)
        {
            var form = new InstallationListForm();
            _formController.OpenContentForm(form);
        }

        private void btnInstallationRequests_Click(object sender, EventArgs e)
        {
            var form = new InstallationRequestListForm();
            _formController.OpenContentForm(form);
        }

        private void btnTechnician_Click(object sender, EventArgs e)
        {
            var form = new TechnicianListForm();
            _formController.OpenContentForm(form);
        }
    }
}