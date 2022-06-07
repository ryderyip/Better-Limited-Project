using System;
using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class Warehouse : IWorkplace
    {
        public string Id { get; }
        public string Name { get; }
        public string? Address { get; }
        
        public IStock GetProductStock(string productId)
        {
            return StockRepository.FindByIds(Id, productId);
        }

        public IEnumerable<IStock> GetProductStocks()
        {
            return StockRepository.GetWarehouseStocks(Id);
        }

        public Warehouse(string id, string name, string? address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}