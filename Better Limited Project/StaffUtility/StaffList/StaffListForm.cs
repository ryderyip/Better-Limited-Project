using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public partial class StaffListForm : Form
    {
        private List<Staff> _staffs;

        public StaffListForm(IEnumerable<Staff> staffs)
        {
            _staffs = staffs.ToList();
            InitializeComponent();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            InitializeDgvStaff();
            PopulateDgvStaff(_staffs);
        }

        private void InitializeDgvStaff()
        {
            dgvStaff.Columns.Add("id", "ID");
            dgvStaff.Columns.Add("name", "Name");
            dgvStaff.Columns.Add("gender", "Gender");
            dgvStaff.Columns.Add("department", "Department");
            dgvStaff.Columns.Add("title", "Title");
        }

        private void PopulateDgvStaff(List<Staff> staffs)
        {
            dgvStaff.Rows.Clear();
            var mapper = new StaffTitleMapper();
            staffs.ForEach(staff => dgvStaff.Rows.Add(
                staff.Id, staff.Name, staff.Gender,
                DepartmentMapper.Map(staff.Department), mapper.Map(staff.Title)));
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = tbSearch.Text;

            var filteredStaff = StringHelper.IsAlphaNumeric(keywords)
                ? from staff in _staffs
                where staff.Name.ToLower().Contains(keywords.ToLower())
                      || staff.Id.ToLower().Contains(keywords.ToLower())
                select staff
                : from staff in _staffs
                where staff.Name.Contains(keywords)
                      || staff.Id.Contains(keywords)
                select staff;

            PopulateDgvStaff(filteredStaff.ToList());
        }

        private void ReloadStaffList()
        {
            tbSearch.Text = string.Empty;
            _staffs = StaffRepository.GetStaffs().ToList();
            PopulateDgvStaff(_staffs);
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            var form = new NewStaffForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.StaffAdded += (_, _) => ReloadStaffList();
            form.ShowDialog();
        }
    }
}