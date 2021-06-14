using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

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
        public string Reason 
        {
            get
            {
                return _reason;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _reason = "-";
                }
                else
                {
                    _reason = value;
                }
            }
        }
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
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Work_time_information (route_id, way_type, turnout, locomotive_reception, exit, pass, giving_time, work_finish_time, average_temperature, rest_overtime, reason) VALUES (@route, @way, @turnout, @reception, @exit, @pass, @giving, @finish, @temperature, @rest, @reason)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@route", _routeId);
                command.Parameters.AddWithValue("@way", _wayType);
                command.Parameters.AddWithValue("@turnout", _turnout);
                command.Parameters.AddWithValue("@reception", _locomotiveReception);
                command.Parameters.AddWithValue("@exit", _exit);
                command.Parameters.AddWithValue("@pass", _pass);
                command.Parameters.AddWithValue("@giving", _givingTime);
                command.Parameters.AddWithValue("@finish", _workFinishTime);
                command.Parameters.AddWithValue("@temperature", _averageTemperature);
                command.Parameters.AddWithValue("@rest", _restOvertime);
                command.Parameters.AddWithValue("@reason", _reason);
                command.ExecuteNonQuery();
            }
        }
    }
}
