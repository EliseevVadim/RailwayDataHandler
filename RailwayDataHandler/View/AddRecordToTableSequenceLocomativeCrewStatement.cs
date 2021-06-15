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
    public partial class AddRecordToTableSequenceLocomativeCrewStatement : Form
    {
        MainDataController dataController;
        List<string[]> routeInfo;
        Dictionary<string, string> stationsInfo;
        public AddRecordToTableSequenceLocomativeCrewStatement()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableSequenceStatementLocomativeCrew_Load(object sender, EventArgs e)
        {
            stationsInfo = dataController.GetStationsFullNamesAndIds();
            routeInfo = dataController.GetRouteInfo();
            foreach (string[] info in routeInfo)
            {
                routeIdBox.Items.Add(info[0]);
            }
            departureNameBox.Items.AddRange(stationsInfo.Keys.ToArray());
            arrivalNameBox.Items.AddRange(stationsInfo.Keys.ToArray());
        }
        private void routeIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberLabel.Text = routeInfo[routeIdBox.SelectedIndex][1];
            dateLabel.Text = routeInfo[routeIdBox.SelectedIndex][2].Substring(0, 10);
        }

        private void departureNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departureIdLabel.Text = stationsInfo[departureNameBox.Text];
        }

        private void arrivalNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrivalIdLabel.Text = stationsInfo[arrivalNameBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                SequenceLocomotiveCrewStatement sequenceLocomotiveCrewStatement = new SequenceLocomotiveCrewStatement();
                sequenceLocomotiveCrewStatement.ArrivalStationId = int.Parse(arrivalIdLabel.Text);
                sequenceLocomotiveCrewStatement.DepartureStationId = int.Parse(departureIdLabel.Text);
                sequenceLocomotiveCrewStatement.RouteId = int.Parse(routeIdBox.Text);
                sequenceLocomotiveCrewStatement.WayType = wayTypeBox.Text;
                sequenceLocomotiveCrewStatement.TrainNumber = int.Parse(trainNumberField.Text);
                sequenceLocomotiveCrewStatement.OrderNumber = int.Parse(orderNumberField.Text);
                sequenceLocomotiveCrewStatement.ArrivalTime = arrivalTimeField.Text;
                sequenceLocomotiveCrewStatement.DepartureTime = departureTimeField.Text;
                dataController.AddRecord(sequenceLocomotiveCrewStatement);
                MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Проверьте ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
