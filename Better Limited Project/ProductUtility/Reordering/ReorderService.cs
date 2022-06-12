using System.Collections.Generic;
using Better_Limited_Project.Login;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public class ReorderService
    {
        private readonly ReorderRequest _reorderRequest;
        private readonly List<ReorderRequestProduct> _requestedProducts;

        public ReorderService()
        {
            _reorderRequest = new ReorderRequest(UserSettings.GetSettings().Workplace!.Id,
                LoginSession.GetSession().CurrentStaff.Id);
            _requestedProducts = new List<ReorderRequestProduct>();
        }

        public void AddProduct(string productId, int quantity)
        {
            _requestedProducts.Add(new ReorderRequestProduct(_reorderRequest.Id, productId, quantity));
        }

        public void Submit()
        {
            _reorderRequest.Save();
            _requestedProducts.ForEach(rp => rp.Save());
        }
    }
}