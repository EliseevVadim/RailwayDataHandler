using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RailwayDataHandler.Core.Models;
using RailwayDataHandler.Core.Controller;

namespace RailwayDataHandler.View
{
    public partial class AddRecordToTableRoad : Form
    {
        public AddRecordToTableRoad()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                Road road = new Road(roadShortNameField.Text, roadDescriptionField.Text);
                MainDataController dataController = new MainDataController();
                dataController.AddRecord(road);
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
