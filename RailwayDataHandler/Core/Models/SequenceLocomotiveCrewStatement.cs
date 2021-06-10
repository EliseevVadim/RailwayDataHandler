using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            throw new NotImplementedException();
        }
    }
}
