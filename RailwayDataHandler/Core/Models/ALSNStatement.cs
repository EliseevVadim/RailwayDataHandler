using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class ALSNStatement : IDatabaseAgent
    {
        private int _routeId;
        private int _lighterReadingsId;
        private int _alsnReadingId;
        private int _kilometer;
        private int _coloumn;
        private int _sectionNumber;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public int LighterReadingsId { get => _lighterReadingsId; set => _lighterReadingsId = value; }
        public int AlsnReadingId { get => _alsnReadingId; set => _alsnReadingId = value; }
        public int Kilometer { get => _kilometer; set => _kilometer = value; }
        public int Coloumn { get => _coloumn; set => _coloumn = value; }
        public int SectionNumber { get => _sectionNumber; set => _sectionNumber = value; }

        public ALSNStatement() { }

        public ALSNStatement(int routeId, int lighterReadingsId, int alsnReadingId, int kilometer, int coloumn, int sectionNumber)
        {
            _routeId = routeId;
            _lighterReadingsId = lighterReadingsId;
            _alsnReadingId = alsnReadingId;
            _kilometer = kilometer;
            _coloumn = coloumn;
            _sectionNumber = sectionNumber;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO ALSN_statement (route_id, lighter_readings_id, ALSN_reading_id, kilometer, coloumn, section_number) VALUES (@route, @lighter, @ALSN, @kilometer, @coloumn, @section)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@route", _routeId);
                command.Parameters.AddWithValue("@lighter", _lighterReadingsId);
                command.Parameters.AddWithValue("@ALSN", _alsnReadingId);
                command.Parameters.AddWithValue("@kilometer", _kilometer);
                command.Parameters.AddWithValue("@coloumn", _coloumn);
                command.Parameters.AddWithValue("@section", _sectionNumber);
                command.ExecuteNonQuery();
            }
        }
    }
}
