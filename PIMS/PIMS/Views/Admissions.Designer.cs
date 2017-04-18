namespace PIMS.Views
{
    partial class Admissions
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtAdmissionsSearch = new System.Windows.Forms.TextBox();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdmissionTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DischargeTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdmissionReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DischargeReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.PatientID);
            this.objectListView1.AllColumns.Add(this.AdmissionTime);
            this.objectListView1.AllColumns.Add(this.DischargeTime);
            this.objectListView1.AllColumns.Add(this.AdmissionReason);
            this.objectListView1.AllColumns.Add(this.DischargeReason);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.AdmissionTime,
            this.DischargeTime,
            this.AdmissionReason,
            this.DischargeReason});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(102, 91);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(770, 379);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(222, 38);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(165, 37);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // txtAdmissionsSearch
            // 
            this.txtAdmissionsSearch.Location = new System.Drawing.Point(409, 45);
            this.txtAdmissionsSearch.Name = "txtAdmissionsSearch";
            this.txtAdmissionsSearch.Size = new System.Drawing.Size(358, 22);
            this.txtAdmissionsSearch.TabIndex = 2;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 155;
            // 
            // AdmissionTime
            // 
            this.AdmissionTime.AspectName = "admissionTime";
            this.AdmissionTime.Text = "Admission Time";
            this.AdmissionTime.Width = 155;
            // 
            // DischargeTime
            // 
            this.DischargeTime.AspectName = "dischargeTime";
            this.DischargeTime.Text = "Discharge Time";
            this.DischargeTime.Width = 155;
            // 
            // AdmissionReason
            // 
            this.AdmissionReason.AspectName = "admissionReason";
            this.AdmissionReason.Text = "Admission Reason";
            this.AdmissionReason.Width = 155;
            // 
            // DischargeReason
            // 
            this.DischargeReason.AspectName = "dischargeReason";
            this.DischargeReason.Text = "Discharge Reason";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 510);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 510);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(462, 510);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(542, 510);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 22);
            this.textBox4.TabIndex = 6;
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Location = new System.Drawing.Point(313, 535);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(63, 17);
            this.lblFacility.TabIndex = 7;
            this.lblFacility.Text = "Facility #";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(469, 535);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(57, 17);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Room #";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(394, 535);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(52, 17);
            this.lblFloor.TabIndex = 9;
            this.lblFloor.Text = "Floor #";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(555, 535);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(45, 17);
            this.lblBed.TabIndex = 10;
            this.lblBed.Text = "Bed #";
            // 
            // Admissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 672);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblFacility);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAdmissionsSearch);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.objectListView1);
            this.Name = "Admissions";
            this.Text = "Admissions";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtAdmissionsSearch;
        private BrightIdeasSoftware.OLVColumn PatientID;
        private BrightIdeasSoftware.OLVColumn AdmissionTime;
        private BrightIdeasSoftware.OLVColumn DischargeTime;
        private BrightIdeasSoftware.OLVColumn AdmissionReason;
        private BrightIdeasSoftware.OLVColumn DischargeReason;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblBed;
    }
}