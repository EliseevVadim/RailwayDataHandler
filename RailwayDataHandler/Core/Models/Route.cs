using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class Route : IDatabaseAgent
    {
        private int _locomotiveId;
        private int _driversId;
        private string _routeNumber;
        private DateTime _date;

        public int LocomotiveId { get => _locomotiveId; set => _locomotiveId = value; }
        public int DriversId { get => _driversId; set => _driversId = value; }
        public string RouteNumber { get => _routeNumber; set => _routeNumber = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public Route() { }

        public Route(int locomotiveId, int driversId, string routeNumber, DateTime date)
        {
            _locomotiveId = locomotiveId;
            _driversId = driversId;
            _routeNumber = routeNumber;
            _date = date;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
