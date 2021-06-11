using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using RailwayDataHandler.Core.Exceptions;

namespace RailwayDataHandler.Core.Models
{
    class SequenceLocomotiveCrewStatement : IDatabaseAgent
    {
        private int _routeId;
        private int _departureStationId;
        private int _arrivalStationId;
        private string _wayType;
        private int _orderNumber;
        private int _trainNumber;
        private bool isStationsValid => _departureStationId != _arrivalStationId;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public int DepartureStationId { get => _departureStationId; set => _departureStationId = value; }
        public int ArrivalStationId { get => _arrivalStationId; set => _arrivalStationId = value; }
        public string WayType { get => _wayType; set => _wayType = value; }
        public int OrderNumber { get => _orderNumber; set => _orderNumber = value; }
        public int TrainNumber { get => _trainNumber; set => _trainNumber = value; }

        public SequenceLocomotiveCrewStatement() { }

        public SequenceLocomotiveCrewStatement(int routeId, int departureStationId, int arrivalStationId, string wayType, int orderNumber, int trainNumber)
        {
            _routeId = routeId;
            _departureStationId = departureStationId;
            _arrivalStationId = arrivalStationId;
            _wayType = wayType;
            _orderNumber = orderNumber;
            _trainNumber = trainNumber;
        }

        public void AddToDatabase()
        {
            if (isStationsValid)
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
                {
                    connection.Open();
                    string query = string.Format(@"INSERT INTO Sequence_locomotive_crew_statement (route_id, departure_station_id, arrival_station_id, way_type, order_number, train_number) VALUES (@route, @departure, @arrival, @way, @order, @train)");
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@route", _routeId);
                    command.Parameters.AddWithValue("@departure", _departureStationId);
                    command.Parameters.AddWithValue("@arrival", _arrivalStationId);
                    command.Parameters.AddWithValue("@way", _wayType);
                    command.Parameters.AddWithValue("@order", _orderNumber);
                    command.Parameters.AddWithValue("@train", _trainNumber);
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
