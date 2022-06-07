using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public interface IWorkplace
    {
        string Id { get; }
        string Name { get; }
        string Address { get; }
        IStock GetProductStock(string productId);
        IEnumerable<IStock> GetProductStocks();
    }
}