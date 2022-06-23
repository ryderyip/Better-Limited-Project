using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Repository
{
    public static class InstallationRepository
    {
        public static IEnumerable<Installation> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, installation_request_id, scheduled_on, installed_on 
                from installation;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToInstallation(row);
        }

        public static Installation FindById(string id)
        {
            var command = new MySqlCommand(
                @"select id, installation_request_id, scheduled_on, installed_on 
                from installation where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Installation with id \"{id}\" does not exist.");
            return ConvertToInstallation(dataTable.Rows[0]);
        }

        private static Installation ConvertToInstallation(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string requestId = row.Field<int>("installation_request_id").ToString();
            var scheduledOn = row.Field<DateTime>("scheduled_on");
            var installedOn = row.Field<DateTime?>("installed_on");
            return new Installation(id, requestId, scheduledOn, installedOn);
        }

        public static void InsertOrUpdate(Installation installation)
        {
            var command = new MySqlCommand(
                @"insert into installation (id, installation_request_id, scheduled_on, installed_on) 
                    value (@id, @requestId, @scheduledOn, @installedOn) 
                on duplicate key update scheduled_on = @scheduledOn, installed_on = @installedOn;");
            command.Parameters.AddWithValue("@id", installation.Id);
            command.Parameters.AddWithValue("@requestId", installation.InstallationRequestId);
            command.Parameters.AddWithValue("@scheduledOn", installation.ScheduledOn);
            command.Parameters.AddWithValue("@installedOn",
                installation.InstalledOn.HasValue ? installation.InstalledOn.Value : DBNull.Value);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from installation;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static IEnumerable<Installation> FindBy(Predicate<Installation> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public static void Remove(InstallationRequest installationRequest)
        {
            var command = new MySqlCommand(
                @"delete from installation_request where id = @id;");
            command.Parameters.AddWithValue("@id", installationRequest.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}