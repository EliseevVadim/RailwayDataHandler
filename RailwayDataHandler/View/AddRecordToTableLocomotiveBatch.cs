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
    public partial class AddRecordToTableLocomotiveBatch : Form
    {
        public AddRecordToTableLocomotiveBatch()
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
                LocomotiveBatch batch = new LocomotiveBatch(batchShortNameField.Text, batchFullNameField.Text);
                batch.AddToDatabase();
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
