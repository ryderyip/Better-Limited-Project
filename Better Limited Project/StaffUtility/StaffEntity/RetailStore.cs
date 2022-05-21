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
        public string Id { get; }
        public string Name { get; }
        public string Address { get; }

        public RetailStore(string id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public void UpdateSellingPrice(string productId, decimal sellingPrice)
        {
            StockRepository.UpdateProductInfo(Id, productId, sellingPrice);
        }
    }
}