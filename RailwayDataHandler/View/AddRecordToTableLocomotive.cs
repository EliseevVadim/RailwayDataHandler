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
    public partial class AddRecordToTableLocomotive : Form
    {
        MainDataController dataController;
        Dictionary<string, string> depotPairs;
        Dictionary<string, string> batchPairs;
        public AddRecordToTableLocomotive()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableLocomotive_Load(object sender, EventArgs e)
        {
            try
            {
                batchPairs = dataController.GetBatchNamesAndIds();
                depotPairs = dataController.GetDepotNamesAndIds();
                depotNameBox.Items.AddRange(depotPairs.Keys.ToArray());
                batchNameBox.Items.AddRange(batchPairs.Keys.ToArray());
            }
            catch
            {

            }
        }

        private void depotNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            depotIdLabel.Text = depotPairs[depotNameBox.Text];
        }

        private void batchNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            batchIdLabel.Text = batchPairs[batchNameBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Locomotive locomotive = new Locomotive(int.Parse(depotIdLabel.Text), int.Parse(batchIdLabel.Text), locomotiveNumberField.Text, int.Parse(sectionNumberField.Text));
                dataController.AddRecord(locomotive);
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
