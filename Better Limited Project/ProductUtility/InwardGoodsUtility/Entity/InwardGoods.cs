using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Repository;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity
{
    public class InwardGoods
    {
        public InwardGoods(string purchaseOrderId)
        {
            Id = InwardGoodsRepository.GetNewId();
            PurchaseOrderId = purchaseOrderId;
            ReceivedOn = DateTime.Now;
        }

        public InwardGoods(string id, string purchaseOrderId, DateTime receivedOn)
        {
            Id = id;
            PurchaseOrderId = purchaseOrderId;
            ReceivedOn = receivedOn;
        }

        public string Id { get; }
        public string PurchaseOrderId { get; }
        public DateTime ReceivedOn { get; }
        public PurchaseOrder PurchaseOrder => PurchaseOrderRepository.GetById(PurchaseOrderId);
        public IEnumerable<InwardGoodsProduct> InwardProducts => InwardGoodsProductRepository.GetByInwardGoodsId(Id);

        public void Save()
        {
            InwardGoodsRepository.Insert(this);
        }

        public bool IsAllProductsReceived()
        {
            return !PurchaseOrder.GetNotYetReceivedProducts().Any();
        }
    }
}