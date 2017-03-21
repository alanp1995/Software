﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmTerminateRoute : Form
    {
        private Form Parent;

        public frmTerminateRoute()
        {
            InitializeComponent();
        }

        public frmTerminateRoute(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Called when the form is loaded
        private void frmTerminateRoute_Load(object sender, EventArgs e)
        {
            // Populating the Combo Boxes for selecting Routes
            DataSet ds = new DataSet();

            DataTable dt = Routes.getActiveRoutes(ds, "departStation").Tables["Routes"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbRoutes.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " DEP: " + String.Format("{0,-20}",dr["departStation"]) + " ARR: " + dr["arrivalStation"]);
            }
        }

        private void mnuTerminateRouteBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuTerminateRouteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Routes aRoute = new Routes();
            aRoute.getRoute(Convert.ToInt32(cmbRoutes.Text.Substring(0, 5)));

            grpUpdate.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;

            // Populate The Text Boxes For Updating

            DataTable dt;
            
            txtRouteID.Text = aRoute.getRouteID().ToString("00000");

            dt = Station.getAStation(aRoute.getDepartStation());
            foreach (DataRow dr in dt.Rows)
                txtDepSt.Text = dr[0].ToString();

            dt = Station.getAStation(aRoute.getArrivalStation());
            foreach (DataRow dr in dt.Rows)
                txtArrSt.Text = dr[0].ToString();

            txtDistance.Text = aRoute.getDistance().ToString();
            txtStatus.Text = aRoute.getStatus().ToString();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
            cmbRoutes.Text = "Choose Route";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // Station Status
            char routeStatus = 'T';

            // Update Station Object
            Routes.updateRoute(
                Convert.ToInt32(txtRouteID.Text),
                txtDepSt.Text,
                txtArrSt.Text,
                Convert.ToDouble(txtDistance.Text),
                routeStatus);

            // Display Confirmation
            MessageBox.Show("Route Terminated Successfully");

            // Update Visibility
            grpUpdate.Visible = false;
            cmbRoutes.Text = "Choose Route";
        }
    }
}
