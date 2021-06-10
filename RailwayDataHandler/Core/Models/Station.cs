using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class Station : IDatabaseAgent
    {
        private int _nodeId;
        private string _shortName;
        private string _fullName;

        public int NodeId { get => _nodeId; set => _nodeId = value; }
        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public Station() { }

        public Station(int nodeId, string shortName, string fullName)
        {
            _nodeId = nodeId;
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
