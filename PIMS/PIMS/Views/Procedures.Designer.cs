namespace PIMS.Views
{
    partial class Procedures
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
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.olvProceduresList = new BrightIdeasSoftware.ObjectListView();
            this.patientid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PatientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProcedureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DurationHrs = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DurationMins = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StartTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StopTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DoctorId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProcNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvProceduresList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientSearch.Location = new System.Drawing.Point(117, 67);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(257, 20);
            this.txtPatientSearch.TabIndex = 5;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(19, 64);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(94, 24);
            this.btnSearchPatients.TabIndex = 4;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // olvProceduresList
            // 
            this.olvProceduresList.AllColumns.Add(this.patientid);
            this.olvProceduresList.AllColumns.Add(this.PatientName);
            this.olvProceduresList.AllColumns.Add(this.ProcedureType);
            this.olvProceduresList.AllColumns.Add(this.DurationHrs);
            this.olvProceduresList.AllColumns.Add(this.DurationMins);
            this.olvProceduresList.AllColumns.Add(this.StartTime);
            this.olvProceduresList.AllColumns.Add(this.StopTime);
            this.olvProceduresList.AllColumns.Add(this.DoctorId);
            this.olvProceduresList.AllColumns.Add(this.ProcNotes);
            this.olvProceduresList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvProceduresList.CellEditUseWholeCell = false;
            this.olvProceduresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientid,
            this.PatientName,
            this.ProcedureType,
            this.DurationHrs,
            this.DurationMins,
            this.StartTime,
            this.StopTime,
            this.DoctorId,
            this.ProcNotes});
            this.olvProceduresList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvProceduresList.GridLines = true;
            this.olvProceduresList.Location = new System.Drawing.Point(19, 99);
            this.olvProceduresList.Margin = new System.Windows.Forms.Padding(2);
            this.olvProceduresList.Name = "olvProceduresList";
            this.olvProceduresList.ShowGroups = false;
            this.olvProceduresList.Size = new System.Drawing.Size(725, 227);
            this.olvProceduresList.TabIndex = 3;
            this.olvProceduresList.UseCompatibleStateImageBehavior = false;
            this.olvProceduresList.View = System.Windows.Forms.View.Details;
            // 
            // patientid
            // 
            this.patientid.AspectName = "patientId";
            this.patientid.Text = "Patient ID";
            this.patientid.Width = 120;
            // 
            // PatientName
            // 
            this.PatientName.AspectName = "name";
            this.PatientName.Text = "Name";
            // 
            // ProcedureType
            // 
            this.ProcedureType.AspectName = "procType";
            this.ProcedureType.Text = "Procedure Type";
            this.ProcedureType.Width = 120;
            // 
            // DurationHrs
            // 
            this.DurationHrs.AspectName = "durationHrs";
            this.DurationHrs.Text = "Duration (Hours)";
            this.DurationHrs.Width = 120;
            // 
            // DurationMins
            // 
            this.DurationMins.AspectName = "durationMins";
            this.DurationMins.Text = "Duration (Minutes)";
            this.DurationMins.Width = 120;
            // 
            // StartTime
            // 
            this.StartTime.AspectName = "startTime";
            this.StartTime.Text = "Start Time";
            this.StartTime.Width = 120;
            // 
            // StopTime
            // 
            this.StopTime.AspectName = "stopTime";
            this.StopTime.Text = "Stop Time";
            this.StopTime.Width = 120;
            // 
            // DoctorId
            // 
            this.DoctorId.AspectName = "doctorId";
            this.DoctorId.Text = "Doctor ID";
            this.DoctorId.Width = 120;
            // 
            // ProcNotes
            // 
            this.ProcNotes.AspectName = "procNotes";
            this.ProcNotes.Text = "Procedure Notes";
            this.ProcNotes.Width = 120;
            // 
            // Procedures
            // 
            this.AcceptButton = this.btnSearchPatients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 437);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.olvProceduresList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Procedures";
            this.Text = "Procedures";
            ((System.ComponentModel.ISupportInitialize)(this.olvProceduresList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Button btnSearchPatients;
        private BrightIdeasSoftware.ObjectListView olvProceduresList;
        private BrightIdeasSoftware.OLVColumn ProcedureType;
        private BrightIdeasSoftware.OLVColumn DurationHrs;
        private BrightIdeasSoftware.OLVColumn DurationMins;
        private BrightIdeasSoftware.OLVColumn StartTime;
        private BrightIdeasSoftware.OLVColumn StopTime;
        private BrightIdeasSoftware.OLVColumn patientid;
        private BrightIdeasSoftware.OLVColumn DoctorId;
        private BrightIdeasSoftware.OLVColumn ProcNotes;
        private BrightIdeasSoftware.OLVColumn PatientName;
    }
}