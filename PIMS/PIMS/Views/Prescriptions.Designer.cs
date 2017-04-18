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
            this.txtProceduresSearch = new System.Windows.Forms.TextBox();
            this.btnSearchProcedures = new System.Windows.Forms.Button();
            this.olvPrescriptionsList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Duration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvPrescriptionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProceduresSearch
            // 
            this.txtProceduresSearch.Location = new System.Drawing.Point(381, 52);
            this.txtProceduresSearch.Name = "txtProceduresSearch";
            this.txtProceduresSearch.Size = new System.Drawing.Size(341, 22);
            this.txtProceduresSearch.TabIndex = 8;
            // 
            // btnSearchProcedures
            // 
            this.btnSearchProcedures.Location = new System.Drawing.Point(250, 49);
            this.btnSearchProcedures.Name = "btnSearchProcedures";
            this.btnSearchProcedures.Size = new System.Drawing.Size(125, 29);
            this.btnSearchProcedures.TabIndex = 7;
            this.btnSearchProcedures.Text = "Search";
            this.btnSearchProcedures.UseVisualStyleBackColor = true;
            // 
            // olvPrescriptionsList
            // 
            this.olvPrescriptionsList.AllColumns.Add(this.PatientID);
            this.olvPrescriptionsList.AllColumns.Add(this.lname);
            this.olvPrescriptionsList.AllColumns.Add(this.fname);
            this.olvPrescriptionsList.AllColumns.Add(this.PrescriptionID);
            this.olvPrescriptionsList.AllColumns.Add(this.PrescriptionName);
            this.olvPrescriptionsList.AllColumns.Add(this.PrescriptionDate);
            this.olvPrescriptionsList.AllColumns.Add(this.Duration);
            this.olvPrescriptionsList.CellEditUseWholeCell = false;
            this.olvPrescriptionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.lname,
            this.fname,
            this.PrescriptionID,
            this.PrescriptionName,
            this.PrescriptionDate,
            this.Duration});
            this.olvPrescriptionsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPrescriptionsList.GridLines = true;
            this.olvPrescriptionsList.Location = new System.Drawing.Point(52, 84);
            this.olvPrescriptionsList.Name = "olvPrescriptionsList";
            this.olvPrescriptionsList.Size = new System.Drawing.Size(921, 279);
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
            // lname
            // 
            this.lname.AspectName = "nameLast";
            this.lname.Text = "Last Name";
            this.lname.Width = 120;
            // 
            // fname
            // 
            this.fname.AspectName = "nameFirst";
            this.fname.Text = "First Name";
            this.fname.Width = 120;
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.AspectName = "prescID";
            this.PrescriptionID.Text = "Prescription ID";
            this.PrescriptionID.Width = 120;
            // 
            // PrescriptionName
            // 
            this.PrescriptionName.AspectName = "prescName";
            this.PrescriptionName.Text = "Prescription Name";
            this.PrescriptionName.Width = 120;
            // 
            // PrescriptionDate
            // 
            this.PrescriptionDate.AspectName = "prescDate";
            this.PrescriptionDate.Text = "Date Prescribed";
            this.PrescriptionDate.Width = 120;
            // 
            // Duration
            // 
            this.Duration.AspectName = "duration";
            this.Duration.Text = "Duration";
            this.Duration.Width = 120;
            // 
            // Prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 457);
            this.Controls.Add(this.txtProceduresSearch);
            this.Controls.Add(this.btnSearchProcedures);
            this.Controls.Add(this.olvPrescriptionsList);
            this.Name = "Prescriptions";
            this.Text = "Perscriptions";
            ((System.ComponentModel.ISupportInitialize)(this.olvPrescriptionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProceduresSearch;
        private System.Windows.Forms.Button btnSearchProcedures;
        private BrightIdeasSoftware.ObjectListView olvPrescriptionsList;
        private BrightIdeasSoftware.OLVColumn PrescriptionID;
        private BrightIdeasSoftware.OLVColumn PrescriptionName;
        private BrightIdeasSoftware.OLVColumn PrescriptionDate;
        private BrightIdeasSoftware.OLVColumn Duration;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn lname;
        private BrightIdeasSoftware.OLVColumn fname;
    }
}