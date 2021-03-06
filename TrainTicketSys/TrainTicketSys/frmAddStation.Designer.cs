﻿namespace TrainTicketSys
{
    partial class frmAddStation
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
            this.mnuStripAddStation = new System.Windows.Forms.MenuStrip();
            this.mnuAddStationBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStationExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStID = new System.Windows.Forms.Label();
            this.txtStID = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.mnuStripAddStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripAddStation
            // 
            this.mnuStripAddStation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripAddStation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddStationBack,
            this.mnuAddStationExit});
            this.mnuStripAddStation.Location = new System.Drawing.Point(0, 0);
            this.mnuStripAddStation.Name = "mnuStripAddStation";
            this.mnuStripAddStation.Size = new System.Drawing.Size(624, 27);
            this.mnuStripAddStation.TabIndex = 1;
            this.mnuStripAddStation.Text = "mnuStripAddStation";
            // 
            // mnuAddStationBack
            // 
            this.mnuAddStationBack.Name = "mnuAddStationBack";
            this.mnuAddStationBack.Size = new System.Drawing.Size(53, 23);
            this.mnuAddStationBack.Text = "Back";
            this.mnuAddStationBack.Click += new System.EventHandler(this.mnuAddStationBack_Click);
            // 
            // mnuAddStationExit
            // 
            this.mnuAddStationExit.Name = "mnuAddStationExit";
            this.mnuAddStationExit.Size = new System.Drawing.Size(47, 23);
            this.mnuAddStationExit.Text = "Exit";
            this.mnuAddStationExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(299, 104);
            this.txtStation.MaxLength = 20;
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(164, 20);
            this.txtStation.TabIndex = 1;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(166, 101);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(110, 19);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station Name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(166, 133);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(56, 19);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(166, 164);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(55, 19);
            this.lblTown.TabIndex = 0;
            this.lblTown.Text = "Town:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(166, 196);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(65, 19);
            this.lblCounty.TabIndex = 0;
            this.lblCounty.Text = "County:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(299, 133);
            this.txtStreet.MaxLength = 20;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(164, 20);
            this.txtStreet.TabIndex = 2;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(299, 164);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(164, 20);
            this.txtTown.TabIndex = 3;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(299, 197);
            this.txtCounty.MaxLength = 20;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(164, 20);
            this.txtCounty.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(299, 263);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(164, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Station";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(219, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Station Details";
            // 
            // lblStID
            // 
            this.lblStID.AutoSize = true;
            this.lblStID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStID.Location = new System.Drawing.Point(12, 291);
            this.lblStID.Name = "lblStID";
            this.lblStID.Size = new System.Drawing.Size(86, 19);
            this.lblStID.TabIndex = 0;
            this.lblStID.Text = "Station ID:";
            this.lblStID.Visible = false;
            // 
            // txtStID
            // 
            this.txtStID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStID.Enabled = false;
            this.txtStID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStID.Location = new System.Drawing.Point(98, 291);
            this.txtStID.Name = "txtStID";
            this.txtStID.Size = new System.Drawing.Size(108, 20);
            this.txtStID.TabIndex = 0;
            this.txtStID.Visible = false;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(166, 227);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(84, 19);
            this.lblPhoneNo.TabIndex = 0;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(299, 228);
            this.txtPhoneNo.MaxLength = 16;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(164, 20);
            this.txtPhoneNo.TabIndex = 5;
            // 
            // frmAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblStID);
            this.Controls.Add(this.txtStID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.mnuStripAddStation);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAddStation";
            this.Text = "Train Ticket System - Add Station";
            this.Load += new System.EventHandler(this.frmAddStation_Load);
            this.mnuStripAddStation.ResumeLayout(false);
            this.mnuStripAddStation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripAddStation;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStationExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStationBack;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStID;
        private System.Windows.Forms.TextBox txtStID;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
    }
}