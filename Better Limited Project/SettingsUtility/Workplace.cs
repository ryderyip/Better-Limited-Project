#nullable enable
using System;
using System.Collections.Generic;

namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public class Workplace
    {
        public WorkplaceType? Type { get; set; }
        public WorkplaceInformation Information { get; set; }

        public Workplace(WorkplaceType type, string name)
        {
            Type = type;
            Information = new WorkplaceInformation(name);
        }

        public static Workplace CreateUnknownWorkplace()
        {
            return new Workplace(WorkplaceType.Unknown, "Unknown Workplace");
        }
        
        public static List<Workplace> GetWarehouses()
        {
            return WarehouseRepository.GetWarehouses();
        }

        public static List<Workplace> GetRetailStores()
        {
            return RetailStoreRepository.GetRetailStores();
        }

        public static string GetWarehouseAddress(string warehouseName)
        {
            return WarehouseRepository.GetWarehouseAddress(warehouseName);
        }

        public static string GetRetailStoreAddress(string retailStoreName)
        {
            return RetailStoreRepository.GetRetailStoreAddress(retailStoreName);
        }
    }
}