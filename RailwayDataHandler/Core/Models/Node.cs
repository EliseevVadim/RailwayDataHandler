using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class Node : IDatabaseAgent
    {
        private int _routeId;
        private string _shortName;
        private string _fullName;

        public int RouteId { get => _routeId; set => _routeId = value; }
        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public Node() { }

        public Node(int routeId, string shortName, string fullName)
        {
            _routeId = routeId;
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
