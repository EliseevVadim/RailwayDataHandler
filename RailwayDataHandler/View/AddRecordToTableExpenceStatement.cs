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
    public partial class AddRecordToTableExpenceStatement : Form
    {
        MainDataController dataController;
        List<string[]> routeInfo;
        public AddRecordToTableExpenceStatement()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableExpenceStatement_Load(object sender, EventArgs e)
        {
            routeInfo = dataController.GetRouteInfo();
            foreach (string[] info in routeInfo)
            {
                routeIdBox.Items.Add(info[0]);
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
                ExpenceStatement expenceStatement = new ExpenceStatement();
                expenceStatement.RouteId = int.Parse(routeIdBox.Text);
                expenceStatement.AcceptTraction = double.Parse(acceptTractionField.Text);
                expenceStatement.AcceptHeating = double.Parse(acceptHeatingField.Text);
                expenceStatement.GivingTraction = double.Parse(givingTractionField.Text);
                expenceStatement.GivingHeating = double.Parse(givingHeatingField.Text);
                expenceStatement.WayType = wayTypeBox.Text;
                expenceStatement.SectionNumber = int.Parse(sectionNumberField.Text);
                expenceStatement.AddToDatabase();
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
