using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Repository
{
    public static class InstallationTechnicianRepository
    {
        public static void Insert(InstallationTechnician installationTechnician)
        {
            var command = new MySqlCommand(
                @"insert into installation_technician value (@installationId, @technicianId); ");
            command.Parameters.AddWithValue("@installationId", installationTechnician.InstallationId);
            command.Parameters.AddWithValue("@technicianId", installationTechnician.TechnicianId);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static IEnumerable<InstallationTechnician> GetByInstallationId(string installationId)
        {
            var command = new MySqlCommand(
                @"select technician_id from installation_technician where installation_id = @installationId;");
            command.Parameters.AddWithValue("@installationId", installationId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let technicianId = row.Field<int>("technician_id").ToString()
                select new InstallationTechnician(installationId, technicianId);
        }
    }
}