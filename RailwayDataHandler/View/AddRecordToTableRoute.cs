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
    public partial class AddRecordToTableRoute : Form
    {
        MainDataController dataController;
        List<string> locomotiveIds;
        Dictionary<string, string> driversPairs;
        public AddRecordToTableRoute()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableRoute_Load(object sender, EventArgs e)
        {
            try
            {
                locomotiveIds = dataController.GetLocomotiveIds();
                driversPairs = dataController.GetDriverNamesAndIds();
                locomativeIdBox.Items.AddRange(locomotiveIds.ToArray());
                driversNameBox.Items.AddRange(driversPairs.Keys.ToArray());
            }
            catch
            {

            }
        }

        private void driversNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            driversIdLabel.Text = driversPairs[driversNameBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Route route = new Route(int.Parse(locomativeIdBox.Text), int.Parse(driversIdLabel.Text), routeNumberField.Text, routesDate.Value.Date);
                route.AddToDatabase();
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
