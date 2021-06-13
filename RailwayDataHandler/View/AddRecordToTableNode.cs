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
    public partial class AddRecordToTableNode : Form
    {
        public AddRecordToTableNode()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
