using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class ExpenceStatement : IDatabaseAgent
    {
        private int _routeId;
        private double _acceptTraction;
        private double _givingTraction;
        private double _acceptHeating;
        private double _givingHeating;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public double AcceptTraction { get => _acceptTraction; set => _acceptTraction = value; }
        public double GivingTraction { get => _givingTraction; set => _givingTraction = value; }
        public double AcceptHeating { get => _acceptHeating; set => _acceptHeating = value; }
        public double GivingHeating { get => _givingHeating; set => _givingHeating = value; }

        public ExpenceStatement() { }

        public ExpenceStatement(int routeId, double acceptTraction, double givingTraction, double acceptHeating, double givingHeating)
        {
            _routeId = routeId;
            _acceptTraction = acceptTraction;
            _givingTraction = givingTraction;
            _acceptHeating = acceptHeating;
            _givingHeating = givingHeating;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
