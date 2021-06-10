using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class Depot : IDatabaseAgent
    {
        private int _stationId;
        private string _shortName;
        private string _fullName;

        public int StationId { get => _stationId; set => _stationId = value; }
        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public Depot() { }

        public Depot(int stationId, string shortName, string fullName)
        {
            _stationId = stationId;
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
