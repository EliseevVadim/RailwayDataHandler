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
    public partial class AddRecordToTableDepot : Form
    {
        MainDataController dataController;
        Dictionary<string, string> pairs;
        public AddRecordToTableDepot()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableDepot_Load(object sender, EventArgs e)
        {
            try
            {
                pairs = dataController.GetStationShortNamesAndIds();
                stationNameBox.Items.AddRange(pairs.Keys.ToArray());
            }
            catch
            {

            }
        }

        private void stationNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLabel.Text = pairs[stationNameBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Depot depot = new Depot(int.Parse(idLabel.Text), depotShortNameField.Text, depotFullNameField.Text);
                depot.AddToDatabase();
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
