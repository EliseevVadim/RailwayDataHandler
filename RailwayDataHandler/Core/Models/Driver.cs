using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class Driver : IDatabaseAgent
    {
        private string _name;
        private int _category;

        public string Name { get => _name; set => _name = value; }
        public int Category { get => _category; set => _category = value; }

        public Driver() { }

        public Driver(string name, int category)
        {
            _name = name;
            _category = category;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
