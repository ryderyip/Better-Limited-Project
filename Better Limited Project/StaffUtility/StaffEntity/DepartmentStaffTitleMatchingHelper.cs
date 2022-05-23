using System;
using System.Collections.Generic;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public class DepartmentStaffTitleMatchingHelper
    {
        public List<StaffTitle> GetTitlesUnderDepartment(Department department)
        {
            return department switch
            {
                Department.Admin => new List<StaffTitle> 
                    {StaffTitle.Admin},
                Department.Sales => new List<StaffTitle> 
                    {StaffTitle.SalesRepresentative, StaffTitle.AccountingManager},
                Department.Accounting => new List<StaffTitle>
                    {StaffTitle.AccountingClerk, StaffTitle.AccountingManager},
                Department.Purchase => new List<StaffTitle> 
                    {StaffTitle.PurchaseClerk, StaffTitle.PurchaseManager},
                Department.Inventory => new List<StaffTitle> 
                    {StaffTitle.InventoryClerk, StaffTitle.ReceivingClerk},
                Department.TechnicalSupport => new List<StaffTitle>
                    {StaffTitle.TechnicalSupportClerk, StaffTitle.TechnicalSupportManager},
                _ => throw new ArgumentException($"Department \"{department}\" does not exist.")
            };
        }

        public Department GetDepartmentOverTitle(StaffTitle title)
        {
            return title switch
            {
                StaffTitle.Admin => Department.Admin,
                StaffTitle.SalesRepresentative or StaffTitle.SalesManager => Department.Sales,
                StaffTitle.AccountingClerk or StaffTitle.AccountingManager => Department.Accounting,
                StaffTitle.PurchaseClerk or StaffTitle.PurchaseManager => Department.Purchase,
                StaffTitle.InventoryClerk or StaffTitle.ReceivingClerk => Department.Inventory,
                StaffTitle.TechnicalSupportClerk or StaffTitle.TechnicalSupportManager => Department.TechnicalSupport,
                _ => throw new ArgumentException($"Staff title \"{title}\" does not exist.")
            };
        }
    }
}