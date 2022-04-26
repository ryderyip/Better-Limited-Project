using System;
using System.Collections.Generic;
using Better_Limited_Project.ProductUtility;
using Better_Limited_Project.ProductUtility.Entity;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class Warehouse : IWorkplace
    {
        public string Id { get; }
        public string Name { get; }
        public string? Address { get; }

        public Warehouse(string id, string name, string? address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        
        public List<ProductQuantity> GetStock()
        {
            return StockRepository.GetWarehouseStock(Id);
            // TODO need to separate retail store stock repo and warehouse stock repo
        }
    }
}