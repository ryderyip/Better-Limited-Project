using System;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.SupplierUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffList;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class AdminNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        private readonly Staff _staff;

        public AdminNavigationForm(FormController formController, Staff staff)
        {
            _formController = formController;
            _staff = staff;
            Shown += (_, _) => btnProfile.Text = "ADMIN\n" + staff.Name;
            InitializeComponent();
        }

        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm(_staff);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_staff);
            controller.OpenForm(_formController);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            var form = new ProductListForm();
            _formController.OpenContentForm(form);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var controller = new StaffListController();
            controller.OpenForm(_formController);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerListForm();
            _formController.OpenContentForm(form);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            var form = new SupplierListForm();
            _formController.OpenContentForm(form);
        }
    }
}