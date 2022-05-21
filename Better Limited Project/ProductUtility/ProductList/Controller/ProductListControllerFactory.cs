using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.ProductList.Controller;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.ProductList.ProductList
{
    public static class ProductListControllerFactory
    {
        public static IProductListController Generate()
        {
            var department = StaffRepository.GetStaff(LoginSession.GetSession().StaffId).Department;

            return department switch
            {
                Department.Sales or Department.Inventory => new ProductListController(),
                Department.Admin or Department.Accounting => new ProductListControllerAll(),
                _ => throw new ArgumentException("The current staff does not have permission to view product list.")
            };
        }
    }
}