using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using RailwayDataHandler.Core.Exceptions;

namespace RailwayDataHandler.Core.Models
{
    class LocomotiveStatement : IDatabaseAgent
    {
        private int _sequenceCodeId;
        private int _locomotiveId;
        private int _departureStationId;
        private int _arrivalStationId;
        private int _routeId;
        private bool isStationsValid => _departureStationId != _arrivalStationId;

        public int SequenceCodeId { get => _sequenceCodeId; set => _sequenceCodeId = value; }
        public int LocomotiveId { get => _locomotiveId; set => _locomotiveId = value; }
        public int DepartureStationId { get => _departureStationId; set => _departureStationId = value; }
        public int ArrivalStationId { get => _arrivalStationId; set => _arrivalStationId = value; }
        public int RouteId { get => _routeId; set => _routeId = value; }

        public LocomotiveStatement() { }

        public LocomotiveStatement(int sequenceCodeId, int locomotiveId, int departureStationId, int arrivalStationId, int routeId)
        {
            _sequenceCodeId = sequenceCodeId;
            _locomotiveId = locomotiveId;
            _departureStationId = departureStationId;
            _arrivalStationId = arrivalStationId;
            _routeId = routeId;
        }

        public void AddToDatabase()
        {
            if (isStationsValid)
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
                {
                    connection.Open();
                    string query = string.Format(@"INSERT INTO Locomotive_statement (sequence_code_id, locomotive_id, departure_station_id, arrival_station_id, route_id) VALUES (@code, @locomotive, @departure, @arrival, @route)");
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@code", _sequenceCodeId);
                    command.Parameters.AddWithValue("@locomotive", _locomotiveId);
                    command.Parameters.AddWithValue("@departure", _departureStationId);
                    command.Parameters.AddWithValue("@arrival", _arrivalStationId);
                    command.Parameters.AddWithValue("@route", _routeId);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                throw new EqualDepartureAndArrivalStationsException("Станции отправления и прибытия совпадают. Проверьте ввод.");
            }
        }
    }
}
