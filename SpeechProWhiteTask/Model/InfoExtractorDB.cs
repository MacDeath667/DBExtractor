using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;

namespace SpeechProWhiteTask.Model
{
    public class InfoExtractorDB
    {
        private string _connectionStringTemplate = "Server={0}; Database={1}; User Id = {2}; Password={3};";

        public ObservableCollection<Database> BuildDB(string servername, string database, string username, string password)
        {
            ObservableCollection<Database> databases;
            var connectionString = string.Format(_connectionStringTemplate, servername, database, username, password);

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM sys.databases", connection);
                using (var reader = command.ExecuteReader())
                {

                }
                databases = GetServerDatabases();
            }

            return databases;
        }

        private ObservableCollection<Database> GetServerDatabases()
        {
            return null;
        }


        private int GetColumnPosition(string name, SqlDataReader reader)
        {
            var columnPosition = 0;

            while (reader.Read())
            {
                if (reader.GetName(columnPosition)
                    .Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                columnPosition++;
            }

            return columnPosition;
        }
    }
}