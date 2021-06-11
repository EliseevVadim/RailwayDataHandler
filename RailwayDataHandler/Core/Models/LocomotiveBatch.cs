using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class LocomotiveBatch : IDatabaseAgent
    {
        private string _shortName;
        private string _fullName;

        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public LocomotiveBatch() { }

        public LocomotiveBatch(string shortName, string fullName)
        {
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Locomotive_batch (batch_short_name, batch_full_name) VALUES (@short, @full)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@short", _shortName);
                command.Parameters.AddWithValue("@full", _fullName);
                command.ExecuteNonQuery();
            }
        }
    }
}
