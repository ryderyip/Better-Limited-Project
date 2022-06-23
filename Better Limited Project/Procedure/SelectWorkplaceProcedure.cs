using Better_Limited_Project.Login;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Procedure
{
    public class SelectWorkplaceProcedure
    {
        public void Start()
        {
            if (!NeedToSelectWorkplace())
                return;
            var form = new WorkplacePickerForm();
            while (true)
            {
                form.ShowDialog();
                if (form.SelectedWorkplace != null)
                    break;
            }

            SetWorkplace(form.SelectedWorkplace);
        }

        private bool NeedToSelectWorkplace()
        {
            var workplace = UserSettings.GetSettings().Workplace;
            var department = LoginSession.GetSession().CurrentStaff.Department;

            if (department is not Department.Sales && department is not Department.Inventory)
                return false;

            return department == Department.Sales
                ? workplace is not RetailStore
                : workplace is not Warehouse;
        }

        private void SetWorkplace(IWorkplace workplace)
        {
            var settings = UserSettings.GetSettings();
            settings.Workplace = workplace;
            settings.Save();
        }
    }
}