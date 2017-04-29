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
            this.btnRefreshPatients = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnDeletePatients = new System.Windows.Forms.Button();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.olvPatientsList = new BrightIdeasSoftware.ObjectListView();
            this.id = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.street = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.city = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.state = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.zip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.phonehome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.areacodehome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.phonework = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.areaCodeWork = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.phonemobile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.areaCodeMobile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.familydoctor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvPatientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshPatients
            // 
            this.btnRefreshPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnDeletePatients.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.txtPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientSearch.Location = new System.Drawing.Point(199, 35);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(373, 20);
            this.txtPatientSearch.TabIndex = 4;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(118, 32);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatients.TabIndex = 5;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // olvPatientsList
            // 
            this.olvPatientsList.AllColumns.Add(this.id);
            this.olvPatientsList.AllColumns.Add(this.lname);
            this.olvPatientsList.AllColumns.Add(this.fname);
            this.olvPatientsList.AllColumns.Add(this.mname);
            this.olvPatientsList.AllColumns.Add(this.street);
            this.olvPatientsList.AllColumns.Add(this.city);
            this.olvPatientsList.AllColumns.Add(this.state);
            this.olvPatientsList.AllColumns.Add(this.zip);
            this.olvPatientsList.AllColumns.Add(this.phonehome);
            this.olvPatientsList.AllColumns.Add(this.areacodehome);
            this.olvPatientsList.AllColumns.Add(this.phonework);
            this.olvPatientsList.AllColumns.Add(this.areaCodeWork);
            this.olvPatientsList.AllColumns.Add(this.phonemobile);
            this.olvPatientsList.AllColumns.Add(this.areaCodeMobile);
            this.olvPatientsList.AllColumns.Add(this.familydoctor);
            this.olvPatientsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvPatientsList.CellEditUseWholeCell = false;
            this.olvPatientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.lname,
            this.fname,
            this.mname,
            this.street,
            this.city,
            this.state,
            this.zip,
            this.phonehome,
            this.areacodehome,
            this.phonework,
            this.areaCodeWork,
            this.phonemobile,
            this.areaCodeMobile,
            this.familydoctor});
            this.olvPatientsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPatientsList.FullRowSelect = true;
            this.olvPatientsList.GridLines = true;
            this.olvPatientsList.Location = new System.Drawing.Point(118, 59);
            this.olvPatientsList.Name = "olvPatientsList";
            this.olvPatientsList.ShowGroups = false;
            this.olvPatientsList.Size = new System.Drawing.Size(1209, 340);
            this.olvPatientsList.TabIndex = 0;
            this.olvPatientsList.UseCompatibleStateImageBehavior = false;
            this.olvPatientsList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.AspectName = "patientId";
            this.id.Text = "Patient Id";
            this.id.Width = 100;
            // 
            // lname
            // 
            this.lname.AspectName = "nameLast";
            this.lname.Text = "Last";
            this.lname.Width = 100;
            // 
            // fname
            // 
            this.fname.AspectName = "nameFirst";
            this.fname.Text = "First";
            this.fname.Width = 100;
            // 
            // mname
            // 
            this.mname.AspectName = "nameMiddle";
            this.mname.Text = "Middle Name";
            this.mname.Width = 100;
            // 
            // street
            // 
            this.street.AspectName = "street";
            this.street.Text = "Street";
            this.street.Width = 100;
            // 
            // city
            // 
            this.city.AspectName = "city";
            this.city.Text = "City";
            this.city.Width = 100;
            // 
            // state
            // 
            this.state.AspectName = "state";
            this.state.Text = "State";
            this.state.Width = 100;
            // 
            // zip
            // 
            this.zip.AspectName = "zip";
            this.zip.AspectToStringFormat = "";
            this.zip.Text = "Zip Code";
            this.zip.Width = 100;
            // 
            // phonehome
            // 
            this.phonehome.AspectName = "phoneHome";
            this.phonehome.Text = "Home Phone";
            this.phonehome.Width = 100;
            // 
            // areacodehome
            // 
            this.areacodehome.AspectName = "areaCodeHome";
            this.areacodehome.Text = "Area Code(Home)";
            this.areacodehome.Width = 130;
            // 
            // phonework
            // 
            this.phonework.AspectName = "phoneWork";
            this.phonework.Text = "Work Phone";
            this.phonework.Width = 100;
            // 
            // areaCodeWork
            // 
            this.areaCodeWork.AspectName = "areaCodeWork";
            this.areaCodeWork.Text = "Area Code(Work)";
            this.areaCodeWork.Width = 130;
            // 
            // phonemobile
            // 
            this.phonemobile.AspectName = "phoneMobile";
            this.phonemobile.Text = "Mobile Phone";
            this.phonemobile.Width = 100;
            // 
            // areaCodeMobile
            // 
            this.areaCodeMobile.AspectName = "areaCodeMobile";
            this.areaCodeMobile.Text = "Area Code(Mobile)";
            this.areaCodeMobile.Width = 130;
            // 
            // familydoctor
            // 
            this.familydoctor.AspectName = "familyDoctor";
            this.familydoctor.Text = "Family Doctor";
            this.familydoctor.Width = 100;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 468);
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
        private BrightIdeasSoftware.OLVColumn lname;
        private BrightIdeasSoftware.OLVColumn fname;
        private BrightIdeasSoftware.OLVColumn mname;
        private BrightIdeasSoftware.OLVColumn street;
        private BrightIdeasSoftware.OLVColumn city;
        private BrightIdeasSoftware.OLVColumn state;
        private BrightIdeasSoftware.OLVColumn zip;
        private BrightIdeasSoftware.OLVColumn phonehome;
        private BrightIdeasSoftware.OLVColumn areacodehome;
        private BrightIdeasSoftware.OLVColumn phonework;
        private BrightIdeasSoftware.OLVColumn areaCodeWork;
        private BrightIdeasSoftware.OLVColumn phonemobile;
        private BrightIdeasSoftware.OLVColumn areaCodeMobile;
        private BrightIdeasSoftware.OLVColumn familydoctor;
    }
}