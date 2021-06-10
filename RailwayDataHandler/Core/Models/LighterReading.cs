﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class LighterReading : IDatabaseAgent
    {
        private string _shortName;
        private string _fullName;

        public string ShortName { get => _shortName; set => _shortName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public LighterReading() { }

        public LighterReading(string shortName, string fullName)
        {
            _shortName = shortName;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}