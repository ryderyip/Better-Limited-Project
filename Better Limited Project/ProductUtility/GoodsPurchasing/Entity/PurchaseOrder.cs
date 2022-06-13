using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Controller;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Repository;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Repository;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity
{
    public class PurchaseOrder
    {
        public PurchaseOrder(string reorderRequestId, string createdByStaffId)
        {
            Id = PurchaseOrderRepository.GetNewId();
            ReorderRequestId = reorderRequestId;
            PurchaseOrderNumber = PurchaseOrderNumberGenerator.Generate(ReorderRequest.WarehouseId);
            CreatedOn = DateTime.Now;
            CreatedByStaffId = createdByStaffId;
        }

        public PurchaseOrder(string id, string purchaseOrderNumber, string reorderRequestId, DateTime createdOn, string createdByStaffId, string? approvedByStaffId, DateTime? approvedOn, DateTime? sentToSupplierOn)
        {
            Id = id;
            PurchaseOrderNumber = purchaseOrderNumber;
            ReorderRequestId = reorderRequestId;
            CreatedOn = createdOn;
            CreatedByStaffId = createdByStaffId;
            ApprovedByStaffId = approvedByStaffId;
            ApprovedOn = approvedOn;
            SentToSupplierOn = sentToSupplierOn;
        }

        public string Id { get; }
        public string ReorderRequestId { get; }
        public string PurchaseOrderNumber { get; }
        public DateTime CreatedOn { get; }
        public string CreatedByStaffId { get; }
        public string? ApprovedByStaffId { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? SentToSupplierOn { get; set; }
        public ReorderRequest ReorderRequest => ReorderRequestRepository.FindById(ReorderRequestId);
        public Staff CreatedByStaff => new StaffRepository().FindById(CreatedByStaffId);

        public Staff? ApprovedByStaff =>
            ApprovedByStaffId != null ? new StaffRepository().FindById(ApprovedByStaffId) : null;
        public IEnumerable<PurchaseOrderProduct> OrderProducts => PurchaseOrderProductRepository.GetByOrderId(Id);

        public void Save()
        {
            PurchaseOrderRepository.InsertOrUpdate(this);
        }

        public bool IsApproved()
        {
            return ApprovedOn != null && ApprovedByStaff != null;
        }

        public decimal GetTotalCost()
        {
            return OrderProducts.Sum(op => op.Product.OriginalPrice * op.Quantity);
        }

        public IEnumerable<PurchaseOrderProduct> GetNotYetReceivedProducts()
        {
            var alreadyReceived = GetReceivedProducts().ToList();
            var orderedProducts = OrderProducts;
            return !alreadyReceived.Any() 
                ? orderedProducts
            : from orderedProduct in orderedProducts
                let receivedProduct = alreadyReceived.Find(gp => gp.ProductId == orderedProduct.ProductId)
                let missingQuantity = orderedProduct.Quantity - (receivedProduct?.Quantity ?? 0)
                where receivedProduct == null || receivedProduct.Quantity < orderedProduct.Quantity
                select new PurchaseOrderProduct(Id, orderedProduct.ProductId, missingQuantity > 0 ? missingQuantity : 0);
        }

        public IEnumerable<IProductQuantity> GetReceivedProducts()
        {
            var inwardRecords = InwardGoodsRepository.FindBy(ig => ig.PurchaseOrderId == Id).ToList();
            return !inwardRecords.Any()
                ? Enumerable.Empty<PurchaseOrderProduct>()
                : inwardRecords.SelectMany(ir => ir.InwardProducts)
                    .GroupBy(igp => igp.ProductId, igp => igp.Quantity)
                    .Select(igpgp => new ProductQuantity(igpgp.Key, igpgp.Sum(qty => qty)));
        }
    }
}