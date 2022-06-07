using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;

#nullable enable
namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    [Serializable]
    public class RetailStore : IWorkplace, IEntity
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

        public IStock GetProductStock(string productId)
        {
            return StockRepository.FindByIds(Id, productId);
        }
        
        public IEnumerable<IStock> GetProductStocks()
        {
            return StockRepository.GetRetailStoreStocks(Id);
        }
    }
}