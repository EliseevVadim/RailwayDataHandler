using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class WorkTimeInformation : IDatabaseAgent
    {
        private int _routeId;
        private string _wayType;
        private string _turnout;
        private string _locomotiveReception;
        private string _exit;
        private string _pass;
        private string _givingTime;
        private string _workFinishTime;
        private double _averageTemperature;
        private string _restOvertime;
        private string _reason;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public string WayType { get => _wayType; set => _wayType = value; }
        public string Turnout { get => _turnout; set => _turnout = value; }
        public string LocomotiveReception { get => _locomotiveReception; set => _locomotiveReception = value; }
        public string Exit { get => _exit; set => _exit = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string GivingTime { get => _givingTime; set => _givingTime = value; }
        public string WorkFinishTime { get => _workFinishTime; set => _workFinishTime = value; }
        public double AverageTemperature { get => _averageTemperature; set => _averageTemperature = value; }
        public string RestOvertime { get => _restOvertime; set => _restOvertime = value; }
        public string Reason { get => _reason; set => _reason = value; }
        public WorkTimeInformation() { }

        public WorkTimeInformation(int routeId, string wayType, string turnout, string locomotiveReception, string exit, string pass, string givingTime, string workFinishTime, double averageTemperature, string restOvertime, string reason)
        {
            _routeId = routeId;
            _wayType = wayType;
            _turnout = turnout;
            _locomotiveReception = locomotiveReception;
            _exit = exit;
            _pass = pass;
            _givingTime = givingTime;
            _workFinishTime = workFinishTime;
            _averageTemperature = averageTemperature;
            _restOvertime = restOvertime;
            _reason = reason;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
