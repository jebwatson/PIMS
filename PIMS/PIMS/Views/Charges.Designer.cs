namespace PIMS.Views
{
    partial class Charges
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
            this.olvChargesList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChargesID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TotalAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChargeDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DueDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProcedureID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OfficeStaffId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvChargesList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(592, 41);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(94, 24);
            this.btnSearchPatients.TabIndex = 8;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(690, 44);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(257, 20);
            this.txtPatientSearch.TabIndex = 9;
            // 
            // olvChargesList
            // 
            this.olvChargesList.AllColumns.Add(this.PatientID);
            this.olvChargesList.AllColumns.Add(this.lname);
            this.olvChargesList.AllColumns.Add(this.fname);
            this.olvChargesList.AllColumns.Add(this.ChargesID);
            this.olvChargesList.AllColumns.Add(this.Description);
            this.olvChargesList.AllColumns.Add(this.TotalAmount);
            this.olvChargesList.AllColumns.Add(this.ChargeDate);
            this.olvChargesList.AllColumns.Add(this.DueDate);
            this.olvChargesList.AllColumns.Add(this.ProcedureID);
            this.olvChargesList.AllColumns.Add(this.OfficeStaffId);
            this.olvChargesList.CellEditUseWholeCell = false;
            this.olvChargesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.lname,
            this.fname,
            this.ChargesID,
            this.Description,
            this.TotalAmount,
            this.ChargeDate,
            this.DueDate,
            this.ProcedureID,
            this.OfficeStaffId});
            this.olvChargesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvChargesList.GridLines = true;
            this.olvChargesList.Location = new System.Drawing.Point(42, 72);
            this.olvChargesList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.olvChargesList.Name = "olvChargesList";
            this.olvChargesList.Size = new System.Drawing.Size(905, 227);
            this.olvChargesList.TabIndex = 11;
            this.olvChargesList.UseCompatibleStateImageBehavior = false;
            this.olvChargesList.View = System.Windows.Forms.View.Details;
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
            // ChargesID
            // 
            this.ChargesID.AspectName = "chargeId";
            this.ChargesID.Text = "Charge ID";
            this.ChargesID.Width = 120;
            // 
            // Description
            // 
            this.Description.AspectName = "description";
            this.Description.Text = "Description";
            this.Description.Width = 120;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AspectName = "amountTotal";
            this.TotalAmount.Text = "Total Amount";
            this.TotalAmount.Width = 120;
            // 
            // ChargeDate
            // 
            this.ChargeDate.AspectName = "dateCharged";
            this.ChargeDate.Text = "Date Charged";
            this.ChargeDate.Width = 120;
            // 
            // DueDate
            // 
            this.DueDate.AspectName = "dateDue";
            this.DueDate.Text = "Date Due";
            this.DueDate.Width = 120;
            // 
            // ProcedureID
            // 
            this.ProcedureID.AspectName = "procedureId";
            this.ProcedureID.Text = "Procedure ID";
            this.ProcedureID.Width = 120;
            // 
            // OfficeStaffId
            // 
            this.OfficeStaffId.AspectName = "officeStaffId";
            this.OfficeStaffId.Text = "Staff ID";
            this.OfficeStaffId.Width = 120;
            // 
            // Charges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 371);
            this.Controls.Add(this.olvChargesList);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Charges";
            this.Text = "Charges";
            ((System.ComponentModel.ISupportInitialize)(this.olvChargesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private BrightIdeasSoftware.ObjectListView olvChargesList;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn lname;
        private BrightIdeasSoftware.OLVColumn fname;
        private BrightIdeasSoftware.OLVColumn ChargesID;
        private BrightIdeasSoftware.OLVColumn Description;
        private BrightIdeasSoftware.OLVColumn TotalAmount;
        private BrightIdeasSoftware.OLVColumn ChargeDate;
        private BrightIdeasSoftware.OLVColumn DueDate;
        private BrightIdeasSoftware.OLVColumn ProcedureID;
        private BrightIdeasSoftware.OLVColumn OfficeStaffId;
    }
}