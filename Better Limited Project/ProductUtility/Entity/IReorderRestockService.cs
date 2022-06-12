using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Reordering;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public interface IReorderRestockService
    {
        void Submit();
        void AddRange(IEnumerable<IProductQuantity> productQuantities);
    }
}