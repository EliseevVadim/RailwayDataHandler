using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class Depot : IDatabaseAgent
    {
        private int _stationId;
        private string _shortName;
        private string _fullName;

        public int StationId { get => _stationId; set => _stationId = value; }
        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public Depot() { }

        public Depot(int stationId, string shortName, string fullName)
        {
            _stationId = stationId;
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Depot (station_id, depot_short_name, depot_full_name) VALUES (@id, @short, @full)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", _stationId);
                command.Parameters.AddWithValue("@short", _shortName);
                command.Parameters.AddWithValue("@full", _fullName);
                command.ExecuteNonQuery();
            }
        }
    }
}
