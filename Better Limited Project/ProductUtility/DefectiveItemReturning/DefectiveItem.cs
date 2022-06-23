using System;
using System.Drawing;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    public class DefectiveItem
    {
        private Image? _image;

        public DefectiveItem(string id, string productId, int quantity, string description,
            string retailStoreId, string createdByStaffId, string salesOrderId, DateTime returnedToRetailStoreOn)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
            Description = description;
            RetailStoreId = retailStoreId;
            CreatedByStaffId = createdByStaffId;
            SalesOrderId = salesOrderId;
            ReturnedToRetailStoreOn = returnedToRetailStoreOn;
        }

        public DefectiveItem(string productId, int quantity, string description, string retailStoreId,
            string createdByStaffId,
            string salesOrderId)
        {
            Id = DefectiveItemRepository.GetNewId();
            ProductId = productId;
            Quantity = quantity;
            Description = description;
            RetailStoreId = retailStoreId;
            CreatedByStaffId = createdByStaffId;
            SalesOrderId = salesOrderId;
            ReturnedToRetailStoreOn = DateTime.Now;
        }

        public string Id { get; }
        public string ProductId { get; }
        public int Quantity { get; }
        public string Description { get; set; }

        public Image? Image
        {
            get => _image ?? DefectiveItemRepository.GetImageById(Id);
            set => _image = value;
        }

        public string RetailStoreId { get; }
        public string CreatedByStaffId { get; }
        public string SalesOrderId { get; }
        public Product Product => ProductRepository.FindById(ProductId);
        public RetailStore RetailStore => new RetailStoreRepository().GetById(RetailStoreId);
        public Staff CreatedByStaff => new StaffRepository().FindById(CreatedByStaffId);
        public SalesOrder SalesOrder => new SalesOrderRepository().FindById(SalesOrderId);
        public DateTime ReturnedToRetailStoreOn { get; }
        public DateTime? ReturnedToWarehouseOn { get; set; }
        public DateTime? ReturnApprovedOn { get; set; }
        public string? WarehouseId { get; set; }
        public Warehouse? Warehouse => WarehouseId != null ? WarehouseRepository.GetById(WarehouseId) : null;

        public DateTime? ReturnedToSupplierOn { get; set; }

        public void Save()
        {
            DefectiveItemRepository.InsertOrUpdate(this);
        }

        public bool IsReturnApproved()
        {
            return ReturnApprovedOn != null;
        }

        public bool IsReturnedToWarehouse()
        {
            return ReturnedToWarehouseOn != null;
        }

        public bool IsReturnedToSupplier()
        {
            return ReturnedToSupplierOn != null;
        }
    }
}