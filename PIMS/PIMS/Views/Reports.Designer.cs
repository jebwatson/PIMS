namespace PIMS.Views
{
    partial class Reports
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
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.btnBillsReport = new System.Windows.Forms.Button();
            this.btnAdmissionsReport = new System.Windows.Forms.Button();
            this.btnPatientReport = new System.Windows.Forms.Button();
            this.btnChargesReport = new System.Windows.Forms.Button();
            this.btnEmergencyContactsReport = new System.Windows.Forms.Button();
            this.btnNotesReport = new System.Windows.Forms.Button();
            this.btnInsuranceReport = new System.Windows.Forms.Button();
            this.btnVisitorsReport = new System.Windows.Forms.Button();
            this.btnProceduresReport = new System.Windows.Forms.Button();
            this.btnPrescriptionsReport = new System.Windows.Forms.Button();
            this.olvReportsList = new BrightIdeasSoftware.ObjectListView();
            this.id = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvReportsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(237, 23);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatients.TabIndex = 11;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientSearch.Location = new System.Drawing.Point(318, 25);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(373, 20);
            this.txtPatientSearch.TabIndex = 10;
            // 
            // btnBillsReport
            // 
            this.btnBillsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBillsReport.Location = new System.Drawing.Point(14, 158);
            this.btnBillsReport.Name = "btnBillsReport";
            this.btnBillsReport.Size = new System.Drawing.Size(202, 50);
            this.btnBillsReport.TabIndex = 9;
            this.btnBillsReport.Text = "Generate Bills Report";
            this.btnBillsReport.UseVisualStyleBackColor = true;
            this.btnBillsReport.Click += new System.EventHandler(this.btnBillsReport_Click);
            // 
            // btnAdmissionsReport
            // 
            this.btnAdmissionsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmissionsReport.Location = new System.Drawing.Point(14, 102);
            this.btnAdmissionsReport.Name = "btnAdmissionsReport";
            this.btnAdmissionsReport.Size = new System.Drawing.Size(202, 50);
            this.btnAdmissionsReport.TabIndex = 8;
            this.btnAdmissionsReport.Text = "Generate Admissions Report";
            this.btnAdmissionsReport.UseVisualStyleBackColor = true;
            this.btnAdmissionsReport.Click += new System.EventHandler(this.btnAdmissionsReport_Click);
            // 
            // btnPatientReport
            // 
            this.btnPatientReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatientReport.Location = new System.Drawing.Point(14, 51);
            this.btnPatientReport.Name = "btnPatientReport";
            this.btnPatientReport.Size = new System.Drawing.Size(202, 45);
            this.btnPatientReport.TabIndex = 7;
            this.btnPatientReport.Text = "Generate Patient Report";
            this.btnPatientReport.UseVisualStyleBackColor = true;
            this.btnPatientReport.Click += new System.EventHandler(this.btnPatientReport_Click);
            // 
            // btnChargesReport
            // 
            this.btnChargesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChargesReport.Location = new System.Drawing.Point(14, 214);
            this.btnChargesReport.Name = "btnChargesReport";
            this.btnChargesReport.Size = new System.Drawing.Size(202, 50);
            this.btnChargesReport.TabIndex = 12;
            this.btnChargesReport.Text = "Generate Charges Report";
            this.btnChargesReport.UseVisualStyleBackColor = true;
            this.btnChargesReport.Click += new System.EventHandler(this.btnChargesReport_Click);
            // 
            // btnEmergencyContactsReport
            // 
            this.btnEmergencyContactsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmergencyContactsReport.Location = new System.Drawing.Point(14, 270);
            this.btnEmergencyContactsReport.Name = "btnEmergencyContactsReport";
            this.btnEmergencyContactsReport.Size = new System.Drawing.Size(202, 50);
            this.btnEmergencyContactsReport.TabIndex = 13;
            this.btnEmergencyContactsReport.Text = "Generate Emergency Contacts Report";
            this.btnEmergencyContactsReport.UseVisualStyleBackColor = true;
            this.btnEmergencyContactsReport.Click += new System.EventHandler(this.btnEmergencyContactsReport_Click);
            // 
            // btnNotesReport
            // 
            this.btnNotesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotesReport.Location = new System.Drawing.Point(14, 382);
            this.btnNotesReport.Name = "btnNotesReport";
            this.btnNotesReport.Size = new System.Drawing.Size(202, 50);
            this.btnNotesReport.TabIndex = 14;
            this.btnNotesReport.Text = "Generate Notes Report";
            this.btnNotesReport.UseVisualStyleBackColor = true;
            this.btnNotesReport.Click += new System.EventHandler(this.btnNotesReport_Click);
            // 
            // btnInsuranceReport
            // 
            this.btnInsuranceReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsuranceReport.Location = new System.Drawing.Point(14, 326);
            this.btnInsuranceReport.Name = "btnInsuranceReport";
            this.btnInsuranceReport.Size = new System.Drawing.Size(202, 50);
            this.btnInsuranceReport.TabIndex = 15;
            this.btnInsuranceReport.Text = "Generate Insurance Report";
            this.btnInsuranceReport.UseVisualStyleBackColor = true;
            this.btnInsuranceReport.Click += new System.EventHandler(this.btnInsuranceReport_Click);
            // 
            // btnVisitorsReport
            // 
            this.btnVisitorsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisitorsReport.Location = new System.Drawing.Point(14, 550);
            this.btnVisitorsReport.Name = "btnVisitorsReport";
            this.btnVisitorsReport.Size = new System.Drawing.Size(202, 50);
            this.btnVisitorsReport.TabIndex = 16;
            this.btnVisitorsReport.Text = "Generate Visitors Report";
            this.btnVisitorsReport.UseVisualStyleBackColor = true;
            this.btnVisitorsReport.Click += new System.EventHandler(this.btnVisitorsReport_Click);
            // 
            // btnProceduresReport
            // 
            this.btnProceduresReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProceduresReport.Location = new System.Drawing.Point(14, 494);
            this.btnProceduresReport.Name = "btnProceduresReport";
            this.btnProceduresReport.Size = new System.Drawing.Size(202, 50);
            this.btnProceduresReport.TabIndex = 17;
            this.btnProceduresReport.Text = "Generate Procedures Report";
            this.btnProceduresReport.UseVisualStyleBackColor = true;
            this.btnProceduresReport.Click += new System.EventHandler(this.btnProceduresReport_Click);
            // 
            // btnPrescriptionsReport
            // 
            this.btnPrescriptionsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrescriptionsReport.Location = new System.Drawing.Point(14, 438);
            this.btnPrescriptionsReport.Name = "btnPrescriptionsReport";
            this.btnPrescriptionsReport.Size = new System.Drawing.Size(202, 50);
            this.btnPrescriptionsReport.TabIndex = 18;
            this.btnPrescriptionsReport.Text = "Generate Prescriptions Report";
            this.btnPrescriptionsReport.UseVisualStyleBackColor = true;
            this.btnPrescriptionsReport.Click += new System.EventHandler(this.btnPrescriptionsReport_Click);
            // 
            // olvReportsList
            // 
            this.olvReportsList.AllColumns.Add(this.id);
            this.olvReportsList.AllColumns.Add(this.lname);
            this.olvReportsList.AllColumns.Add(this.fname);
            this.olvReportsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvReportsList.CellEditUseWholeCell = false;
            this.olvReportsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.lname,
            this.fname});
            this.olvReportsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvReportsList.FullRowSelect = true;
            this.olvReportsList.GridLines = true;
            this.olvReportsList.HideSelection = false;
            this.olvReportsList.Location = new System.Drawing.Point(237, 52);
            this.olvReportsList.Name = "olvReportsList";
            this.olvReportsList.ShowGroups = false;
            this.olvReportsList.Size = new System.Drawing.Size(454, 548);
            this.olvReportsList.TabIndex = 6;
            this.olvReportsList.UseCompatibleStateImageBehavior = false;
            this.olvReportsList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.AspectName = "patientId";
            this.id.Text = "Patient Id";
            this.id.Width = 100;
            // 
            // lname
            // 
            this.lname.AspectName = "nameLast";
            this.lname.Text = "Last Name";
            this.lname.Width = 96;
            // 
            // fname
            // 
            this.fname.AspectName = "nameFirst";
            this.fname.Text = "First Name";
            this.fname.Width = 100;
            // 
            // btnDeselect
            // 
            this.btnDeselect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeselect.Location = new System.Drawing.Point(489, 611);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(202, 50);
            this.btnDeselect.TabIndex = 19;
            this.btnDeselect.Text = "Deselect All Selected Patients";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Location = new System.Drawing.Point(281, 611);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(202, 50);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "Select All Patients";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 673);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnPrescriptionsReport);
            this.Controls.Add(this.btnProceduresReport);
            this.Controls.Add(this.btnVisitorsReport);
            this.Controls.Add(this.btnInsuranceReport);
            this.Controls.Add(this.btnNotesReport);
            this.Controls.Add(this.btnEmergencyContactsReport);
            this.Controls.Add(this.btnChargesReport);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnBillsReport);
            this.Controls.Add(this.btnAdmissionsReport);
            this.Controls.Add(this.btnPatientReport);
            this.Controls.Add(this.olvReportsList);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.olvReportsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn fname;
        private BrightIdeasSoftware.OLVColumn id;
        private BrightIdeasSoftware.ObjectListView olvReportsList;
        private System.Windows.Forms.Button btnPatientReport;
        private System.Windows.Forms.Button btnAdmissionsReport;
        private System.Windows.Forms.Button btnBillsReport;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.Button btnChargesReport;
        private System.Windows.Forms.Button btnEmergencyContactsReport;
        private System.Windows.Forms.Button btnNotesReport;
        private System.Windows.Forms.Button btnInsuranceReport;
        private System.Windows.Forms.Button btnVisitorsReport;
        private System.Windows.Forms.Button btnProceduresReport;
        private System.Windows.Forms.Button btnPrescriptionsReport;
        private BrightIdeasSoftware.OLVColumn lname;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Button btnSelect;
    }
}