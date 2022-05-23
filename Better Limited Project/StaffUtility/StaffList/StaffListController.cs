using System.Collections.Generic;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public class StaffListController
    {
        private readonly StaffListForm _form;
        
        public StaffListController()
        {
            _form = new StaffListForm(GetStaffs());
        }

        public void OpenForm(FormController formController)
        {
            formController.OpenContentForm(_form);
        }
        
        private IEnumerable<Staff> GetStaffs()
        {
            return StaffRepository.GetStaffs();
        }
    }
}