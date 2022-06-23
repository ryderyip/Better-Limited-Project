using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.StaffUtility.Repository
{
    public static class StaffTitleRepository
    {
        public static IEnumerable<StaffTitle> GetAll()
        {
            var mapper = new StaffTitleMapper();
            var command = new MySqlCommand("select id, name from staff_title;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                select mapper.Map(row.Field<string>("name"));
        }

        public static string GetId(StaffTitle title)
        {
            var mapper = new StaffTitleMapper();
            var command = new MySqlCommand("select id, name from staff_title;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            var row = dataTable.Rows.Cast<DataRow>()
                          .FirstOrDefault(row => row.Field<string>("name") == mapper.Map(title))
                      ?? throw new ArgumentException($"Title \"{title.ToString()}\" or title mapper has an error.");
            return row.Field<int>("id").ToString();
        }

        public static StaffTitle FindById(string staffTitleId)
        {
            var command = new MySqlCommand(
                @"select name from staff_title where id = @id");
            command.Parameters.AddWithValue("@id", staffTitleId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            if (dataTable.Rows.Count == 0)
                throw new ArgumentException($"Staff title id \"{staffTitleId}\" does not exist.");
            string titleName = dataTable.Rows[0].Field<string>("name");
            return new StaffTitleMapper().Map(titleName);
        }
    }
}