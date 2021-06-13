using RailwayDataHandler.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RailwayDataHandler.View
{
    public partial class AddRecordToTableLightReadings : Form
    {
        public AddRecordToTableLightReadings()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                LighterReading reading = new LighterReading(readingShortNameField.Text, readingFullNameField.Text);
                reading.AddToDatabase();
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
