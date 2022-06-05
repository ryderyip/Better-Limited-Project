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
        public static IEnumerable<StaffTitle> GetTitles()
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
    }
}