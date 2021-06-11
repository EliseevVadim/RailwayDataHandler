using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

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
            using (OleDbConnection connection = new OleDbConnection(DatabaseInformation.ConnectionString))
            {
                connection.Open();
                string query = string.Format(@"INSERT INTO Route (locomotive_id, drivers_id, route_number, route_date) VALUES (@locomotive, @driver, @route, @date)");
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@locomotive", _locomotiveId);
                command.Parameters.AddWithValue("@driver", _driversId);
                command.Parameters.AddWithValue("@route", _routeNumber);
                command.Parameters.AddWithValue("@date", _date);
                command.ExecuteNonQuery();
            }
        }
    }
}
