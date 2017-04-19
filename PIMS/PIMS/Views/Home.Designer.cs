namespace PIMS.Views
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.btnEmergencyContact = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.btnAdmissions = new System.Windows.Forms.Button();
            this.btnProcedures = new System.Windows.Forms.Button();
            this.btnPrescriptions = new System.Windows.Forms.Button();
            this.btnCharges = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotes
            // 
            this.btnNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotes.Location = new System.Drawing.Point(102, 643);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(179, 145);
            this.btnNotes.TabIndex = 23;
            this.btnNotes.Text = "Notes";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotes.UseVisualStyleBackColor = false;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnInsurance
            // 
            this.btnInsurance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsurance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsurance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsurance.Image = ((System.Drawing.Image)(resources.GetObject("btnInsurance.Image")));
            this.btnInsurance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsurance.Location = new System.Drawing.Point(102, 453);
            this.btnInsurance.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(179, 145);
            this.btnInsurance.TabIndex = 22;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsurance.UseVisualStyleBackColor = false;
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // btnEmergencyContact
            // 
            this.btnEmergencyContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmergencyContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmergencyContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyContact.Image = global::PIMS.Properties.Resources.Cases;
            this.btnEmergencyContact.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergencyContact.Location = new System.Drawing.Point(568, 270);
            this.btnEmergencyContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyContact.Name = "btnEmergencyContact";
            this.btnEmergencyContact.Size = new System.Drawing.Size(179, 145);
            this.btnEmergencyContact.TabIndex = 21;
            this.btnEmergencyContact.Text = "Emerg. Contact";
            this.btnEmergencyContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergencyContact.UseVisualStyleBackColor = false;
            this.btnEmergencyContact.Click += new System.EventHandler(this.btnEmergencyContact_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisitors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVisitors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.Image = global::PIMS.Properties.Resources.Patient;
            this.btnVisitors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisitors.Location = new System.Drawing.Point(566, 94);
            this.btnVisitors.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(179, 145);
            this.btnVisitors.TabIndex = 20;
            this.btnVisitors.Text = "Visitors";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisitors.UseVisualStyleBackColor = false;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // btnAdmissions
            // 
            this.btnAdmissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmissions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdmissions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmissions.Image = global::PIMS.Properties.Resources.Patient;
            this.btnAdmissions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmissions.Location = new System.Drawing.Point(334, 94);
            this.btnAdmissions.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmissions.Name = "btnAdmissions";
            this.btnAdmissions.Size = new System.Drawing.Size(179, 145);
            this.btnAdmissions.TabIndex = 19;
            this.btnAdmissions.Text = "Admissions";
            this.btnAdmissions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmissions.UseVisualStyleBackColor = false;
            this.btnAdmissions.Click += new System.EventHandler(this.btnAdmissions_Click);
            // 
            // btnProcedures
            // 
            this.btnProcedures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcedures.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcedures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedures.Image = global::PIMS.Properties.Resources.Cases;
            this.btnProcedures.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcedures.Location = new System.Drawing.Point(334, 270);
            this.btnProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcedures.Name = "btnProcedures";
            this.btnProcedures.Size = new System.Drawing.Size(179, 145);
            this.btnProcedures.TabIndex = 18;
            this.btnProcedures.Text = "Procedures";
            this.btnProcedures.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcedures.UseVisualStyleBackColor = false;
            this.btnProcedures.Click += new System.EventHandler(this.btnProcedures_Click);
            // 
            // btnPrescriptions
            // 
            this.btnPrescriptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrescriptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrescriptions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescriptions.Image = global::PIMS.Properties.Resources.Cases;
            this.btnPrescriptions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrescriptions.Location = new System.Drawing.Point(102, 270);
            this.btnPrescriptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.Size = new System.Drawing.Size(179, 145);
            this.btnPrescriptions.TabIndex = 17;
            this.btnPrescriptions.Text = "Prescriptions";
            this.btnPrescriptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrescriptions.UseVisualStyleBackColor = false;
            this.btnPrescriptions.Click += new System.EventHandler(this.btnPrescriptions_Click);
            // 
            // btnCharges
            // 
            this.btnCharges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCharges.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCharges.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharges.Image = ((System.Drawing.Image)(resources.GetObject("btnCharges.Image")));
            this.btnCharges.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCharges.Location = new System.Drawing.Point(334, 453);
            this.btnCharges.Margin = new System.Windows.Forms.Padding(4);
            this.btnCharges.Name = "btnCharges";
            this.btnCharges.Size = new System.Drawing.Size(179, 145);
            this.btnCharges.TabIndex = 16;
            this.btnCharges.Text = "Charges";
            this.btnCharges.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCharges.UseVisualStyleBackColor = false;
            this.btnCharges.Click += new System.EventHandler(this.btnCharges_Click);
            // 
            // btnBills
            // 
            this.btnBills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBills.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBills.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.Image")));
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBills.Location = new System.Drawing.Point(568, 453);
            this.btnBills.Margin = new System.Windows.Forms.Padding(4);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(179, 145);
            this.btnBills.TabIndex = 15;
            this.btnBills.Text = "Bills";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOut.Location = new System.Drawing.Point(566, 643);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(179, 145);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(334, 643);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(179, 145);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatients.Location = new System.Drawing.Point(102, 93);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(179, 145);
            this.btnPatients.TabIndex = 9;
            this.btnPatients.Text = "Patients";
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(865, 832);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnInsurance);
            this.Controls.Add(this.btnEmergencyContact);
            this.Controls.Add(this.btnVisitors);
            this.Controls.Add(this.btnAdmissions);
            this.Controls.Add(this.btnProcedures);
            this.Controls.Add(this.btnPrescriptions);
            this.Controls.Add(this.btnCharges);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnPatients);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnCharges;
        private System.Windows.Forms.Button btnPrescriptions;
        private System.Windows.Forms.Button btnProcedures;
        private System.Windows.Forms.Button btnAdmissions;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnEmergencyContact;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Button btnNotes;
    }
}