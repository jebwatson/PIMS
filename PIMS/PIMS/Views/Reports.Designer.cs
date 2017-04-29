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
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvReportsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(235, 22);
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
            this.txtPatientSearch.Location = new System.Drawing.Point(316, 24);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(373, 20);
            this.txtPatientSearch.TabIndex = 10;
            // 
            // btnBillsReport
            // 
            this.btnBillsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBillsReport.Location = new System.Drawing.Point(12, 157);
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
            this.btnAdmissionsReport.Location = new System.Drawing.Point(12, 101);
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
            this.btnPatientReport.Location = new System.Drawing.Point(12, 50);
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
            this.btnChargesReport.Location = new System.Drawing.Point(12, 213);
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
            this.btnEmergencyContactsReport.Location = new System.Drawing.Point(12, 269);
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
            this.btnNotesReport.Location = new System.Drawing.Point(12, 381);
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
            this.btnInsuranceReport.Location = new System.Drawing.Point(12, 325);
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
            this.btnVisitorsReport.Location = new System.Drawing.Point(12, 549);
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
            this.btnProceduresReport.Location = new System.Drawing.Point(12, 493);
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
            this.btnPrescriptionsReport.Location = new System.Drawing.Point(12, 437);
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
            this.olvReportsList.Location = new System.Drawing.Point(235, 51);
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
            // fname
            // 
            this.fname.AspectName = "nameFirst";
            this.fname.Text = "First Name";
            this.fname.Width = 100;
            // 
            // lname
            // 
            this.lname.AspectName = "nameLast";
            this.lname.Text = "Last Name";
            this.lname.Width = 96;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 610);
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
    }
}