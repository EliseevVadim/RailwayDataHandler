using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDataHandler.Core.Exceptions
{
    class EqualDepartureAndArrivalStationsException : Exception
    {
        public EqualDepartureAndArrivalStationsException(string message):
            base(message)
        { }
    }
}
