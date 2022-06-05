using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffList
{
    public class StaffNumberGenerator
    {
        private readonly List<Staff> _staffs;

        public StaffNumberGenerator()
        {
            _staffs = new StaffRepository().GetAll().ToList();
        }

        public string Generate(Department department)
        {
            string departmentAcronym = GetDepartmentAcronym(department);
            var staffsOfDepartment = department is Department.Admin
                ? _staffs.Where(staff => staff.Department is Department.Admin).ToList()
                : _staffs.Where(staff => staff.Id.Contains(departmentAcronym)).ToList();

            string id = departmentAcronym +
                        (staffsOfDepartment.Count + 1).ToString().PadLeft(4, '0');

            int increment = 2;
            while (IsIdUsed(id))
                id = departmentAcronym +
                     (staffsOfDepartment.Count + increment++).ToString().PadLeft(4, '0');
            return id;
        }

        private bool IsIdUsed(string id)
        {
            return _staffs.Any(staff => staff.Id == id);
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