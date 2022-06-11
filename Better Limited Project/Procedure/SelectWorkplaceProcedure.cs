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
            while (true) {
                form.ShowDialog();
                if (form.SelectedWorkplace != null)
                    break;
            }

            SetWorkplace(form.SelectedWorkplace);
        }

        private bool NeedToSelectWorkplace()
        {
            var workplace = UserSettings.GetSettings().Workplace;
            if (workplace == null)
                return true;
            var department = LoginSession.GetSession().CurrentStaff.Department;
            
            return department switch
            {
                Department.Sales => workplace is not RetailStore,
                Department.Inventory => workplace is not Warehouse,
                _ => false
            };
        }

        private void SetWorkplace(IWorkplace workplace)
        {
            var settings = UserSettings.GetSettings();
            settings.Workplace = workplace;
            settings.Save();
        }
    }
}