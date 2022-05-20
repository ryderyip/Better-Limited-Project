using System.Collections.Generic;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    /// <summary>
    /// Provide functions for mapping department types to or from department names
    /// </summary>
    public static class DepartmentMapper
    {
        private const string SalesDepartment = "Sales Department";
        private const string AccountingDepartment = "Accounting Department";
        private const string PurchaseDepartment = "Purchase Department";
        private const string InventoryDepartment = "Inventory Department";
        private const string TechnicalSupportDepartment = "Technical Support Department";
        private const string Admin = "Admin";
        private const string UnknownDepartment = "Unknown";

        private static readonly Dictionary<string, Department> StringToTypeMap = new()
        {
            { SalesDepartment.ToLower(), Department.Sales },
            { AccountingDepartment.ToLower(), Department.Accounting },
            { PurchaseDepartment.ToLower(), Department.Purchase },
            { InventoryDepartment.ToLower(), Department.Inventory },
            { TechnicalSupportDepartment.ToLower(), Department.TechnicalSupport },
            { Admin.ToLower(), Department.Admin }
        };
        private static readonly Dictionary<Department, string> TypeToStringMap = new()
        {
            { Department.Sales, SalesDepartment },
            { Department.Accounting, AccountingDepartment },
            { Department.Purchase, PurchaseDepartment },
            { Department.Inventory, InventoryDepartment },
            { Department.TechnicalSupport, TechnicalSupportDepartment },
            { Department.Admin, Admin },
            { Department.Unknown, UnknownDepartment }
        };

        /// <summary>
        /// Get the department type of the provided department name. The department name is not case sensitive.
        /// </summary>
        public static Department Map(string departmentName)
        {
            departmentName = departmentName.ToLower();
            if (string.IsNullOrWhiteSpace(departmentName) || !StringToTypeMap.ContainsKey(departmentName))
                return Department.Unknown;
            
            return StringToTypeMap[departmentName];
        }

        /// <summary>
        /// Get the department name of the provided department type separated with a space
        /// </summary>
        public static string Map(Department department)
        {
            return TypeToStringMap[department];
        }
    }
}