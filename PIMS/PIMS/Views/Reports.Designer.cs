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
            this.searchReports = new System.Windows.Forms.Button();
            this.printOneReport = new System.Windows.Forms.Button();
            this.printAllPatients = new System.Windows.Forms.Button();
            this.olvReportsList = new BrightIdeasSoftware.ObjectListView();
            this.searchReportsText = new System.Windows.Forms.TextBox();
            this.patientId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.patientLastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.patientFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvReportsList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchReports
            // 
            this.searchReports.Location = new System.Drawing.Point(230, 20);
            this.searchReports.Name = "searchReports";
            this.searchReports.Size = new System.Drawing.Size(64, 20);
            this.searchReports.TabIndex = 0;
            this.searchReports.Text = "Search";
            this.searchReports.UseVisualStyleBackColor = true;
            this.searchReports.Click += new System.EventHandler(this.searchReports_Click);
            // 
            // printOneReport
            // 
            this.printOneReport.Location = new System.Drawing.Point(66, 373);
            this.printOneReport.Name = "printOneReport";
            this.printOneReport.Size = new System.Drawing.Size(228, 71);
            this.printOneReport.TabIndex = 1;
            this.printOneReport.Text = "Print for Selected Patient";
            this.printOneReport.UseVisualStyleBackColor = true;
            this.printOneReport.Click += new System.EventHandler(this.printOneReport_Click);
            // 
            // printAllPatients
            // 
            this.printAllPatients.Location = new System.Drawing.Point(300, 373);
            this.printAllPatients.Name = "printAllPatients";
            this.printAllPatients.Size = new System.Drawing.Size(252, 71);
            this.printAllPatients.TabIndex = 2;
            this.printAllPatients.Text = "Print for All Patients";
            this.printAllPatients.UseVisualStyleBackColor = true;
            this.printAllPatients.Click += new System.EventHandler(this.printAllPatients_Click);
            // 
            // olvReportsList
            // 
            this.olvReportsList.AllColumns.Add(this.patientId);
            this.olvReportsList.AllColumns.Add(this.patientLastName);
            this.olvReportsList.AllColumns.Add(this.patientFirstName);
            this.olvReportsList.CellEditUseWholeCell = false;
            this.olvReportsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientId,
            this.patientLastName,
            this.patientFirstName});
            this.olvReportsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvReportsList.FullRowSelect = true;
            this.olvReportsList.GridLines = true;
            this.olvReportsList.Location = new System.Drawing.Point(31, 46);
            this.olvReportsList.Name = "olvReportsList";
            this.olvReportsList.Size = new System.Drawing.Size(573, 316);
            this.olvReportsList.TabIndex = 3;
            this.olvReportsList.UseCompatibleStateImageBehavior = false;
            this.olvReportsList.View = System.Windows.Forms.View.Details;
            // 
            // searchReportsText
            // 
            this.searchReportsText.Location = new System.Drawing.Point(300, 20);
            this.searchReportsText.Name = "searchReportsText";
            this.searchReportsText.Size = new System.Drawing.Size(303, 20);
            this.searchReportsText.TabIndex = 4;
            // 
            // patientId
            // 
            this.patientId.Text = "Patient ID";
            this.patientId.Width = 112;
            // 
            // patientLastName
            // 
            this.patientLastName.Text = "Last Name";
            this.patientLastName.Width = 210;
            // 
            // patientFirstName
            // 
            this.patientFirstName.Text = "First Name";
            this.patientFirstName.Width = 307;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 456);
            this.Controls.Add(this.searchReportsText);
            this.Controls.Add(this.olvReportsList);
            this.Controls.Add(this.printAllPatients);
            this.Controls.Add(this.printOneReport);
            this.Controls.Add(this.searchReports);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.olvReportsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchReports;
        private System.Windows.Forms.Button printOneReport;
        private System.Windows.Forms.Button printAllPatients;
        private BrightIdeasSoftware.ObjectListView olvReportsList;
        private System.Windows.Forms.TextBox searchReportsText;
        private BrightIdeasSoftware.OLVColumn patientId;
        private BrightIdeasSoftware.OLVColumn patientLastName;
        private BrightIdeasSoftware.OLVColumn patientFirstName;
    }
}