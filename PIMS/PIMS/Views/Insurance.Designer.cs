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
            this.btnSearchInsurance = new System.Windows.Forms.Button();
            this.txtInsuranceSearch = new System.Windows.Forms.TextBox();
            this.olvInsuranceList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceCarrier = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceAccountNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InsuranceGroupNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvInsuranceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchInsurance
            // 
            this.btnSearchInsurance.Location = new System.Drawing.Point(373, 49);
            this.btnSearchInsurance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchInsurance.Name = "btnSearchInsurance";
            this.btnSearchInsurance.Size = new System.Drawing.Size(94, 24);
            this.btnSearchInsurance.TabIndex = 8;
            this.btnSearchInsurance.Text = "Search";
            this.btnSearchInsurance.UseVisualStyleBackColor = true;
            // 
            // txtInsuranceSearch
            // 
            this.txtInsuranceSearch.Location = new System.Drawing.Point(471, 52);
            this.txtInsuranceSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInsuranceSearch.Name = "txtInsuranceSearch";
            this.txtInsuranceSearch.Size = new System.Drawing.Size(257, 20);
            this.txtInsuranceSearch.TabIndex = 9;
            // 
            // olvInsuranceList
            // 
            this.olvInsuranceList.AllColumns.Add(this.PatientID);
            this.olvInsuranceList.AllColumns.Add(this.lname);
            this.olvInsuranceList.AllColumns.Add(this.fname);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceID);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceCarrier);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceAccountNumber);
            this.olvInsuranceList.AllColumns.Add(this.InsuranceGroupNumber);
            this.olvInsuranceList.CellEditUseWholeCell = false;
            this.olvInsuranceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.lname,
            this.fname,
            this.InsuranceID,
            this.InsuranceCarrier,
            this.InsuranceAccountNumber,
            this.InsuranceGroupNumber});
            this.olvInsuranceList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvInsuranceList.GridLines = true;
            this.olvInsuranceList.Location = new System.Drawing.Point(42, 80);
            this.olvInsuranceList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.olvInsuranceList.Name = "olvInsuranceList";
            this.olvInsuranceList.Size = new System.Drawing.Size(686, 227);
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
            // lname
            // 
            this.lname.AspectName = "nameLast";
            this.lname.Text = "Last Name";
            this.lname.Width = 130;
            // 
            // fname
            // 
            this.fname.AspectName = "nameFirst";
            this.fname.Text = "First Name";
            this.fname.Width = 130;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 410);
            this.Controls.Add(this.olvInsuranceList);
            this.Controls.Add(this.txtInsuranceSearch);
            this.Controls.Add(this.btnSearchInsurance);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Insurance";
            this.Text = "Insurance";
            ((System.ComponentModel.ISupportInitialize)(this.olvInsuranceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchInsurance;
        private System.Windows.Forms.TextBox txtInsuranceSearch;
        private BrightIdeasSoftware.ObjectListView olvInsuranceList;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn lname;
        private BrightIdeasSoftware.OLVColumn fname;
        private BrightIdeasSoftware.OLVColumn InsuranceID;
        private BrightIdeasSoftware.OLVColumn InsuranceCarrier;
        private BrightIdeasSoftware.OLVColumn InsuranceAccountNumber;
        private BrightIdeasSoftware.OLVColumn InsuranceGroupNumber;
    }
}