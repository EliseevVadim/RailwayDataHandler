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

        private void buttonAddRecordToTableRoad_Click(object sender, EventArgs e)
        {
            AddRecordToTableRoad addRecordToTableRoad = new AddRecordToTableRoad();
            if (addRecordToTableRoad.ShowDialog() == DialogResult.OK)
            {
                roadsView.DataSource = dataController.LoadRoads();
            }
        }

        private void buttonAddRecordToTableNode_Click(object sender, EventArgs e)
        {
            AddRecordToTableNode addRecordToTableNode = new AddRecordToTableNode();
            if (addRecordToTableNode.ShowDialog() == DialogResult.OK)
            {
                nodesView.DataSource = dataController.LoadNodes();
            }
        }

        private void buttonAddRecordToTableStation_Click(object sender, EventArgs e)
        {
            AddRecordToTableStation addRecordToTableStation = new AddRecordToTableStation();
            if (addRecordToTableStation.ShowDialog() == DialogResult.OK)
            {
                stationsView.DataSource = dataController.LoadStations();
            }
        }

        private void buttonAddRecordToTableDepot_Click(object sender, EventArgs e)
        {
            AddRecordToTableDepot addRecordToTableDepot = new AddRecordToTableDepot();
            if (addRecordToTableDepot.ShowDialog() == DialogResult.OK)
            {
                depotsView.DataSource = dataController.LoadDepots();
            }
        }

        private void buttonAddRecordToTableLocomotive_Click(object sender, EventArgs e)
        {
            AddRecordToTableLocomotive addRecordToTableLocomotive = new AddRecordToTableLocomotive();
            if (addRecordToTableLocomotive.ShowDialog() == DialogResult.OK)
            {
                locomotivesView.DataSource = dataController.LoadLocomotives();
            }
        }

        private void buttonAddRecordToTableDriver_Click(object sender, EventArgs e)
        {
            AddRecordToTableDriver addRecordToTableDriver = new AddRecordToTableDriver();
            if (addRecordToTableDriver.ShowDialog() == DialogResult.OK)
            {
                driversView.DataSource = dataController.LoadDrivers();
            }
        }

        private void buttonAddRecordToTableLocomativeBatch_Click(object sender, EventArgs e)
        {
            AddRecordToTableLocomotiveBatch addRecordToTableLocomotiveBatch = new AddRecordToTableLocomotiveBatch();
            if (addRecordToTableLocomotiveBatch.ShowDialog() == DialogResult.OK)
            {
                batchesView.DataSource = dataController.LoadBatches();
            }
        }

        private void buttonAddRecordToTableSequenceCode_Click(object sender, EventArgs e)
        {
            AddRecordToTableSequenceCode addRecordToTableSequenceCode = new AddRecordToTableSequenceCode();
            if (addRecordToTableSequenceCode.ShowDialog() == DialogResult.OK)
            {
                sequenceCodesView.DataSource = dataController.LoadSequenceCodes();
            }
        }

        private void buttonAddRecordToTableWorkTimeInformation_Click(object sender, EventArgs e)
        {
            AddRecordToTableWorkTimeInformation addRecordToTableWorkTimeInformation = new AddRecordToTableWorkTimeInformation();
            if (addRecordToTableWorkTimeInformation.ShowDialog() == DialogResult.OK)
            {
                workTimesView.DataSource = dataController.LoadWorkTimeInformation();
            }
        }

        private void buttonAddRecordToTableRoute_Click(object sender, EventArgs e)
        {
            AddRecordToTableRoute addRecordToTableRoute = new AddRecordToTableRoute();
            if (addRecordToTableRoute.ShowDialog() == DialogResult.OK)
            {
                routesView.DataSource = dataController.LoadRoutes();
            }
        }

        private void buttonAddRecordToTableLightReadings_Click(object sender, EventArgs e)
        {
            AddRecordToTableLightReadings addRecordToTableLightReadings = new AddRecordToTableLightReadings();
            if (addRecordToTableLightReadings.ShowDialog() == DialogResult.OK)
            {
                lighterReadingsView.DataSource = dataController.LoadLighterReadings();
            }
        }

        private void buttonAddRecordToTableExpenceStatement_Click(object sender, EventArgs e)
        {
            AddRecordToTableExpenceStatement addRecordToTableExpenceStatement = new AddRecordToTableExpenceStatement();
            if (addRecordToTableExpenceStatement.ShowDialog() == DialogResult.OK)
            {
                expenceStatementView.DataSource = dataController.LoadExpenceStatement();
            }
        }

        private void buttonAddRecordToTableSequenceStatementLocomativeCrew_Click(object sender, EventArgs e)
        {
            AddRecordToTableSequenceStatementLocomativeCrew addRecordToTableSequenceStatementLocomativeCrew = new AddRecordToTableSequenceStatementLocomativeCrew();
            if (addRecordToTableSequenceStatementLocomativeCrew.ShowDialog() == DialogResult.OK)
            {
                locomotiveCrewStatementView.DataSource = dataController.LoadSequenceLocomotiveCrewStatement();
            }
        }

        private void buttonAddRecordToTableLocomotive_statement_Click(object sender, EventArgs e)
        {
            AddRecordToTableLocomotiveStatement addRecordToTableLocomotiveStatement = new AddRecordToTableLocomotiveStatement();
            if (addRecordToTableLocomotiveStatement.ShowDialog() == DialogResult.OK)
            {
                locomotiveStatementView.DataSource = dataController.LoadLocomotiveStatement();
            }
        }

        private void buttonAddRecordToTableALSNStatement_Click(object sender, EventArgs e)
        {
            AddRecordToTableALSNStatement addRecordToTableALSNStatement = new AddRecordToTableALSNStatement();
            if (addRecordToTableALSNStatement.ShowDialog() == DialogResult.OK)
            {
                alsnStatementView.DataSource = dataController.LoadALSNStatement();
            }
        }
    }
}
