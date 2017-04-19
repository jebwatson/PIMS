namespace PIMS.Views
{
    partial class Insurance
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
            this.olvInsuranceList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceCarrier = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceAccountNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceGroupNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvInsuranceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(314, 56);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(125, 30);
            this.btnSearchPatients.TabIndex = 8;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientSearch.Location = new System.Drawing.Point(456, 60);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(341, 22);
            this.txtPatientSearch.TabIndex = 9;
            // 
            // olvInsuranceList
            // 
            this.olvInsuranceList.AllColumns.Add(this.PatientID);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceID);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceCarrier);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceAccountNumber);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceGroupNumber);
            this.olvInsuranceList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvInsuranceList.CellEditUseWholeCell = false;
            this.olvInsuranceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.InsuranceID,
            this.InsuranceCarrier,
            this.InsuranceAccountNumber,
            this.InsuranceGroupNumber});
            this.olvInsuranceList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvInsuranceList.GridLines = true;
            this.olvInsuranceList.Location = new System.Drawing.Point(56, 98);
            this.olvInsuranceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olvInsuranceList.Name = "olvInsuranceList";
            this.olvInsuranceList.ShowGroups = false;
            this.olvInsuranceList.Size = new System.Drawing.Size(913, 278);
            this.olvInsuranceList.TabIndex = 10;
            this.olvInsuranceList.UseCompatibleStateImageBehavior = false;
            this.olvInsuranceList.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 130;
            // 
            // InsuranceID
            // 
            this.InsuranceID.AspectName = "insuranceId";
            this.InsuranceID.Text = "Insurance ID";
            this.InsuranceID.Width = 130;
            // 
            // InsuranceCarrier
            // 
            this.InsuranceCarrier.AspectName = "insuranceCarrier";
            this.InsuranceCarrier.Text = "Carrier";
            this.InsuranceCarrier.Width = 130;
            // 
            // InsuranceAccountNumber
            // 
            this.InsuranceAccountNumber.AspectName = "accountNumber";
            this.InsuranceAccountNumber.Text = "Account #";
            this.InsuranceAccountNumber.Width = 130;
            // 
            // InsuranceGroupNumber
            // 
            this.InsuranceGroupNumber.AspectName = "groupNumber";
            this.InsuranceGroupNumber.Text = "Group #";
            this.InsuranceGroupNumber.Width = 130;
            // 
            // Insurance
            // 
            this.AcceptButton = this.btnSearchPatients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 505);
            this.Controls.Add(this.olvInsuranceList);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Insurance";
            this.Text = "Insurance";
            ((System.ComponentModel.ISupportInitialize)(this.olvInsuranceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private BrightIdeasSoftware.ObjectListView olvInsuranceList;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn InsuranceID;
        private BrightIdeasSoftware.OLVColumn InsuranceCarrier;
        private BrightIdeasSoftware.OLVColumn InsuranceAccountNumber;
        private BrightIdeasSoftware.OLVColumn InsuranceGroupNumber;
    }
}