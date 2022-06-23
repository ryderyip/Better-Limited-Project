using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Entity;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.Controller
{
    public class PurchaseOrderCreationService
    {
        private readonly List<PurchaseOrderProduct> _orderProducts;
        private readonly PurchaseOrder _purchaseOrder;

        public PurchaseOrderCreationService(ReorderRequest reorderRequest)
        {
            _purchaseOrder = new PurchaseOrder(reorderRequest.Id, LoginSession.GetSession().CurrentStaff.Id);
            _orderProducts = new List<PurchaseOrderProduct>();
        }

        /// <summary>
        ///     Creates a purchase order
        /// </summary>
        public void Create()
        {
            if (_orderProducts.Count == 0)
                return;

            _purchaseOrder.Save();
            _orderProducts.ForEach(op => op.Save());
        }

        public void AddRangeOrderProducts(IEnumerable<IProductQuantity> productQuantities)
        {
            _orderProducts.AddRange(productQuantities.Select(pq =>
                new PurchaseOrderProduct(_purchaseOrder.Id, pq.ProductId, pq.Quantity)));
        }
    }
}