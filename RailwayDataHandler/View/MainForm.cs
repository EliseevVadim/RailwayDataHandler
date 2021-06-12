using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using RailwayDataHandler.Core.Models;
using RailwayDataHandler.Core.Controller;

namespace RailwayDataHandler.View
{
    public partial class MainForm : Form
    {
        MainDataController dataController; 
        public MainForm()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            roadsView.DataSource = dataController.LoadRoads();
            nodesView.DataSource = dataController.LoadNodes();
            stationsView.DataSource = dataController.LoadStations();
            depotsView.DataSource = dataController.LoadDepots();
            driversView.DataSource = dataController.LoadDrivers();
            lighterReadingsView.DataSource = dataController.LoadLighterReadings();
            locomotivesView.DataSource = dataController.LoadLocomotives();
            batchesView.DataSource = dataController.LoadBatches();
            sequenceCodesView.DataSource = dataController.LoadSequenceCodes();
            routesView.DataSource = dataController.LoadRoutes();
            workTimesView.DataSource = dataController.LoadWorkTimeInformation();
            locomotiveStatementView.DataSource = dataController.LoadLocomotiveStatement();
            locomotiveCrewStatementView.DataSource = dataController.LoadSequenceLocomotiveCrewStatement();
            alsnStatementView.DataSource = dataController.LoadALSNStatement();
            expenceStatementView.DataSource = dataController.LoadExpenceStatement();
        }
    }
}
