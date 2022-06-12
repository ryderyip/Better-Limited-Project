using System.Collections.Generic;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.Reordering.Controller
{
    public class ReorderService : IReorderRestockService
    {
        private readonly ReorderRequest _reorderRequest;
        private readonly List<IProductQuantity> _requestedProducts;

        /// <summary>
        /// Initialize a <see cref="ReorderRequest"/> instance.
        /// </summary>
        public ReorderService()
        {
            _reorderRequest = new ReorderRequest(UserSettings.GetSettings().Workplace!.Id,
                LoginSession.GetSession().CurrentStaff.Id);
            _requestedProducts = new List<IProductQuantity>();
        }
        
        public void AddRange(IEnumerable<IProductQuantity> productQuantities)
        {
            _requestedProducts.AddRange(productQuantities);
        }
        
        /// <summary>
        /// Creates a reorder request record and requested product records.
        /// </summary>
        public void Submit()
        {
            if (_requestedProducts.Count == 0)
                return;
            _reorderRequest.Save();
            _requestedProducts.ForEach(rp =>
                new ReorderRequestProduct(_reorderRequest.Id, rp.ProductId, rp.Quantity).Save());
        }
    }
}