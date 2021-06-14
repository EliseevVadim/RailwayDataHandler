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
    public partial class AddRecordToTableWorkTimeInformation : Form
    {
        MainDataController dataController;
        List<string[]> routeInfo;
        public AddRecordToTableWorkTimeInformation()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableWorkTimeInformation_Load(object sender, EventArgs e)
        {
            try
            {
                routeInfo = dataController.GetRouteInfo();
                foreach(string[] info in routeInfo)
                {
                    routeIdBox.Items.Add(info[0]);
                }
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

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                WorkTimeInformation workTimeInformation = new WorkTimeInformation();
                workTimeInformation.RouteId = int.Parse(routeIdBox.Text);
                workTimeInformation.WayType = wayTypeBox.Text;
                workTimeInformation.Turnout = turnoutField.Text;
                workTimeInformation.LocomotiveReception = locomotiveReceptionField.Text;
                workTimeInformation.Exit = exitField.Text;
                workTimeInformation.Pass = passField.Text;
                workTimeInformation.GivingTime = givingTimeField.Text;
                workTimeInformation.WorkFinishTime = workFinishTimeField.Text;
                workTimeInformation.AverageTemperature = double.Parse(avarageTemperatureField.Text);
                workTimeInformation.RestOvertime = restOverTimeField.Text;
                workTimeInformation.Reason = reasonField.Text;
                workTimeInformation.AddToDatabase();
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
