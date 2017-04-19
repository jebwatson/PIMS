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
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(56, 55);
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
            this.txtPatientSearch.Location = new System.Drawing.Point(187, 59);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(341, 22);
            this.txtPatientSearch.TabIndex = 9;
            // 
            // olvChargesList
            // 
            this.olvChargesList.AllColumns.Add(this.PatientID);
            this.olvChargesList.AllColumns.Add(this.Description);
            this.olvChargesList.AllColumns.Add(this.TotalAmount);
            this.olvChargesList.AllColumns.Add(this.ChargeDate);
            this.olvChargesList.AllColumns.Add(this.DueDate);
            this.olvChargesList.AllColumns.Add(this.ProcedureID);
            this.olvChargesList.AllColumns.Add(this.OfficeStaffId);
            this.olvChargesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvChargesList.CellEditUseWholeCell = false;
            this.olvChargesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.Description,
            this.TotalAmount,
            this.ChargeDate,
            this.DueDate,
            this.ProcedureID,
            this.OfficeStaffId});
            this.olvChargesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvChargesList.GridLines = true;
            this.olvChargesList.Location = new System.Drawing.Point(56, 89);
            this.olvChargesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olvChargesList.Name = "olvChargesList";
            this.olvChargesList.ShowGroups = false;
            this.olvChargesList.Size = new System.Drawing.Size(904, 278);
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
            // Description
            // 
            this.Description.AspectName = "description";
            this.Description.Text = "Description";
            this.Description.Width = 120;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AspectName = "amountTotal";
            this.TotalAmount.Text = "Amount Total";
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
            this.AcceptButton = this.btnSearchPatients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 457);
            this.Controls.Add(this.olvChargesList);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private BrightIdeasSoftware.OLVColumn Description;
        private BrightIdeasSoftware.OLVColumn TotalAmount;
        private BrightIdeasSoftware.OLVColumn ChargeDate;
        private BrightIdeasSoftware.OLVColumn DueDate;
        private BrightIdeasSoftware.OLVColumn ProcedureID;
        private BrightIdeasSoftware.OLVColumn OfficeStaffId;
    }
}