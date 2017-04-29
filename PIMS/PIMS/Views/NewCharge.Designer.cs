namespace PIMS.Views
{
    partial class NewCharge
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAmountDescriptions = new System.Windows.Forms.Label();
            this.lblAmountTotal = new System.Windows.Forms.Label();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.lblDateCharged = new System.Windows.Forms.Label();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.dtpDateCharged = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDue = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(567, 80);
            this.txtDescription.TabIndex = 0;
            // 
            // lblAmountDescriptions
            // 
            this.lblAmountDescriptions.AutoSize = true;
            this.lblAmountDescriptions.Location = new System.Drawing.Point(12, 75);
            this.lblAmountDescriptions.Name = "lblAmountDescriptions";
            this.lblAmountDescriptions.Size = new System.Drawing.Size(60, 13);
            this.lblAmountDescriptions.TabIndex = 1;
            this.lblAmountDescriptions.Text = "Description";
            // 
            // lblAmountTotal
            // 
            this.lblAmountTotal.AutoSize = true;
            this.lblAmountTotal.Location = new System.Drawing.Point(12, 185);
            this.lblAmountTotal.Name = "lblAmountTotal";
            this.lblAmountTotal.Size = new System.Drawing.Size(73, 13);
            this.lblAmountTotal.TabIndex = 2;
            this.lblAmountTotal.Text = "Amount Total:";
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.Location = new System.Drawing.Point(91, 182);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.Size = new System.Drawing.Size(215, 20);
            this.txtAmountTotal.TabIndex = 3;
            // 
            // lblDateCharged
            // 
            this.lblDateCharged.AutoSize = true;
            this.lblDateCharged.Location = new System.Drawing.Point(9, 223);
            this.lblDateCharged.Name = "lblDateCharged";
            this.lblDateCharged.Size = new System.Drawing.Size(76, 13);
            this.lblDateCharged.TabIndex = 4;
            this.lblDateCharged.Text = "Date Charged:";
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Location = new System.Drawing.Point(29, 259);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(56, 13);
            this.lblDateDue.TabIndex = 5;
            this.lblDateDue.Text = "Date Due:";
            // 
            // dtpDateCharged
            // 
            this.dtpDateCharged.Location = new System.Drawing.Point(91, 217);
            this.dtpDateCharged.Name = "dtpDateCharged";
            this.dtpDateCharged.Size = new System.Drawing.Size(215, 20);
            this.dtpDateCharged.TabIndex = 6;
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.Location = new System.Drawing.Point(91, 253);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.Size = new System.Drawing.Size(215, 20);
            this.dtpDateDue.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(91, 296);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(12, 23);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(52, 13);
            this.lblPatientId.TabIndex = 12;
            this.lblPatientId.Text = "Patient Id";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(12, 39);
            this.txtPatientId.Multiline = true;
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(109, 28);
            this.txtPatientId.TabIndex = 13;
            // 
            // NewCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 339);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpDateDue);
            this.Controls.Add(this.dtpDateCharged);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.lblDateCharged);
            this.Controls.Add(this.txtAmountTotal);
            this.Controls.Add(this.lblAmountTotal);
            this.Controls.Add(this.lblAmountDescriptions);
            this.Controls.Add(this.txtDescription);
            this.Name = "NewCharge";
            this.Text = "Add Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAmountDescriptions;
        private System.Windows.Forms.Label lblAmountTotal;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.Label lblDateCharged;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.DateTimePicker dtpDateCharged;
        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.TextBox txtPatientId;
    }
}