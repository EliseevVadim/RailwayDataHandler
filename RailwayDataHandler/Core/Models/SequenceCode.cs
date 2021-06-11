using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class SequenceCode : IDatabaseAgent
    {
        private string _sequenceValue;
        private string _fullName;

        public string SequenceValue { get => _sequenceValue; set => _sequenceValue = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public SequenceCode() { }

        public SequenceCode(string sequenceValue, string fullName)
        {
            _sequenceValue = sequenceValue;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Sequence_code (sequence_value, sequence_full_name) VALUES (@value, @full)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@value", _sequenceValue);
                command.Parameters.AddWithValue("@full", _fullName);
                command.ExecuteNonQuery();
            }
        }
    }
}
