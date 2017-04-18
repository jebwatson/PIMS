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
            this.btnSearchBills = new System.Windows.Forms.Button();
            this.txtBillsSearch = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Total = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaidbyPatient = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaidbyInsurance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AmountOwed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateCharged = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateDue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchBills
            // 
            this.btnSearchBills.Location = new System.Drawing.Point(250, 49);
            this.btnSearchBills.Name = "btnSearchBills";
            this.btnSearchBills.Size = new System.Drawing.Size(125, 29);
            this.btnSearchBills.TabIndex = 8;
            this.btnSearchBills.Text = "Search";
            this.btnSearchBills.UseVisualStyleBackColor = true;
            // 
            // txtBillsSearch
            // 
            this.txtBillsSearch.Location = new System.Drawing.Point(381, 52);
            this.txtBillsSearch.Name = "txtBillsSearch";
            this.txtBillsSearch.Size = new System.Drawing.Size(341, 22);
            this.txtBillsSearch.TabIndex = 9;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.PatientID);
            this.objectListView1.AllColumns.Add(this.lname);
            this.objectListView1.AllColumns.Add(this.fname);
            this.objectListView1.AllColumns.Add(this.Total);
            this.objectListView1.AllColumns.Add(this.PaidbyPatient);
            this.objectListView1.AllColumns.Add(this.PaidbyInsurance);
            this.objectListView1.AllColumns.Add(this.AmountOwed);
            this.objectListView1.AllColumns.Add(this.DateCharged);
            this.objectListView1.AllColumns.Add(this.DateDue);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.lname,
            this.fname,
            this.Total,
            this.PaidbyPatient,
            this.PaidbyInsurance,
            this.AmountOwed,
            this.DateCharged,
            this.DateDue});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(42, 94);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(939, 279);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 100;
            // 
            // lname
            // 
            this.lname.AspectName = "nameLast";
            this.lname.Text = "Last Name";
            this.lname.Width = 100;
            // 
            // fname
            // 
            this.fname.AspectName = "nameFirst";
            this.fname.Text = "First Name";
            this.fname.Width = 100;
            // 
            // Total
            // 
            this.Total.AspectName = "amountTotal";
            this.Total.Text = "Total";
            this.Total.Width = 100;
            // 
            // PaidbyPatient
            // 
            this.PaidbyPatient.AspectName = "amountPaidbyPatient";
            this.PaidbyPatient.Text = "Paid By Patient";
            this.PaidbyPatient.Width = 120;
            // 
            // PaidbyInsurance
            // 
            this.PaidbyInsurance.AspectName = "amountPaidbyInsurance";
            this.PaidbyInsurance.Text = "Paid By Insurance";
            this.PaidbyInsurance.Width = 120;
            // 
            // AmountOwed
            // 
            this.AmountOwed.AspectName = "amountOwed";
            this.AmountOwed.Text = "Amount Owed";
            this.AmountOwed.Width = 100;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 457);
            this.Controls.Add(this.txtBillsSearch);
            this.Controls.Add(this.btnSearchBills);
            this.Controls.Add(this.objectListView1);
            this.Name = "Bills";
            this.Text = "Bills";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.Button btnSearchBills;
        private System.Windows.Forms.TextBox txtBillsSearch;
        private BrightIdeasSoftware.OLVColumn Total;
        private BrightIdeasSoftware.OLVColumn PaidbyPatient;
        private BrightIdeasSoftware.OLVColumn PaidbyInsurance;
        private BrightIdeasSoftware.OLVColumn AmountOwed;
        private BrightIdeasSoftware.OLVColumn DateCharged;
        private BrightIdeasSoftware.OLVColumn DateDue;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn fname;
        private BrightIdeasSoftware.OLVColumn lname;
    }
}