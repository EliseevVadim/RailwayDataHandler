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
    public partial class AddRecordToTableDriver : Form
    {
        public AddRecordToTableDriver()
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
                Driver driver = new Driver(driversNameField.Text, int.Parse(driversCategoryField.Text));
                MainDataController dataController = new MainDataController();
                dataController.AddRecord(driver);
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
