using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RailwayDataHandler.Core.Controller;
using RailwayDataHandler.Core.Models;

namespace RailwayDataHandler.View
{
    public partial class AddRecordToTableLocomotiveStatement : Form
    {
        MainDataController dataController;
        Dictionary<string, string> locomotiveInfo;
        Dictionary<string, string> depotInfo;
        Dictionary<string, string> stationsInfo;
        Dictionary<string, string> sequenceInfo;
        List<string[]> routeInfo;
        public AddRecordToTableLocomotiveStatement()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableLocomotiveStatement_Load(object sender, EventArgs e)
        {
            try
            {
                locomotiveInfo = dataController.GetLocomotiveInfo();
                depotInfo = dataController.GetDepotNamesAndIds();
                stationsInfo = dataController.GetStationsFullNamesAndIds();
                routeInfo = dataController.GetRouteInfo();
                sequenceInfo = dataController.GetSequenceInfo();
                foreach (string[] info in routeInfo)
                {
                    routeIdBox.Items.Add(info[0]);
                }
                locomotiveIdBox.Items.AddRange(locomotiveInfo.Keys.ToArray());
                depotBox.Items.AddRange(depotInfo.Keys.ToArray());
                depertureStationBox.Items.AddRange(stationsInfo.Keys.ToArray());
                arrivalStationBox.Items.AddRange(stationsInfo.Keys.ToArray());
                sequenceCodesBox.Items.AddRange(sequenceInfo.Keys.ToArray());
            }
            catch
            {

            }
        }

        private void routeIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberLabel.Text = routeInfo[routeIdBox.SelectedIndex][1];
            dateLabel.Text = routeInfo[routeIdBox.SelectedIndex][2].Substring(0, 10);
        }

        private void locomotiveIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            batchAndNumLabel.Text = locomotiveInfo[locomotiveIdBox.Text];
        }

        private void depotBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            depotIdLabel.Text = depotInfo[depotBox.Text];
        }

        private void depertureStationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departureIdLabel.Text = stationsInfo[depertureStationBox.Text];
        }

        private void arrivalStationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrivalIdLabel.Text = stationsInfo[arrivalStationBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                LocomotiveStatement locomotiveStatement = new LocomotiveStatement();
                locomotiveStatement.ArrivalStationId = int.Parse(arrivalIdLabel.Text);
                locomotiveStatement.DepartureStationId = int.Parse(departureIdLabel.Text);
                locomotiveStatement.SequenceCodeId = int.Parse(sequenceCodeLabel.Text);
                locomotiveStatement.LocomotiveId = int.Parse(locomotiveIdBox.Text);
                locomotiveStatement.RouteId = int.Parse(routeIdBox.Text);
                locomotiveStatement.AddToDatabase();
                MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Проверьте ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sequenceCodesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sequenceCodeLabel.Text = sequenceInfo[sequenceCodesBox.Text];
        }
    }
}
