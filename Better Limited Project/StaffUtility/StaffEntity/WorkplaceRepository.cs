using System.Collections.Generic;
using System.Linq;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    public static class WorkplaceRepository
    {
        public static IEnumerable<IWorkplace> GetWorkplaces()
        {
            return new RetailStoreRepository().GetRetailStores().Cast<IWorkplace>()
                .Concat(WarehouseRepository.GetWarehouses());
        }
    }
}