using System.Collections.Generic;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class RestockService : IReorderRestockService
    {
        private readonly RestockRequest _restockRequest;
        private readonly List<IProductQuantity> _requestedProducts;

        public RestockService()
        {
            _restockRequest = new RestockRequest(UserSettings.GetSettings().Workplace!.Id,
                LoginSession.GetSession().CurrentStaff.Id);
            _requestedProducts = new List<IProductQuantity>();
        }

        public void Submit()
        {
            if (_requestedProducts.Count == 0)
                return;
            _restockRequest.Save();
            _requestedProducts.ForEach(rp =>
                new RestockRequestProduct(_restockRequest.Id, rp.ProductId, rp.Quantity).Save());
        }

        public void AddRange(IEnumerable<IProductQuantity> productQuantities)
        {
            _requestedProducts.AddRange(productQuantities);
        }
    }
}