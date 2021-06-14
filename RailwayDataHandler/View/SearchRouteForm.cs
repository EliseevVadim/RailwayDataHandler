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
    public partial class SearchRouteForm : Form
    {
        MainDataController dataController;
        public SearchRouteForm()
        {
            InitializeComponent();
            dataController = new MainDataController();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable result = dataController.FindRoute(routeNumberField.Text, routesDate.Value.Date);
            Transferer.SendedInformation = result;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
