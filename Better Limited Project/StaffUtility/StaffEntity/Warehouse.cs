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
        public Warehouse(string id, string abbreviation, string name, string address)
        {
            Id = id;
            Abbreviation = abbreviation;
            Name = name;
            Address = address;
        }

        public string Abbreviation { get; }
        public string Id { get; }
        public string Name { get; }
        public string Address { get; }

        public IStock GetProductStock(string productId)
        {
            return StockRepository.FindByIds(Id, productId);
        }

        public IEnumerable<IStock> GetProductStocks()
        {
            return StockRepository.GetWarehouseStocks(Id);
        }
    }
}