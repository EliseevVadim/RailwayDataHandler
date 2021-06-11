using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class Road : IDatabaseAgent
    {
        private string _name;
        private string _description;

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        public Road() { }

        public Road(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void AddToDatabase()
        {
            string connectionString = DatabaseInformation.ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Road (road_name, road_description) VALUES (@name, @description)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@description", _description);
                command.ExecuteNonQuery();
            }
        }
    }
}
