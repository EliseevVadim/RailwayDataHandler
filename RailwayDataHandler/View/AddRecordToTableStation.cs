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
    public partial class AddRecordToTableStation : Form
    {
        MainDataController dataController;
        Dictionary<string, string> pairs;
        public AddRecordToTableStation()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableStation_Load(object sender, EventArgs e)
        {
            try
            {
                pairs = dataController.GetNodeNamesAndIds();
                nodeNameBox.Items.AddRange(pairs.Keys.ToArray());
            }
            catch
            {

            }
        }

        private void nodeNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLabel.Text = pairs[nodeNameBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Station station = new Station(int.Parse(idLabel.Text), stationShortNameField.Text, stationFullNameField.Text);
                station.AddToDatabase();
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
