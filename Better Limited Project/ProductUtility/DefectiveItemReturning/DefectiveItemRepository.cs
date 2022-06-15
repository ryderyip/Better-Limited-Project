using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.DefectiveItemReturning
{
    public static class DefectiveItemRepository
    {
        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from defective_item;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static void InsertOrUpdate(DefectiveItem defectiveItem)
        {
            var command = new MySqlCommand(
                @"insert into defective_item (id, product_id, quantity, description, image, retail_store_id, staff_id, 
                    sales_order_id, returned_to_retail_store_on, returned_to_warehouse_on, warehouse_id, returned_to_supplier_on, return_approved_on)
                value (@id, @productId, @quantity, @description, @image, @retailStoreId, @staffId, @salesOrderId, 
                       @returnedToRetailStoreOn, @returnedToWarehouseOn, @warehouseId, @returnedToSupplierOn, @returnApprovedOn)
                on duplicate key update product_id = @productId, quantity = @quantity, 
                                        description = @description, image = @image,
                                        returned_to_warehouse_on = @returnedToWarehouseOn,
                                        warehouse_id = @warehouseId,
                                        returned_to_supplier_on = @returnedToSupplierOn,
                                        return_approved_on = @returnApprovedOn;");
            command.Parameters.AddWithValue("@id", defectiveItem.Id);
            command.Parameters.AddWithValue("@productId", defectiveItem.ProductId);
            command.Parameters.AddWithValue("@quantity", defectiveItem.Quantity);
            command.Parameters.AddWithValue("@description", defectiveItem.Description);
            command.Parameters.AddWithValue("@image",
                defectiveItem.Image != null ? ImageToBytesConverter.Convert(defectiveItem.Image) : DBNull.Value);
            command.Parameters.AddWithValue("@retailStoreId", defectiveItem.RetailStoreId);
            command.Parameters.AddWithValue("@staffId", defectiveItem.CreatedByStaffId);
            command.Parameters.AddWithValue("@salesOrderId", defectiveItem.SalesOrderId);
            command.Parameters.AddWithValue("@returnedToRetailStoreOn", defectiveItem.ReturnedToRetailStoreOn);
            command.Parameters.AddWithValue("@returnedToWarehouseOn", defectiveItem.ReturnedToWarehouseOn.HasValue
                ? defectiveItem.ReturnedToWarehouseOn
                : DBNull.Value);
            command.Parameters.AddWithValue("@warehouseId",
                defectiveItem.WarehouseId != null ? defectiveItem.WarehouseId : DBNull.Value);
            command.Parameters.AddWithValue("@returnedToSupplierOn", defectiveItem.ReturnedToSupplierOn);
            command.Parameters.AddWithValue("@returnApprovedOn",
                defectiveItem.ReturnApprovedOn.HasValue ? defectiveItem.ReturnApprovedOn : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<DefectiveItem> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, product_id, quantity, description, image, retail_store_id, staff_id, sales_order_id, 
                    returned_to_retail_store_on, returned_to_warehouse_on, warehouse_id, returned_to_supplier_on, return_approved_on
                from defective_item;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToDefectiveItem(row);
        }

        public static DefectiveItem GetById(string id)
        {
            var command = new MySqlCommand(
                @"select id, product_id, quantity, description, image, retail_store_id, staff_id, sales_order_id, 
                    returned_to_retail_store_on, returned_to_warehouse_on, warehouse_id, returned_to_supplier_on, return_approved_on
                from defective_item where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Defective item id \"{id}\" does not exist.");
            return ConvertToDefectiveItem(dataTable.Rows[0]);
        }

        public static Image? GetImageById(string defectiveItemId)
        {
            var command = new MySqlCommand(
                @"select image from defective_item where id = @id;");
            command.Parameters.AddWithValue("@id", defectiveItemId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                return null;
            var bytes = dataTable.Rows[0].Field<byte[]>("image");

            return bytes != null ? new ImageConverter().ConvertFrom(bytes) as Image : null;
        }

        private static DefectiveItem ConvertToDefectiveItem(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string productId = row.Field<int>("product_id").ToString();
            int quantity = row.Field<int>("quantity");
            string description = row.Field<string>("description");
            string retailStoreId = row.Field<string>("retail_store_id");
            string staffId = row.Field<int>("staff_id").ToString();
            string salesOrderId = row.Field<int>("sales_order_id").ToString();
            DateTime returnedRetailStoreOn = row.Field<DateTime>("returned_to_retail_store_on");
            var warehouseId = row.Field<int?>("warehouse_id").ToString();
            var returnedToWarehouseOn = row.Field<DateTime?>("returned_to_warehouse_on");
            var returnedToSupplierOn = row.Field<DateTime?>("returned_to_supplier_on");
            var image = row.Field<byte[]>("image");
            var returnApprovedOn = row.Field<DateTime?>("return_approved_on");
            return new DefectiveItem(id, productId, quantity, description, retailStoreId, staffId, salesOrderId,
                returnedRetailStoreOn)
            {
                Image = image != null ? new ImageConverter().ConvertFrom(image) as Image : null,
                WarehouseId = warehouseId,
                ReturnedToWarehouseOn = returnedToWarehouseOn,
                ReturnedToSupplierOn = returnedToSupplierOn,
                ReturnApprovedOn = returnApprovedOn
            };
        }
    }
}