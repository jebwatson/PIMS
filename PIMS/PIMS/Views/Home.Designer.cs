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
            this.imgPims = new System.Windows.Forms.PictureBox();
            this.casesDatView = new BrightIdeasSoftware.DataListView();
            this.btnAddCase = new System.Windows.Forms.Button();
            this.btnRemoveCase = new System.Windows.Forms.Button();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.btnViewPatients = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesDatView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPims
            // 
            this.imgPims.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPims.Image = global::PIMS.Properties.Resources.Redcrossnew1;
            this.imgPims.Location = new System.Drawing.Point(12, 26);
            this.imgPims.Name = "imgPims";
            this.imgPims.Size = new System.Drawing.Size(122, 122);
            this.imgPims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPims.TabIndex = 1;
            this.imgPims.TabStop = false;
            // 
            // casesDatView
            // 
            this.casesDatView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.casesDatView.CellEditUseWholeCell = false;
            this.casesDatView.DataSource = null;
            this.casesDatView.Location = new System.Drawing.Point(395, 159);
            this.casesDatView.Name = "casesDatView";
            this.casesDatView.Size = new System.Drawing.Size(613, 348);
            this.casesDatView.TabIndex = 2;
            this.casesDatView.UseCompatibleStateImageBehavior = false;
            this.casesDatView.View = System.Windows.Forms.View.Details;
            // 
            // btnAddCase
            // 
            this.btnAddCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCase.Location = new System.Drawing.Point(507, 525);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(173, 47);
            this.btnAddCase.TabIndex = 3;
            this.btnAddCase.Text = "Add Case";
            this.btnAddCase.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCase
            // 
            this.btnRemoveCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveCase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCase.Location = new System.Drawing.Point(745, 525);
            this.btnRemoveCase.Name = "btnRemoveCase";
            this.btnRemoveCase.Size = new System.Drawing.Size(173, 47);
            this.btnRemoveCase.TabIndex = 4;
            this.btnRemoveCase.Text = "Remove Case";
            this.btnRemoveCase.UseVisualStyleBackColor = true;
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaff.Location = new System.Drawing.Point(204, 181);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(173, 47);
            this.btnViewStaff.TabIndex = 5;
            this.btnViewStaff.Text = "View Staff";
            this.btnViewStaff.UseVisualStyleBackColor = true;
            // 
            // btnViewPatients
            // 
            this.btnViewPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewPatients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatients.Location = new System.Drawing.Point(204, 272);
            this.btnViewPatients.Name = "btnViewPatients";
            this.btnViewPatients.Size = new System.Drawing.Size(173, 47);
            this.btnViewPatients.TabIndex = 6;
            this.btnViewPatients.Text = "View Patients";
            this.btnViewPatients.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPatient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(204, 369);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(173, 47);
            this.btnAddPatient.TabIndex = 7;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 525);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 47);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(388, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(168, 39);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome,";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(568, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 39);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Title + Name";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 598);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnViewPatients);
            this.Controls.Add(this.btnViewStaff);
            this.Controls.Add(this.btnRemoveCase);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.casesDatView);
            this.Controls.Add(this.imgPims);
            this.Name = "frmHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.imgPims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesDatView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPims;
        private BrightIdeasSoftware.DataListView casesDatView;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.Button btnRemoveCase;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.Button btnViewPatients;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox textBox1;
    }
}