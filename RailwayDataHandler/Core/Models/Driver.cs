using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class Driver : IDatabaseAgent
    {
        private string _name;
        private int _category;

        public string Name { get => _name; set => _name = value; }
        public int Category { get => _category; set => _category = value; }

        public Driver() { }

        public Driver(string name, int category)
        {
            _name = name;
            _category = category;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format("INSERT INTO Driver (drivers_name, drivers_category) VALUES (@name, @category)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@name", _name);
                command.Parameters.AddWithValue("@category", _category);
                command.ExecuteNonQuery();
            }
        }
    }
}
