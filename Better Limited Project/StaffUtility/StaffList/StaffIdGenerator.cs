using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public class StaffIdGenerator
    {
        private readonly List<Staff> _staffs;

        public StaffIdGenerator()
        {
            _staffs = StaffRepository.GetStaffs().ToList();
        }

        public string Generate(Department department)
        {
            string departmentAcronym = GetDepartmentAcronym(department);
            var staffOfDepartment = _staffs.Where(staff => staff.Id.Contains(departmentAcronym));
            return departmentAcronym +
                   (staffOfDepartment.Count() + 1).ToString().PadLeft(4, '0');
        }

        private string GetDepartmentAcronym(Department department)
        {
            return department switch
            {
                Department.Admin => "A",
                Department.Sales => "SD",
                Department.Accounting => "AD",
                Department.Purchase => "PD",
                Department.Inventory => "ID",
                Department.TechnicalSupport => "TSD",
                _ => throw new ArgumentException($"Unknown department \"{department.ToString()}\"")
            };
        }
    }
}