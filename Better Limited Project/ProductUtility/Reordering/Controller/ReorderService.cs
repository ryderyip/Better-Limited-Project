using System.Collections.Generic;
using Better_Limited_Project.Login;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public class ReorderService
    {
        private readonly ReorderRequest _reorderRequest;
        private readonly List<IProductQuantity> _requestedProducts;

        /// <summary>
        /// Initialize a <see cref="ReorderRequest"/> instance.
        /// </summary>
        /// <param name="productQuantities">Products to reorder</param>
        public ReorderService(IEnumerable<IProductQuantity>? productQuantities = null)
        {
            _reorderRequest = new ReorderRequest(UserSettings.GetSettings().Workplace!.Id,
                LoginSession.GetSession().CurrentStaff.Id);
            _requestedProducts = productQuantities != null
                ? new List<IProductQuantity>(productQuantities)
                : new List<IProductQuantity>();
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