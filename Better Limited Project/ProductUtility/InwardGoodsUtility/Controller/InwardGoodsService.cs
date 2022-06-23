using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Controller;
using Better_Limited_Project.ProductUtility.Reordering.Entity;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.Controller
{
    public class InwardGoodsService
    {
        private readonly InwardGoods _inwardGoods;
        private readonly List<InwardGoodsProduct> _inwardGoodsProducts = new();

        public InwardGoodsService(string purchaseOrderId)
        {
            _inwardGoods = new InwardGoods(purchaseOrderId);
        }

        public void CreateRecord()
        {
            if (!_inwardGoodsProducts.Any())
                throw new InvalidOperationException("You can't create an inward goods record with no product.");
            
            _inwardGoods.Save();
            _inwardGoodsProducts.ForEach(igp => igp.Save());
            ReorderStockUpdateService.Receive(_inwardGoods);
        }

        public void AddRangeGoods(IEnumerable<IProductQuantity> inwardGoodsProducts)
        {
            _inwardGoodsProducts.AddRange(
                inwardGoodsProducts.Select(pq => new InwardGoodsProduct(_inwardGoods.Id,
                    pq.ProductId, pq.Quantity)));
        }
    }
}