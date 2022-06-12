using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository
{
    public static class PurchaseOrderRepository
    {
        public static IEnumerable<PurchaseOrder> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, purchase_order_number, reorder_request_id, created_on, created_by_staff_id, 
                    approved_on, approved_by_staff_id, sent_to_supplier_on 
                from purchase_order;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToPurchaseOrder(row);
        }

        public static PurchaseOrder GetById(string id)
        {
            var command = new MySqlCommand(
                @"select id, purchase_order_number, reorder_request_id, created_on, created_by_staff_id, 
                    approved_on, approved_by_staff_id, sent_to_supplier_on 
                from purchase_order 
                where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Purchase order with ID \"{id}\" does not exist.");
            return ConvertToPurchaseOrder(dataTable.Rows[0]);
        }

        private static PurchaseOrder ConvertToPurchaseOrder(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string orderNumber = row.Field<string>("purchase_order_number");
            string requestId = row.Field<int>("reorder_request_id").ToString();
            var createdOn = row.Field<DateTime>("created_on");
            string createdByStaffId = row.Field<int>("created_by_staff_id").ToString();
            var approvedOn = row.Field<DateTime?>("approved_on");
            var approvedByStaffId = row.Field<int?>("approved_by_staff_id")?.ToString();
            var sentToSupplierOn = row.Field<DateTime?>("sent_to_supplier_on");
            return new PurchaseOrder(id, orderNumber, requestId, createdOn, createdByStaffId,
                approvedByStaffId, approvedOn, sentToSupplierOn);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from purchase_order;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static void InsertOrUpdate(PurchaseOrder purchaseOrder)
        {
            var command = new MySqlCommand(
                @"insert into purchase_order (id, purchase_order_number, reorder_request_id, created_on, created_by_staff_id, 
                            approved_on, approved_by_staff_id, sent_to_supplier_on) 
                    value (@id, @orderNumber, @requestId, @createdOn, @createdByStaffId, @approvedOn, 
                           @approvedByStaffId, @sentToSupplierOn)
                    on duplicate key update approved_on = @approvedOn, 
                                            approved_by_staff_id = @approvedByStaffId, 
                                            sent_to_supplier_on = @sentToSupplierOn;");
            command.Parameters.AddWithValue("@id", purchaseOrder.Id);
            command.Parameters.AddWithValue("@orderNumber", purchaseOrder.PurchaseOrderNumber);
            command.Parameters.AddWithValue("@requestId", purchaseOrder.ReorderRequestId);
            command.Parameters.AddWithValue("@createdOn", purchaseOrder.CreatedOn);
            command.Parameters.AddWithValue("@createdByStaffId", purchaseOrder.CreatedByStaffId);
            command.Parameters.AddWithValue("@approvedOn",
                purchaseOrder.ApprovedOn != null ? purchaseOrder.ApprovedOn.Value : DBNull.Value);
            command.Parameters.AddWithValue("@approvedByStaffId",
                purchaseOrder.ApprovedByStaffId != null ? purchaseOrder.ApprovedByStaffId : DBNull.Value);
            command.Parameters.AddWithValue("@sentToSupplierOn",
                purchaseOrder.SentToSupplierOn != null ? purchaseOrder.SentToSupplierOn : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}