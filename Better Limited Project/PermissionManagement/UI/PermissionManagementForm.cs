using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.PermissionManagement.Controller;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.PermissionManagement.Repository;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.PermissionManagement.UI
{
    public partial class PermissionManagementForm : Form
    {
        private readonly List<StaffTitle> _staffTitles;
        private readonly List<IPermission> _permissions;

        public PermissionManagementForm()
        {
            _permissions = PermissionRepository.GetAll().ToList();
            _staffTitles = StaffTitleRepository.GetAll().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            btnDiscardChanges.Click += (_, _) => DiscardChanges();
            btnSave.Click += (_, _) => SaveChanges();
            btnSave.Visible = btnDiscardChanges.Visible = false;
            _permissions.ForEach(p => cbPermissions.Items.Add(p.Name));
            cbPermissions.SelectedIndexChanged += (_, _) => FillFields();
            cblPermittedStaffTitles.CheckOnClick = true;
            btnSave.Click += (_, _) => SetButtonVisibility();
            cblPermittedStaffTitles.ItemCheck += (_, _) =>
                BeginInvoke((MethodInvoker) SetButtonVisibility);
            cbPermissions.SelectedIndex = 0;
            PopulatePermittedStaffTitlesCbl();
        }

        private void SetButtonVisibility()
        {
            btnSave.Visible = btnDiscardChanges.Visible = IsCheckedItemsDifferentFromOriginal();
        }

        private void SaveChanges()
        {
            var service = new UpdatePermissionService(GetSelectedPermission());
            service.Update(GetCheckedStaffTitles());
            PopulatePermittedStaffTitlesCbl();
        }

        private IEnumerable<StaffTitle> GetCheckedStaffTitles()
        {
            var map = new StaffTitleMapper();
            return from string checkedStaffTitle in cblPermittedStaffTitles.CheckedItems
                select map.Map(checkedStaffTitle);
        }

        private void DiscardChanges()
        {
            Initialize();
        }

        private bool IsCheckedItemsDifferentFromOriginal()
        {
            var permittedStaffTitles = GetSelectedPermission().PermittedStaffTitles().ToList();
            var map = new StaffTitleMapper();
            return cblPermittedStaffTitles.CheckedItems.Count != permittedStaffTitles.Count
                   || cblPermittedStaffTitles.CheckedItems.Cast<string>().Any(item =>
                       !permittedStaffTitles.Exists(pst => map.Map(pst) == item));
        }

        private void FillFields()
        {
            var permission = GetSelectedPermission();
            tbPermissionName.Text = permission.Name;
            tbPermissionDescription.Text = permission.Description;
            PopulatePermittedStaffTitlesCbl();
        }

        private void PopulatePermittedStaffTitlesCbl()
        {
            cblPermittedStaffTitles.Items.Clear();
            var map = new StaffTitleMapper();
            var permittedStaffTitles = GetSelectedPermission().PermittedStaffTitles().ToList();
            foreach (var staffTitle in _staffTitles)
                cblPermittedStaffTitles.Items.Add(map.Map(staffTitle),
                    permittedStaffTitles.Any(pst => staffTitle == pst));
        }

        private IPermission GetSelectedPermission()
        {
            return _permissions.Find(p => p.Name == cbPermissions.SelectedItem.ToString());
        }
    }
}