using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class Road : IDatabaseAgent
    {
        private string _name;
        private string _description;

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        public Road() { }

        public Road(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
