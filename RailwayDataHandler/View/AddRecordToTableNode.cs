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
    public partial class AddRecordToTableNode : Form
    {
        MainDataController dataController;
        Dictionary<string, string> pairs;
        public AddRecordToTableNode()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecordToTableNode_Load(object sender, EventArgs e)
        {
            try
            {
                pairs = dataController.GetRoadNamesAndIds();
                roadNameBox.Items.AddRange(pairs.Keys.ToArray());
            }
            catch
            {
                
            }
        }

        private void roadNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLabel.Text = pairs[roadNameBox.Text];
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Node node = new Node(int.Parse(idLabel.Text), nodeShortNameField.Text, nodeFullNameField.Text);
                node.AddToDatabase();
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
