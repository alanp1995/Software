﻿namespace TrainTicketSys
{
    partial class frmTerminateRoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuStripTerminateRoute = new System.Windows.Forms.MenuStrip();
            this.mnuTerminateRouteBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateRouteExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbRoutes = new System.Windows.Forms.ComboBox();
            this.routeIDTerminateRoute = new System.Windows.Forms.Label();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtArrSt = new System.Windows.Forms.TextBox();
            this.lblArrSt = new System.Windows.Forms.Label();
            this.txtDepSt = new System.Windows.Forms.TextBox();
            this.lblDepSt = new System.Windows.Forms.Label();
            this.mnuStripTerminateRoute.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripTerminateRoute
            // 
            this.mnuStripTerminateRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripTerminateRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTerminateRouteBack,
            this.mnuTerminateRouteExit});
            this.mnuStripTerminateRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuStripTerminateRoute.Name = "mnuStripTerminateRoute";
            this.mnuStripTerminateRoute.Size = new System.Drawing.Size(624, 27);
            this.mnuStripTerminateRoute.TabIndex = 2;
            this.mnuStripTerminateRoute.Text = "menuStrip1";
            // 
            // mnuTerminateRouteBack
            // 
            this.mnuTerminateRouteBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTerminateRouteBack.Name = "mnuTerminateRouteBack";
            this.mnuTerminateRouteBack.Size = new System.Drawing.Size(53, 23);
            this.mnuTerminateRouteBack.Text = "Back";
            this.mnuTerminateRouteBack.Click += new System.EventHandler(this.mnuTerminateRouteBack_Click);
            // 
            // mnuTerminateRouteExit
            // 
            this.mnuTerminateRouteExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTerminateRouteExit.Name = "mnuTerminateRouteExit";
            this.mnuTerminateRouteExit.Size = new System.Drawing.Size(47, 23);
            this.mnuTerminateRouteExit.Text = "Exit";
            this.mnuTerminateRouteExit.Click += new System.EventHandler(this.mnuTerminateRouteExit_Click);
            // 
            // cmbRoutes
            // 
            this.cmbRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRoutes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoutes.FormattingEnabled = true;
            this.cmbRoutes.Location = new System.Drawing.Point(125, 42);
            this.cmbRoutes.Name = "cmbRoutes";
            this.cmbRoutes.Size = new System.Drawing.Size(407, 21);
            this.cmbRoutes.TabIndex = 13;
            this.cmbRoutes.SelectedIndexChanged += new System.EventHandler(this.cmbRoutes_SelectedIndexChanged);
            // 
            // routeIDTerminateRoute
            // 
            this.routeIDTerminateRoute.AutoSize = true;
            this.routeIDTerminateRoute.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeIDTerminateRoute.Location = new System.Drawing.Point(12, 44);
            this.routeIDTerminateRoute.Name = "routeIDTerminateRoute";
            this.routeIDTerminateRoute.Size = new System.Drawing.Size(107, 19);
            this.routeIDTerminateRoute.TabIndex = 12;
            this.routeIDTerminateRoute.Text = "Choose Route";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtStatus);
            this.grpUpdate.Controls.Add(this.btnNo);
            this.grpUpdate.Controls.Add(this.btnYes);
            this.grpUpdate.Controls.Add(this.lblWarning);
            this.grpUpdate.Controls.Add(this.txtRouteID);
            this.grpUpdate.Controls.Add(this.lblRouteID);
            this.grpUpdate.Controls.Add(this.lblStatus);
            this.grpUpdate.Controls.Add(this.txtDistance);
            this.grpUpdate.Controls.Add(this.lblDistance);
            this.grpUpdate.Controls.Add(this.txtArrSt);
            this.grpUpdate.Controls.Add(this.lblArrSt);
            this.grpUpdate.Controls.Add(this.txtDepSt);
            this.grpUpdate.Controls.Add(this.lblDepSt);
            this.grpUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdate.Location = new System.Drawing.Point(16, 90);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(596, 219);
            this.grpUpdate.TabIndex = 14;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Terminate Route";
            this.grpUpdate.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(370, 58);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(180, 23);
            this.txtStatus.TabIndex = 18;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(346, 166);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(99, 27);
            this.btnNo.TabIndex = 17;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(451, 166);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(99, 27);
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(254, 147);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(296, 16);
            this.lblWarning.TabIndex = 16;
            this.lblWarning.Text = "Are You Sure You Want To Terminate This Route?";
            // 
            // txtRouteID
            // 
            this.txtRouteID.Enabled = false;
            this.txtRouteID.Location = new System.Drawing.Point(94, 26);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(180, 23);
            this.txtRouteID.TabIndex = 15;
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Location = new System.Drawing.Point(15, 29);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(62, 16);
            this.lblRouteID.TabIndex = 14;
            this.lblRouteID.Text = "Route ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(303, 61);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Location = new System.Drawing.Point(370, 26);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(180, 23);
            this.txtDistance.TabIndex = 5;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(303, 29);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(61, 16);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance:";
            // 
            // txtArrSt
            // 
            this.txtArrSt.Enabled = false;
            this.txtArrSt.Location = new System.Drawing.Point(94, 90);
            this.txtArrSt.Name = "txtArrSt";
            this.txtArrSt.Size = new System.Drawing.Size(180, 23);
            this.txtArrSt.TabIndex = 3;
            // 
            // lblArrSt
            // 
            this.lblArrSt.AutoSize = true;
            this.lblArrSt.Location = new System.Drawing.Point(15, 93);
            this.lblArrSt.Name = "lblArrSt";
            this.lblArrSt.Size = new System.Drawing.Size(28, 16);
            this.lblArrSt.TabIndex = 2;
            this.lblArrSt.Text = "To:";
            // 
            // txtDepSt
            // 
            this.txtDepSt.Enabled = false;
            this.txtDepSt.Location = new System.Drawing.Point(94, 58);
            this.txtDepSt.Name = "txtDepSt";
            this.txtDepSt.Size = new System.Drawing.Size(180, 23);
            this.txtDepSt.TabIndex = 1;
            // 
            // lblDepSt
            // 
            this.lblDepSt.AutoSize = true;
            this.lblDepSt.Location = new System.Drawing.Point(15, 61);
            this.lblDepSt.Name = "lblDepSt";
            this.lblDepSt.Size = new System.Drawing.Size(43, 16);
            this.lblDepSt.TabIndex = 0;
            this.lblDepSt.Text = "From:";
            // 
            // frmTerminateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.cmbRoutes);
            this.Controls.Add(this.routeIDTerminateRoute);
            this.Controls.Add(this.mnuStripTerminateRoute);
            this.Name = "frmTerminateRoute";
            this.Text = "Train Ticket System - Terminate Route";
            this.Load += new System.EventHandler(this.frmTerminateRoute_Load);
            this.mnuStripTerminateRoute.ResumeLayout(false);
            this.mnuStripTerminateRoute.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTerminateRoute;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateRouteBack;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateRouteExit;
        private System.Windows.Forms.ComboBox cmbRoutes;
        private System.Windows.Forms.Label routeIDTerminateRoute;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtArrSt;
        private System.Windows.Forms.Label lblArrSt;
        private System.Windows.Forms.TextBox txtDepSt;
        private System.Windows.Forms.Label lblDepSt;
    }
}