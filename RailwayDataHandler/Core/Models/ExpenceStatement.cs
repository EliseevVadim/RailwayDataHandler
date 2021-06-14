using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace RailwayDataHandler.Core.Models
{
    class ExpenceStatement : IDatabaseAgent
    {
        private int _routeId;
        private double _acceptTraction;
        private double _givingTraction;
        private double _acceptHeating;
        private double _givingHeating;
        private int _sectionNumber;
        private string _wayType;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public double AcceptTraction { get => _acceptTraction; set => _acceptTraction = value; }
        public double GivingTraction { get => _givingTraction; set => _givingTraction = value; }
        public double AcceptHeating { get => _acceptHeating; set => _acceptHeating = value; }
        public double GivingHeating { get => _givingHeating; set => _givingHeating = value; }
        public int SectionNumber { get => _sectionNumber; set => _sectionNumber = value; }
        public string WayType { get => _wayType; set => _wayType = value; }

        public ExpenceStatement() { }
        public ExpenceStatement(int routeId, double acceptTraction, double givingTraction, double acceptHeating, double givingHeating, int sectionNumber, string wayType)
        {
            _routeId = routeId;
            _acceptTraction = acceptTraction;
            _givingTraction = givingTraction;
            _acceptHeating = acceptHeating;
            _givingHeating = givingHeating;
            _sectionNumber = sectionNumber;
            _wayType = wayType;
        }

        public void AddToDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Expence_statement (route_id, accept_traction, giving_traction, accept_heating, giving_heating, way_type, section_number) VALUES (@route, @acceptTraction, @givingTraction, @acceptHeating, @givingHeating, @type, @section)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@route", _routeId);
                command.Parameters.AddWithValue("@acceptTraction", _acceptTraction);
                command.Parameters.AddWithValue("@givingTraction", _givingTraction);
                command.Parameters.AddWithValue("@acceptHeating", _acceptHeating);
                command.Parameters.AddWithValue("@givingHeating", _givingHeating);
                command.Parameters.AddWithValue("@type", _wayType);
                command.Parameters.AddWithValue("@section", _sectionNumber);
                command.ExecuteNonQuery();
            }
        }
    }
}
