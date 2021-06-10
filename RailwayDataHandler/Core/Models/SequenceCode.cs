using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Models
{
    class SequenceCode : IDatabaseAgent
    {
        private string _sequenceValue;
        private string _fullName;

        public string SequenceValue { get => _sequenceValue; set => _sequenceValue = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

        public SequenceCode() { }

        public SequenceCode(string sequenceValue, string fullName)
        {
            _sequenceValue = sequenceValue;
            _fullName = fullName;
        }

        public void AddToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
