using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.Repository
{
    public static class WorkplaceRepository
    {
        public static IEnumerable<IWorkplace> GetWorkplaces()
        {
            return new RetailStoreRepository().GetAll().Cast<IWorkplace>()
                .Concat(WarehouseRepository.GetAll());
        }
    }
}