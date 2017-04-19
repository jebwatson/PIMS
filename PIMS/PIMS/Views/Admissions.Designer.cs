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
            this.olvAdmissionsList = new BrightIdeasSoftware.ObjectListView();
            this.PatientID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdmissionTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DischargeTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdmissionReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DischargeReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Facility = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Floor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Room = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Bed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvAdmissionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // olvAdmissionsList
            // 
            this.olvAdmissionsList.AllColumns.Add(this.PatientID);
            this.olvAdmissionsList.AllColumns.Add(this.AdmissionTime);
            this.olvAdmissionsList.AllColumns.Add(this.DischargeTime);
            this.olvAdmissionsList.AllColumns.Add(this.AdmissionReason);
            this.olvAdmissionsList.AllColumns.Add(this.DischargeReason);
            this.olvAdmissionsList.AllColumns.Add(this.Facility);
            this.olvAdmissionsList.AllColumns.Add(this.Floor);
            this.olvAdmissionsList.AllColumns.Add(this.Room);
            this.olvAdmissionsList.AllColumns.Add(this.Bed);
            this.olvAdmissionsList.CellEditUseWholeCell = false;
            this.olvAdmissionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.AdmissionTime,
            this.DischargeTime,
            this.AdmissionReason,
            this.DischargeReason,
            this.Facility,
            this.Floor,
            this.Room,
            this.Bed});
            this.olvAdmissionsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAdmissionsList.GridLines = true;
            this.olvAdmissionsList.Location = new System.Drawing.Point(9, 66);
            this.olvAdmissionsList.Margin = new System.Windows.Forms.Padding(2);
            this.olvAdmissionsList.Name = "olvAdmissionsList";
            this.olvAdmissionsList.Size = new System.Drawing.Size(680, 309);
            this.olvAdmissionsList.TabIndex = 0;
            this.olvAdmissionsList.UseCompatibleStateImageBehavior = false;
            this.olvAdmissionsList.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.AspectName = "patientId";
            this.PatientID.Text = "Patient ID";
            this.PatientID.Width = 120;
            // 
            // AdmissionTime
            // 
            this.AdmissionTime.AspectName = "admissionTime";
            this.AdmissionTime.Text = "Admission Time";
            this.AdmissionTime.Width = 120;
            // 
            // DischargeTime
            // 
            this.DischargeTime.AspectName = "dischargeTime";
            this.DischargeTime.Text = "Discharge Time";
            this.DischargeTime.Width = 120;
            // 
            // AdmissionReason
            // 
            this.AdmissionReason.AspectName = "admissionReason";
            this.AdmissionReason.Text = "Admission Reason";
            this.AdmissionReason.Width = 150;
            // 
            // DischargeReason
            // 
            this.DischargeReason.AspectName = "dischargeReason";
            this.DischargeReason.Text = "Discharge Reason";
            this.DischargeReason.Width = 150;
            // 
            // Facility
            // 
            this.Facility.AspectName = "facility";
            this.Facility.Text = "Facility";
            // 
            // Floor
            // 
            this.Floor.AspectName = "floor";
            this.Floor.Text = "Floor";
            // 
            // Room
            // 
            this.Room.AspectName = "roomNumber";
            this.Room.Text = "Room";
            this.Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Bed
            // 
            this.Bed.AspectName = "bedNumber";
            this.Bed.Text = "Bed";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(318, 34);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(97, 25);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(419, 37);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(270, 20);
            this.txtPatientSearch.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 414);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 414);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(346, 414);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(406, 414);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 6;
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Location = new System.Drawing.Point(235, 435);
            this.lblFacility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(49, 13);
            this.lblFacility.TabIndex = 7;
            this.lblFacility.Text = "Facility #";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(352, 435);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(45, 13);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Room #";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(296, 435);
            this.lblFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(40, 13);
            this.lblFloor.TabIndex = 9;
            this.lblFloor.Text = "Floor #";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(416, 435);
            this.lblBed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(36, 13);
            this.lblBed.TabIndex = 10;
            this.lblBed.Text = "Bed #";
            // 
            // Admissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 465);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblFacility);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.olvAdmissionsList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admissions";
            this.Text = "Admissions";
            ((System.ComponentModel.ISupportInitialize)(this.olvAdmissionsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvAdmissionsList;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtPatientSearch;
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
        private BrightIdeasSoftware.OLVColumn Facility;
        private BrightIdeasSoftware.OLVColumn Floor;
        private BrightIdeasSoftware.OLVColumn Room;
        private BrightIdeasSoftware.OLVColumn Bed;
    }
}