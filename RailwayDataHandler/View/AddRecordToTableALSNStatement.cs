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
    public partial class AddRecordToTableALSNStatement : Form
    {
        MainDataController dataController;
        List<string[]> routeInfo;
        Dictionary<string, string> lighterPairs;
        public AddRecordToTableALSNStatement()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableALSNStatement_Load(object sender, EventArgs e)
        {
            try
            {
                routeInfo = dataController.GetRouteInfo();
                foreach (string[] info in routeInfo)
                {
                    routeIdBox.Items.Add(info[0]);
                }
                lighterPairs = dataController.GetLightsNamesAndIds();
                alsnBox.Items.AddRange(lighterPairs.Keys.ToArray());
                lighterBox.Items.AddRange(lighterPairs.Keys.ToArray());
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

        private void alsnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alsnId.Text = lighterPairs[alsnBox.Text];
        }

        private void lighterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lighterReadingId.Text = lighterPairs[lighterBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                ALSNStatement statement = new ALSNStatement();
                statement.AlsnReadingId = int.Parse(alsnId.Text);
                statement.Coloumn = int.Parse(columnField.Text);
                statement.Kilometer = int.Parse(kilometerField.Text);
                statement.LighterReadingsId = int.Parse(lighterReadingId.Text);
                statement.RouteId = int.Parse(routeIdBox.Text);
                statement.SectionNumber = int.Parse(sectionNumberField.Text);
                dataController.AddRecord(statement);
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
