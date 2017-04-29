namespace PIMS.Views
{
    partial class Prescriptions
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
            this.olvPrescriptionsList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PatientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Amount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Duration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvPrescriptionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(131, 24);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(257, 20);
            this.txtPatientSearch.TabIndex = 8;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(33, 21);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(94, 24);
            this.btnSearchPatients.TabIndex = 7;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // olvPrescriptionsList
            // 
            this.olvPrescriptionsList.AllColumns.Add(this.PatientID);
            this.olvPrescriptionsList.AllColumns.Add(this.PatientName);
            this.olvPrescriptionsList.AllColumns.Add(this.PrescriptionName);
            this.olvPrescriptionsList.AllColumns.Add(this.Amount);
            this.olvPrescriptionsList.AllColumns.Add(this.PrescriptionDate);
            this.olvPrescriptionsList.AllColumns.Add(this.Duration);
            this.olvPrescriptionsList.CellEditUseWholeCell = false;
            this.olvPrescriptionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.PatientName,
            this.PrescriptionName,
            this.Amount,
            this.PrescriptionDate,
            this.Duration});
            this.olvPrescriptionsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPrescriptionsList.FullRowSelect = true;
            this.olvPrescriptionsList.GridLines = true;
            this.olvPrescriptionsList.HideSelection = false;
            this.olvPrescriptionsList.Location = new System.Drawing.Point(34, 53);
            this.olvPrescriptionsList.Margin = new System.Windows.Forms.Padding(2);
            this.olvPrescriptionsList.Name = "olvPrescriptionsList";
            this.olvPrescriptionsList.ShowGroups = false;
            this.olvPrescriptionsList.Size = new System.Drawing.Size(479, 227);
            this.olvPrescriptionsList.TabIndex = 6;
            this.olvPrescriptionsList.UseCompatibleStateImageBehavior = false;
            this.olvPrescriptionsList.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 120;
            // 
            // PatientName
            // 
            this.PatientName.AspectName = "name";
            this.PatientName.DisplayIndex = 5;
            this.PatientName.Text = "Name";
            // 
            // PrescriptionName
            // 
            this.PrescriptionName.AspectName = "prescName";
            this.PrescriptionName.DisplayIndex = 1;
            this.PrescriptionName.Text = "Prescription Name";
            this.PrescriptionName.Width = 120;
            // 
            // Amount
            // 
            this.Amount.AspectName = "amount";
            this.Amount.DisplayIndex = 2;
            this.Amount.Text = "Amount";
            // 
            // PrescriptionDate
            // 
            this.PrescriptionDate.AspectName = "prescDate";
            this.PrescriptionDate.DisplayIndex = 3;
            this.PrescriptionDate.Text = "Date Prescribed";
            this.PrescriptionDate.Width = 120;
            // 
            // Duration
            // 
            this.Duration.AspectName = "duration";
            this.Duration.DisplayIndex = 4;
            this.Duration.Text = "Duration";
            this.Duration.Width = 120;
            // 
            // Prescriptions
            // 
            this.AcceptButton = this.btnSearchPatients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 312);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.olvPrescriptionsList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prescriptions";
            this.Text = "Prescriptions";
            ((System.ComponentModel.ISupportInitialize)(this.olvPrescriptionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Button btnSearchPatients;
        private BrightIdeasSoftware.ObjectListView olvPrescriptionsList;
        private BrightIdeasSoftware.OLVColumn PrescriptionName;
        private BrightIdeasSoftware.OLVColumn PrescriptionDate;
        private BrightIdeasSoftware.OLVColumn Duration;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn Amount;
        private BrightIdeasSoftware.OLVColumn PatientName;
    }
}