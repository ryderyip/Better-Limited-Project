using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public interface IWorkplace
    {
        public string Name { get; }
        public string? Address { get; }

        public List<ProductQuantity> GetStock();
    }
}