using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using RailwayDataHandler.Core.Models;

namespace RailwayDataHandler.Core.Controller
{
    class MainDataController
    {
        private OleDbConnection _connection;
        private string _query;

        public MainDataController()
        {
            _connection = new OleDbConnection(DatabaseInformation.ConnectionString);
            _query = string.Empty;
        }
        public void AddRecord(IDatabaseAgent agent)
        {
            agent.AddToDatabase();
        }
        public DataTable LoadRoads()
        {
            _connection.Open();
            _query = "SELECT * FROM Road";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadNodes()
        {
            _connection.Open();
            _query = "SELECT * FROM Node";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadStations()
        {
            _connection.Open();
            _query = "SELECT * FROM Station";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadDepots()
        {
            _connection.Open();
            _query = "SELECT * FROM Depot";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadDrivers()
        {
            _connection.Open();
            _query = "SELECT * FROM Driver";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadLocomotives()
        {
            _connection.Open();
            _query = "SELECT * FROM Locomotive";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadBatches()
        {
            _connection.Open();
            _query = "SELECT * FROM Locomotive_batch";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadLighterReadings()
        {
            _connection.Open();
            _query = "SELECT * FROM Lighter_readings";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadSequenceCodes()
        {
            _connection.Open();
            _query = "SELECT * FROM Sequence_code";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadRoutes()
        {
            _connection.Open();
            _query = "SELECT depot_full_name AS [Депо приписки локомотива и локомотивной бригады], route_number AS [№ маршрута], " +
                "route_date AS [Дата маршрута], drivers_name AS [ФИО машиниста], drivers_category AS [Класс машиниста]," +
                "batch_short_name AS [Серия локомотива], locomotive_number AS [Номер локомотива] " +
                "FROM (((Depot INNER JOIN Locomotive ON Depot.id = Locomotive.depot_id) " +
                "INNER JOIN Route ON Route.locomotive_id = Locomotive.id) " +
                "INNER JOIN Driver ON Route.drivers_id = Driver.id) " +
                "INNER JOIN Locomotive_batch ON Locomotive.batch_id = Locomotive_batch.id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadWorkTimeInformation()
        {
            _connection.Open();
            _query = "SELECT route_number AS [№ маршрута], route_date AS [Дата маршрута], way_type AS [Путь следования], turnout AS Явка, " +
                "locomotive_reception AS [Прием локомотива], exit AS Выход, pass AS Заход, giving_time AS Сдача, " +
                "work_finish_time AS [Конец работы], average_temperature AS [Среднесуточная температура воздуха]," +
                "rest_overtime AS [Время переотдыха], reason AS [Причина не предоставления отдыха локомотивной бригаде] " +
                "FROM Route INNER JOIN Work_time_information ON Route.id = Work_time_information.route_id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadLocomotiveStatement()
        {
            _connection.Open();
            _query = "SELECT ls.id AS [№ п/п], route_number AS [№ маршрута], route_date AS [Дата маршрута], sequence_value AS [Код следования], " +
                "batch_short_name + \'-\' + locomotive_number AS [Серия и номер локомотива]," +
                "depot_short_name AS [Депо приписки локомотива], dep.station_full_name AS [Станция отправления]," +
                "arr.station_full_name AS [Станция прибытия]" +
                "FROM ((((((Locomotive_statement ls INNER JOIN Sequence_code ON ls.sequence_code_id = Sequence_code.id)" +
                "INNER JOIN Route ON ls.route_id = Route.id)" +
                "INNER JOIN Locomotive ON ls.locomotive_id = Locomotive.id)" +
                "INNER JOIN Depot ON Locomotive.depot_id = Depot.id)" +
                "INNER JOIN Locomotive_batch ON Locomotive.batch_id = Locomotive_batch.id)" +
                "INNER JOIN Station dep ON ls.departure_station_id = dep.id)" +
                "INNER JOIN Station arr ON ls.arrival_station_id = arr.id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadSequenceLocomotiveCrewStatement()
        {
            _connection.Open();
            _query = "SELECT route_number AS [№ маршрута], route_date AS [Дата маршрута], way_type AS [Путь следования], dep.station_full_name AS [Станция отправления], " +
                "departure_time AS [Время отправления], arr.station_full_name AS [Станция прибытия], arrival_time AS [Время прибытия]," +
                "order_number AS [№ приказа], train_number AS [№ поезда] " +
                "FROM ((Sequence_locomotive_crew_statement INNER JOIN Station dep ON Sequence_locomotive_crew_statement.departure_station_id = dep.id)" +
                "INNER JOIN Route ON  Sequence_locomotive_crew_statement.route_id = Route.id)" +
                "INNER JOIN Station arr ON Sequence_locomotive_crew_statement.arrival_station_id = arr.id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadALSNStatement()
        {
            _connection.Open();
            _query = "SELECT ALSN_statement.id AS [№ п/п], route_number AS [№ маршрута], route_date AS [Дата маршрута], kilometer AS [Километр], " +
                "coloumn AS [пикет], section_number AS [Номер секции], alsn.short_name AS [Показание АЛСН]," +
                "l.short_name AS [Показание участкового светофора] " +
                "FROM ((ALSN_statement INNER JOIN Lighter_readings l ON ALSN_statement.lighter_readings_id = l.id)" +
                "INNER JOIN Route ON ALSN_statement.route_id = route.id)" +
                "INNER JOIN Lighter_readings alsn ON ALSN_statement.ALSN_reading_id = alsn.id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable LoadExpenceStatement()
        {
            _connection.Open();
            _query = "SELECT route_number AS [№ маршрута], route_date AS [Дата маршрута], way_type AS [Путь следования], section_number AS [№ секции], " +
                "accept_traction AS [Тяга (принял)], giving_traction AS [Тяга (Сдал)], accept_heating AS [Отопление (принял)], " +
                "giving_heating AS [Отопление (сдал)] " +
                "FROM Expence_statement INNER JOIN Route ON Expence_statement.route_id = Route.id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public Dictionary<string, string> GetRoadNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT road_name, id FROM Road";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetNodeNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT node_short_name, id FROM Node";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetStationShortNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT station_short_name, id FROM Station";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetDepotNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT depot_short_name, id FROM Depot";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetBatchNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT batch_short_name, id FROM Locomotive_batch";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public List<string> GetLocomotiveIds()
        {
            _connection.Open();
            _query = "SELECT id FROM Locomotive";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            List<string> ids = new List<string>();
            while (reader.Read())
            {
                ids.Add(reader[0].ToString());
            }
            _connection.Close();
            return ids;
        }
        public Dictionary<string, string> GetDriverNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT drivers_name, id FROM Driver";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public List<string[]> GetRouteInfo()
        {
            _connection.Open();
            _query = "SELECT id, route_number, route_date FROM Route";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            List<string[]> tuples = new List<string[]>();
            while (reader.Read())
            {
                tuples.Add(new string[3]{ reader[0].ToString(), reader[1].ToString(), reader[2].ToString()});
            }
            _connection.Close();
            return tuples;
        }
        public Dictionary<string, string> GetLightsNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT short_name, id FROM Lighter_readings";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetStationsFullNamesAndIds()
        {
            _connection.Open();
            _query = "SELECT station_full_name, id FROM Station";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetLocomotiveInfo()
        {
            _connection.Open();
            _query = "SELECT Locomotive.id, batch_short_name + \'-\' + locomotive_number " +
                "FROM Locomotive INNER JOIN Locomotive_batch ON Locomotive.batch_id = Locomotive_batch.id";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public Dictionary<string, string> GetSequenceInfo()
        {
            _connection.Open();
            _query = "SELECT sequence_value, id FROM Sequence_code";
            OleDbCommand command = new OleDbCommand(_query, _connection);
            var reader = command.ExecuteReader();
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (reader.Read())
            {
                pairs.Add(reader[0].ToString(), reader[1].ToString());
            }
            _connection.Close();
            return pairs;
        }
        public DataTable FindRoute(string number, DateTime date)
        {
            _connection.Open();
            _query = "SELECT depot_full_name AS [Депо приписки локомотива и локомотивной бригады], route_number AS [№ маршрута], " +
                "route_date AS [Дата маршрута], drivers_name AS [ФИО машиниста], drivers_category AS [Класс машиниста]," +
                "batch_short_name AS [Серия локомотива], locomotive_number AS [Номер локомотива] " +
                "FROM (((Depot INNER JOIN Locomotive ON Depot.id = Locomotive.depot_id) " +
                "INNER JOIN Route ON Route.locomotive_id = Locomotive.id) " +
                "INNER JOIN Driver ON Route.drivers_id = Driver.id) " +
                "INNER JOIN Locomotive_batch ON Locomotive.batch_id = Locomotive_batch.id " +
                $"WHERE route_number = \'{number}\' " +
                $"AND route_date = format(\'{date.ToShortDateString()}\', \"dd.mm.yyyy\")";
            DataTable searchResults = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(_query, _connection);
            dataAdapter.Fill(searchResults);
            _connection.Close();
            return searchResults;
        }
    }
}
