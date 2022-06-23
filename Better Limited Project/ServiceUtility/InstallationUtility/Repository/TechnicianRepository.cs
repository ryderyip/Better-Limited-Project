using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Repository
{
    public static class TechnicianRepository
    {
        public static void InsertOrUpdate(Technician technician)
        {
            var command = new MySqlCommand(
                @"insert into technician (id, name, phone) value (@id, @name, @phone) 
                    on duplicate key update name = @name, phone = @phone;");
            command.Parameters.AddWithValue("@id", technician.Id);
            command.Parameters.AddWithValue("@name", technician.Name);
            command.Parameters.AddWithValue("@phone", technician.Phone);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public static Technician FindById(string id)
        {
            var command = new MySqlCommand(
                @"select id, name,phone from technician where id = @id;");
            command.Parameters.AddWithValue("@id", id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Technician with id \"{id}\" does not exist.");
            return ConvertToTechnician(dataTable.Rows[0]);
        }

        public static IEnumerable<Technician> GetAll()
        {
            var command = new MySqlCommand(@"select id, name,phone from technician;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToTechnician(row);
        }

        private static Technician ConvertToTechnician(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string name = row.Field<string>("name");
            string phone = row.Field<string>("phone");
            return new Technician(id, name, phone);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from technician;"));
            if (dataTable.Rows[0]["id"] == DBNull.Value)
                return "1";
            return ((from DataRow row in dataTable.Rows select row.Field<int>("id")).First() + 1).ToString();
        }

        public static void Remove(Technician technician)
        {
            var command = new MySqlCommand(
                @"delete from technician where id = @id;");
            command.Parameters.AddWithValue("@id", technician.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}