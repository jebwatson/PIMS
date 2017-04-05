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
            this.btnAddCase = new System.Windows.Forms.Button();
            this.btnRemoveCase = new System.Windows.Forms.Button();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.btnViewPatients = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imgPims = new System.Windows.Forms.PictureBox();
            this.olvHomeList = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.imgPims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvHomeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCase
            // 
            this.btnAddCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCase.Location = new System.Drawing.Point(380, 427);
            this.btnAddCase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(130, 38);
            this.btnAddCase.TabIndex = 3;
            this.btnAddCase.Text = "Add Case";
            this.btnAddCase.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCase
            // 
            this.btnRemoveCase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveCase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCase.Location = new System.Drawing.Point(559, 427);
            this.btnRemoveCase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveCase.Name = "btnRemoveCase";
            this.btnRemoveCase.Size = new System.Drawing.Size(130, 38);
            this.btnRemoveCase.TabIndex = 4;
            this.btnRemoveCase.Text = "Remove Case";
            this.btnRemoveCase.UseVisualStyleBackColor = true;
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaff.Location = new System.Drawing.Point(153, 147);
            this.btnViewStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(130, 38);
            this.btnViewStaff.TabIndex = 5;
            this.btnViewStaff.Text = "View Staff";
            this.btnViewStaff.UseVisualStyleBackColor = true;
            // 
            // btnViewPatients
            // 
            this.btnViewPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewPatients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatients.Location = new System.Drawing.Point(153, 221);
            this.btnViewPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewPatients.Name = "btnViewPatients";
            this.btnViewPatients.Size = new System.Drawing.Size(130, 38);
            this.btnViewPatients.TabIndex = 6;
            this.btnViewPatients.Text = "View Patients";
            this.btnViewPatients.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPatient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(153, 300);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(130, 38);
            this.btnAddPatient.TabIndex = 7;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(9, 427);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 38);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(291, 41);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(134, 31);
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
            this.textBox1.Location = new System.Drawing.Point(426, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Title + Name";
            // 
            // imgPims
            // 
            this.imgPims.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPims.Image = global::PIMS.Properties.Resources.Redcrossnew1;
            this.imgPims.Location = new System.Drawing.Point(9, 21);
            this.imgPims.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgPims.Name = "imgPims";
            this.imgPims.Size = new System.Drawing.Size(122, 122);
            this.imgPims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPims.TabIndex = 1;
            this.imgPims.TabStop = false;
            // 
            // olvHomeList
            // 
            this.olvHomeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvHomeList.CellEditUseWholeCell = false;
            this.olvHomeList.Location = new System.Drawing.Point(297, 88);
            this.olvHomeList.Name = "olvHomeList";
            this.olvHomeList.Size = new System.Drawing.Size(518, 323);
            this.olvHomeList.TabIndex = 11;
            this.olvHomeList.UseCompatibleStateImageBehavior = false;
            this.olvHomeList.View = System.Windows.Forms.View.Details;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 486);
            this.Controls.Add(this.olvHomeList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnViewPatients);
            this.Controls.Add(this.btnViewStaff);
            this.Controls.Add(this.btnRemoveCase);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.imgPims);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.imgPims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvHomeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPims;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.Button btnRemoveCase;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.Button btnViewPatients;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox textBox1;
        private BrightIdeasSoftware.ObjectListView olvHomeList;
    }
}