﻿namespace PIMS.Views
{
    partial class EmergencyContacts
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
            this.ovlEContacts = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.EClname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ECfname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AreaCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Phone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ovlEContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // ovlEContacts
            // 
            this.ovlEContacts.AllColumns.Add(this.PatientID);
            this.ovlEContacts.AllColumns.Add(this.EClname);
            this.ovlEContacts.AllColumns.Add(this.ECfname);
            this.ovlEContacts.AllColumns.Add(this.AreaCode);
            this.ovlEContacts.AllColumns.Add(this.Phone);
            this.ovlEContacts.CellEditUseWholeCell = false;
            this.ovlEContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.EClname,
            this.ECfname,
            this.AreaCode,
            this.Phone});
            this.ovlEContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlEContacts.GridLines = true;
            this.ovlEContacts.Location = new System.Drawing.Point(9, 76);
            this.ovlEContacts.Margin = new System.Windows.Forms.Padding(2);
            this.ovlEContacts.Name = "ovlEContacts";
            this.ovlEContacts.Size = new System.Drawing.Size(775, 227);
            this.ovlEContacts.TabIndex = 0;
            this.ovlEContacts.UseCompatibleStateImageBehavior = false;
            this.ovlEContacts.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 130;
            // 
            // EClname
            // 
            this.EClname.AspectName = "nameLast";
            this.EClname.Text = "E.C. Last Name";
            this.EClname.Width = 130;
            // 
            // ECfname
            // 
            this.ECfname.AspectName = "nameFirst";
            this.ECfname.Text = "E.C First Name";
            this.ECfname.Width = 130;
            // 
            // AreaCode
            // 
            this.AreaCode.AspectName = "areaCode";
            this.AreaCode.Text = "Area Code";
            this.AreaCode.Width = 130;
            // 
            // Phone
            // 
            this.Phone.AspectName = "phone";
            this.Phone.Text = "Phone #";
            this.Phone.Width = 130;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(429, 45);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(94, 24);
            this.btnSearchPatients.TabIndex = 8;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(527, 48);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(257, 20);
            this.txtPatientSearch.TabIndex = 9;
            // 
            // EmergencyContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 391);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.ovlEContacts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmergencyContacts";
            this.Text = "EmergencyContacts";
            ((System.ComponentModel.ISupportInitialize)(this.ovlEContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView ovlEContacts;
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn EClname;
        private BrightIdeasSoftware.OLVColumn ECfname;
        private BrightIdeasSoftware.OLVColumn AreaCode;
        private BrightIdeasSoftware.OLVColumn Phone;
    }
}