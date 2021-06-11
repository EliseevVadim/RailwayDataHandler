using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class Station : IDatabaseAgent
    {
        private int _nodeId;
        private string _shortName;
        private string _fullName;

        public int NodeId { get => _nodeId; set => _nodeId = value; }
        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public Station() { }

        public Station(int nodeId, string shortName, string fullName)
        {
            _nodeId = nodeId;
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Station (node_id, station_short_name, station_full_name) VALUES (@id, @short, @full)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", _nodeId);
                command.Parameters.AddWithValue("@short", _shortName);
                command.Parameters.AddWithValue("@full", _fullName);
                command.ExecuteNonQuery();
            }
        }
    }
}
