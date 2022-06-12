using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Reordering;
using Better_Limited_Project.ProductUtility.Reordering.Entity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public interface IReorderRestockService
    {
        void Submit();
        void AddRange(IEnumerable<IProductQuantity> productQuantities);
    }
}