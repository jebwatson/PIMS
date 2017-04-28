namespace PIMS.Views
{
    partial class Bills
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
            this.olvBillsList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PatientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Total = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaidbyPatient = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaidbyInsurance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AmountOwed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateCharged = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateDue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvBillsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(27, 33);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(94, 24);
            this.btnSearchPatients.TabIndex = 8;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(144, 36);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(257, 20);
            this.txtPatientSearch.TabIndex = 9;
            // 
            // olvBillsList
            // 
            this.olvBillsList.AllColumns.Add(this.PatientID);
            this.olvBillsList.AllColumns.Add(this.PatientName);
            this.olvBillsList.AllColumns.Add(this.Total);
            this.olvBillsList.AllColumns.Add(this.PaidbyPatient);
            this.olvBillsList.AllColumns.Add(this.PaidbyInsurance);
            this.olvBillsList.AllColumns.Add(this.AmountOwed);
            this.olvBillsList.AllColumns.Add(this.DateCharged);
            this.olvBillsList.AllColumns.Add(this.DateDue);
            this.olvBillsList.CellEditUseWholeCell = false;
            this.olvBillsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.PatientName,
            this.Total,
            this.PaidbyPatient,
            this.PaidbyInsurance,
            this.AmountOwed,
            this.DateCharged,
            this.DateDue});
            this.olvBillsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvBillsList.GridLines = true;
            this.olvBillsList.Location = new System.Drawing.Point(27, 70);
            this.olvBillsList.Margin = new System.Windows.Forms.Padding(2);
            this.olvBillsList.Name = "olvBillsList";
            this.olvBillsList.ShowGroups = false;
            this.olvBillsList.Size = new System.Drawing.Size(823, 227);
            this.olvBillsList.TabIndex = 0;
            this.olvBillsList.UseCompatibleStateImageBehavior = false;
            this.olvBillsList.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 59;
            // 
            // PatientName
            // 
            this.PatientName.AspectName = "name";
            this.PatientName.Text = "Name";
            this.PatientName.Width = 136;
            // 
            // Total
            // 
            this.Total.AspectName = "amountTotal";
            this.Total.Text = "Amount Total";
            this.Total.Width = 80;
            // 
            // PaidbyPatient
            // 
            this.PaidbyPatient.AspectName = "amountPaidByPatient";
            this.PaidbyPatient.Text = "Amount Paid By Patient";
            this.PaidbyPatient.Width = 125;
            // 
            // PaidbyInsurance
            // 
            this.PaidbyInsurance.AspectName = "amountPaidByInsurance";
            this.PaidbyInsurance.Text = "Amount Paid By Insurance";
            this.PaidbyInsurance.Width = 138;
            // 
            // AmountOwed
            // 
            this.AmountOwed.AspectName = "amountOwed";
            this.AmountOwed.Text = "Amount Owed";
            this.AmountOwed.Width = 82;
            // 
            // DateCharged
            // 
            this.DateCharged.AspectName = "dateCharged";
            this.DateCharged.Text = "Date Charged";
            this.DateCharged.Width = 100;
            // 
            // DateDue
            // 
            this.DateDue.AspectName = "dateDue";
            this.DateDue.Text = "Date Due";
            this.DateDue.Width = 100;
            // 
            // Bills
            // 
            this.AcceptButton = this.btnSearchPatients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 340);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.olvBillsList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bills";
            this.Text = "Bills";
            ((System.ComponentModel.ISupportInitialize)(this.olvBillsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvBillsList;
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private BrightIdeasSoftware.OLVColumn Total;
        private BrightIdeasSoftware.OLVColumn PaidbyPatient;
        private BrightIdeasSoftware.OLVColumn PaidbyInsurance;
        private BrightIdeasSoftware.OLVColumn AmountOwed;
        private BrightIdeasSoftware.OLVColumn DateCharged;
        private BrightIdeasSoftware.OLVColumn DateDue;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn PatientName;
    }
}