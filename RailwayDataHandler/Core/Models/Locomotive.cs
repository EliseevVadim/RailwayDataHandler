using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class Locomotive : IDatabaseAgent
    {
        private int _depotId;
        private int _batchId;
        private string _number;
        private int _sectionNumber;

        public int DepotId { get => _depotId; set => _depotId = value; }
        public int BatchId { get => _batchId; set => _batchId = value; }
        public string Number { get => _number; set => _number = value; }
        public int SectionNumber { get => _sectionNumber; set => _sectionNumber = value; }

        public Locomotive() { }

        public Locomotive(int depotId, int batchId, string number, int sectionNumber)
        {
            _depotId = depotId;
            _batchId = batchId;
            _number = number;
            _sectionNumber = sectionNumber;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Locomotive (depot_id, batch_id, locomotive_number, section_number) VALUES (@depot, @batch, @loc_num, @section)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@depot", _depotId);
                command.Parameters.AddWithValue("@batch", _batchId);
                command.Parameters.AddWithValue("@loc_num", _number);
                command.Parameters.AddWithValue("@section", _sectionNumber);
                command.ExecuteNonQuery();
            }
        }
    }
}
