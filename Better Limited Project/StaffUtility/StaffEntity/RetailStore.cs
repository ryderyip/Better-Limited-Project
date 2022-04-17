using System;
using System.Collections.Generic;
using Better_Limited_Project.ProductUtility;
using Better_Limited_Project.ProductUtility.Entity;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class RetailStore : IWorkplace
    {
        public string Name { get; }
        public string? Address { get; }

        public RetailStore(string name, string? address)
        {
            Name = name;
            Address = address;
        }

        public List<ProductQuantity> GetStock()
        {
            return StockRepository.GetStock(Name);
        }
    }
}