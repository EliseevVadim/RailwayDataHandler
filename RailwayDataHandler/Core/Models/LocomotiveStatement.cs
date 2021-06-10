using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class LocomotiveStatement : IDatabaseAgent
    {
        private int _sequenceCodeId;
        private int _locomotiveId;
        private int _departureStationId;
        private int _arrivalStationId;
        private int _routeId;

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
            throw new NotImplementedException();
        }
    }
}
