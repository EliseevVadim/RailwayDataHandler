using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace RailwayDataHandler.Core.Models
{
    static class DatabaseInformation
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public static string ConnectionString { get => _connectionString; set => _connectionString = value; }
    }
}
