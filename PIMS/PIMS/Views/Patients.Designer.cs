namespace PIMS.Views
{
    partial class Patients
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
            this.olvPatientsList = new BrightIdeasSoftware.ObjectListView();
            this.id = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.firstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnRefreshPatients = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnDeletePatients = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvPatientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // olvPatientsList
            // 
            this.olvPatientsList.AllColumns.Add(this.id);
            this.olvPatientsList.AllColumns.Add(this.lastName);
            this.olvPatientsList.AllColumns.Add(this.firstName);
            this.olvPatientsList.CellEditUseWholeCell = false;
            this.olvPatientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.lastName,
            this.firstName});
            this.olvPatientsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPatientsList.Location = new System.Drawing.Point(118, 59);
            this.olvPatientsList.Name = "olvPatientsList";
            this.olvPatientsList.ShowGroups = false;
            this.olvPatientsList.Size = new System.Drawing.Size(610, 412);
            this.olvPatientsList.TabIndex = 0;
            this.olvPatientsList.UseCompatibleStateImageBehavior = false;
            this.olvPatientsList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.AspectName = "patientId";
            this.id.Text = "Patient Id";
            this.id.Width = 70;
            // 
            // lastName
            // 
            this.lastName.AspectName = "nameLast";
            this.lastName.Text = "Last";
            this.lastName.Width = 75;
            // 
            // firstName
            // 
            this.firstName.AspectName = "nameFirst";
            this.firstName.Text = "First";
            this.firstName.Width = 93;
            // 
            // btnRefreshPatients
            // 
            this.btnRefreshPatients.Location = new System.Drawing.Point(12, 59);
            this.btnRefreshPatients.Name = "btnRefreshPatients";
            this.btnRefreshPatients.Size = new System.Drawing.Size(100, 45);
            this.btnRefreshPatients.TabIndex = 1;
            this.btnRefreshPatients.Text = "Refresh";
            this.btnRefreshPatients.UseVisualStyleBackColor = true;
            this.btnRefreshPatients.Click += new System.EventHandler(this.btnRefreshPatients_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(12, 110);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(100, 50);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Add Patient(s)";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnDeletePatients
            // 
            this.btnDeletePatients.Location = new System.Drawing.Point(12, 166);
            this.btnDeletePatients.Name = "btnDeletePatients";
            this.btnDeletePatients.Size = new System.Drawing.Size(100, 50);
            this.btnDeletePatients.TabIndex = 3;
            this.btnDeletePatients.Text = "Delete Patient(s)";
            this.btnDeletePatients.UseVisualStyleBackColor = true;
            this.btnDeletePatients.Click += new System.EventHandler(this.btnDeletePatients_Click);
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(355, 33);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(373, 20);
            this.txtPatientSearch.TabIndex = 4;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(274, 30);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatients.TabIndex = 5;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 483);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnDeletePatients);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnRefreshPatients);
            this.Controls.Add(this.olvPatientsList);
            this.Name = "Patients";
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.olvPatientsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvPatientsList;
        private System.Windows.Forms.Button btnRefreshPatients;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnDeletePatients;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Button btnSearchPatients;
        private BrightIdeasSoftware.OLVColumn id;
        private BrightIdeasSoftware.OLVColumn lastName;
        private BrightIdeasSoftware.OLVColumn firstName;
    }
}