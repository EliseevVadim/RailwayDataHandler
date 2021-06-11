using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class Node : IDatabaseAgent
    {
        private int _routeId;
        private string _shortName;
        private string _fullName;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public Node() { }

        public Node(int routeId, string shortName, string fullName)
        {
            _routeId = routeId;
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Node (road_id, node_short_name, node_full_name) VALUES (@id, @short, @full)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", _routeId);
                command.Parameters.AddWithValue("@short", _shortName);
                command.Parameters.AddWithValue("@full", _fullName);
                command.ExecuteNonQuery();
            }
        }
    }
}
