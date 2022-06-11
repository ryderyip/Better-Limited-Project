using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Procedure
{
    public partial class WorkplacePickerForm : Form
    {
        private readonly List<IWorkplace> _workplaces;
        public IWorkplace? SelectedWorkplace { get; private set; }

        public WorkplacePickerForm()
        {
            var department = LoginSession.GetSession().CurrentStaff.Department;
            _workplaces = department is Department.Sales 
                ? new RetailStoreRepository().GetAll().Cast<IWorkplace>().ToList()
                : WarehouseRepository.GetAll().Cast<IWorkplace>().ToList();
            
            if (department is not Department.Sales and not Department.Inventory)
                return;
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Load += (_, _) =>
            {
                _workplaces.ForEach(w => cbWorkplace.Items.Add(w.Name));
                cbWorkplace.SelectedIndex = 0;
            };
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedWorkplace = _workplaces[cbWorkplace.SelectedIndex];
            Close();
        }
    }
}
