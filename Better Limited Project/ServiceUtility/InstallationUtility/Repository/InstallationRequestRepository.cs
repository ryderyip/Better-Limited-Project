using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Repository
{
    public static class InstallationRequestRepository
    {
        public static void InsertOrUpdate(InstallationRequest installationRequest)
        {
            var command = new MySqlCommand(
                @"insert into installation_request (id, sales_order_id, arranged_on, arranged_by_staff_id) 
                    value (@id, @salesOrderId, @arrangedOn, @arrangedByStaffId) 
                on duplicate key update arranged_on = @arrangedOn, 
                                        arranged_by_staff_id = @arrangedByStaffId;");
            command.Parameters.AddWithValue("@id", installationRequest.Id);
            command.Parameters.AddWithValue("@salesOrderId", installationRequest.SalesOrderId);
            command.Parameters.AddWithValue("@arrangedOn",
                installationRequest.ArrangedOn != null ? installationRequest.ArrangedOn.Value : DBNull.Value);
            command.Parameters.AddWithValue("@arrangedByStaffId",
                installationRequest.ArrangedByStaffId != null ? installationRequest.ArrangedByStaffId : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static InstallationRequest FindById(string id)
        {
            var command = new MySqlCommand(
                @"select id, sales_order_id, arranged_on, arranged_by_staff_id 
                from installation_request 
                where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Installation request with id \"{id}\" does not exist.");
            return ConvertToInstallationRequest(dataTable.Rows[0]);
        }

        public static IEnumerable<InstallationRequest> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, sales_order_id, arranged_on, arranged_by_staff_id 
                from installation_request");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToInstallationRequest(row);
        }

        private static InstallationRequest ConvertToInstallationRequest(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string salesOrderId = row.Field<int>("sales_order_id").ToString();
            var arrangedOn = row.Field<DateTime?>("arranged_on");
            var arrangedByStaffId = row.Field<int?>("arranged_by_staff_id")?.ToString();
            return new InstallationRequest(id, salesOrderId, arrangedOn, arrangedByStaffId);
        }

        public static IEnumerable<InstallationRequest> FindAll(Predicate<InstallationRequest> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from installation_request;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }
    }
}