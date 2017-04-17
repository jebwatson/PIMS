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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnCharges = new System.Windows.Forms.Button();
            this.btnPrescriptions = new System.Windows.Forms.Button();
            this.btnProcedures = new System.Windows.Forms.Button();
            this.btnAdmissions = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.btnEmergencyContact = new System.Windows.Forms.Button();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(661, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(693, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(246, 201);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(133, 118);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReports.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Location = new System.Drawing.Point(75, 201);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(134, 118);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatients.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.Location = new System.Drawing.Point(75, 50);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(134, 122);
            this.btnPatients.TabIndex = 9;
            this.btnPatients.Text = "Patients";
            this.btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnBills
            // 
            this.btnBills.Location = new System.Drawing.Point(246, 50);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(133, 122);
            this.btnBills.TabIndex = 15;
            this.btnBills.Text = "Bills";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnCharges
            // 
            this.btnCharges.Location = new System.Drawing.Point(420, 50);
            this.btnCharges.Name = "btnCharges";
            this.btnCharges.Size = new System.Drawing.Size(139, 122);
            this.btnCharges.TabIndex = 16;
            this.btnCharges.Text = "Charges";
            this.btnCharges.UseVisualStyleBackColor = true;
            this.btnCharges.Click += new System.EventHandler(this.btnCharges_Click);
            // 
            // btnPrescriptions
            // 
            this.btnPrescriptions.Location = new System.Drawing.Point(420, 201);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.Size = new System.Drawing.Size(139, 118);
            this.btnPrescriptions.TabIndex = 17;
            this.btnPrescriptions.Text = "Prescriptions";
            this.btnPrescriptions.UseVisualStyleBackColor = true;
            this.btnPrescriptions.Click += new System.EventHandler(this.btnPrescriptions_Click);
            // 
            // btnProcedures
            // 
            this.btnProcedures.Location = new System.Drawing.Point(75, 352);
            this.btnProcedures.Name = "btnProcedures";
            this.btnProcedures.Size = new System.Drawing.Size(134, 108);
            this.btnProcedures.TabIndex = 18;
            this.btnProcedures.Text = "Procedures";
            this.btnProcedures.UseVisualStyleBackColor = true;
            this.btnProcedures.Click += new System.EventHandler(this.btnProcedures_Click);
            // 
            // btnAdmissions
            // 
            this.btnAdmissions.Location = new System.Drawing.Point(246, 352);
            this.btnAdmissions.Name = "btnAdmissions";
            this.btnAdmissions.Size = new System.Drawing.Size(133, 108);
            this.btnAdmissions.TabIndex = 19;
            this.btnAdmissions.Text = "Admissions";
            this.btnAdmissions.UseVisualStyleBackColor = true;
            this.btnAdmissions.Click += new System.EventHandler(this.btnAdmissions_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.Location = new System.Drawing.Point(420, 352);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(139, 108);
            this.btnVisitors.TabIndex = 20;
            this.btnVisitors.Text = "Visitors";
            this.btnVisitors.UseVisualStyleBackColor = true;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // btnEmergencyContact
            // 
            this.btnEmergencyContact.Location = new System.Drawing.Point(75, 496);
            this.btnEmergencyContact.Name = "btnEmergencyContact";
            this.btnEmergencyContact.Size = new System.Drawing.Size(134, 125);
            this.btnEmergencyContact.TabIndex = 21;
            this.btnEmergencyContact.Text = "Emergency Contact";
            this.btnEmergencyContact.UseVisualStyleBackColor = true;
            this.btnEmergencyContact.Click += new System.EventHandler(this.btnEmergencyContact_Click);
            // 
            // btnInsurance
            // 
            this.btnInsurance.Location = new System.Drawing.Point(246, 496);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(133, 125);
            this.btnInsurance.TabIndex = 22;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.UseVisualStyleBackColor = true;
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 125);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(725, 675);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInsurance);
            this.Controls.Add(this.btnEmergencyContact);
            this.Controls.Add(this.btnVisitors);
            this.Controls.Add(this.btnAdmissions);
            this.Controls.Add(this.btnProcedures);
            this.Controls.Add(this.btnPrescriptions);
            this.Controls.Add(this.btnCharges);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnPatients);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnCharges;
        private System.Windows.Forms.Button btnPrescriptions;
        private System.Windows.Forms.Button btnProcedures;
        private System.Windows.Forms.Button btnAdmissions;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnEmergencyContact;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Button button3;
    }
}