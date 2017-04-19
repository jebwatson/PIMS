namespace PIMS.Views
{
    partial class AddPrescription
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
            this.prescriptionNameText = new System.Windows.Forms.TextBox();
            this.prescriptionIdText = new System.Windows.Forms.TextBox();
            this.patientIdText = new System.Windows.Forms.TextBox();
            this.prescriptionAmountText = new System.Windows.Forms.TextBox();
            this.prescriptionDateText = new System.Windows.Forms.TextBox();
            this.prescriptionDurationText = new System.Windows.Forms.TextBox();
            this.submitPrescription = new System.Windows.Forms.Button();
            this.prescriptionName = new System.Windows.Forms.Label();
            this.presctiptionId = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.Label();
            this.prescriptionAmount = new System.Windows.Forms.Label();
            this.prescriptionDate = new System.Windows.Forms.Label();
            this.prescriptionDuration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prescriptionNameText
            // 
            this.prescriptionNameText.Location = new System.Drawing.Point(33, 66);
            this.prescriptionNameText.Name = "prescriptionNameText";
            this.prescriptionNameText.Size = new System.Drawing.Size(145, 20);
            this.prescriptionNameText.TabIndex = 0;
            // 
            // prescriptionIdText
            // 
            this.prescriptionIdText.Location = new System.Drawing.Point(213, 66);
            this.prescriptionIdText.Name = "prescriptionIdText";
            this.prescriptionIdText.Size = new System.Drawing.Size(145, 20);
            this.prescriptionIdText.TabIndex = 1;
            // 
            // patientIdText
            // 
            this.patientIdText.Location = new System.Drawing.Point(389, 66);
            this.patientIdText.Name = "patientIdText";
            this.patientIdText.Size = new System.Drawing.Size(145, 20);
            this.patientIdText.TabIndex = 2;
            // 
            // prescriptionAmountText
            // 
            this.prescriptionAmountText.Location = new System.Drawing.Point(33, 157);
            this.prescriptionAmountText.Name = "prescriptionAmountText";
            this.prescriptionAmountText.Size = new System.Drawing.Size(145, 20);
            this.prescriptionAmountText.TabIndex = 3;
            // 
            // prescriptionDateText
            // 
            this.prescriptionDateText.Location = new System.Drawing.Point(213, 157);
            this.prescriptionDateText.Name = "prescriptionDateText";
            this.prescriptionDateText.Size = new System.Drawing.Size(145, 20);
            this.prescriptionDateText.TabIndex = 4;
            // 
            // prescriptionDurationText
            // 
            this.prescriptionDurationText.Location = new System.Drawing.Point(389, 157);
            this.prescriptionDurationText.Name = "prescriptionDurationText";
            this.prescriptionDurationText.Size = new System.Drawing.Size(145, 20);
            this.prescriptionDurationText.TabIndex = 5;
            // 
            // submitPrescription
            // 
            this.submitPrescription.Location = new System.Drawing.Point(409, 204);
            this.submitPrescription.Name = "submitPrescription";
            this.submitPrescription.Size = new System.Drawing.Size(109, 53);
            this.submitPrescription.TabIndex = 6;
            this.submitPrescription.Text = "Submit";
            this.submitPrescription.UseVisualStyleBackColor = true;
            // 
            // prescriptionName
            // 
            this.prescriptionName.AutoSize = true;
            this.prescriptionName.Location = new System.Drawing.Point(59, 50);
            this.prescriptionName.Name = "prescriptionName";
            this.prescriptionName.Size = new System.Drawing.Size(93, 13);
            this.prescriptionName.TabIndex = 7;
            this.prescriptionName.Text = "Prescription Name";
            // 
            // presctiptionId
            // 
            this.presctiptionId.AutoSize = true;
            this.presctiptionId.Location = new System.Drawing.Point(245, 50);
            this.presctiptionId.Name = "presctiptionId";
            this.presctiptionId.Size = new System.Drawing.Size(76, 13);
            this.presctiptionId.TabIndex = 8;
            this.presctiptionId.Text = "Prescription ID";
            // 
            // patientId
            // 
            this.patientId.AutoSize = true;
            this.patientId.Location = new System.Drawing.Point(439, 50);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(54, 13);
            this.patientId.TabIndex = 9;
            this.patientId.Text = "Patient ID";
            // 
            // prescriptionAmount
            // 
            this.prescriptionAmount.AutoSize = true;
            this.prescriptionAmount.Location = new System.Drawing.Point(82, 141);
            this.prescriptionAmount.Name = "prescriptionAmount";
            this.prescriptionAmount.Size = new System.Drawing.Size(43, 13);
            this.prescriptionAmount.TabIndex = 10;
            this.prescriptionAmount.Text = "Amount";
            // 
            // prescriptionDate
            // 
            this.prescriptionDate.AutoSize = true;
            this.prescriptionDate.Location = new System.Drawing.Point(245, 141);
            this.prescriptionDate.Name = "prescriptionDate";
            this.prescriptionDate.Size = new System.Drawing.Size(88, 13);
            this.prescriptionDate.TabIndex = 11;
            this.prescriptionDate.Text = "Prescription Date";
            // 
            // prescriptionDuration
            // 
            this.prescriptionDuration.AutoSize = true;
            this.prescriptionDuration.Location = new System.Drawing.Point(413, 141);
            this.prescriptionDuration.Name = "prescriptionDuration";
            this.prescriptionDuration.Size = new System.Drawing.Size(105, 13);
            this.prescriptionDuration.TabIndex = 12;
            this.prescriptionDuration.Text = "Prescription Duration";
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 269);
            this.Controls.Add(this.prescriptionDuration);
            this.Controls.Add(this.prescriptionDate);
            this.Controls.Add(this.prescriptionAmount);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.presctiptionId);
            this.Controls.Add(this.prescriptionName);
            this.Controls.Add(this.submitPrescription);
            this.Controls.Add(this.prescriptionDurationText);
            this.Controls.Add(this.prescriptionDateText);
            this.Controls.Add(this.prescriptionAmountText);
            this.Controls.Add(this.patientIdText);
            this.Controls.Add(this.prescriptionIdText);
            this.Controls.Add(this.prescriptionNameText);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prescriptionNameText;
        private System.Windows.Forms.TextBox prescriptionIdText;
        private System.Windows.Forms.TextBox patientIdText;
        private System.Windows.Forms.TextBox prescriptionAmountText;
        private System.Windows.Forms.TextBox prescriptionDateText;
        private System.Windows.Forms.TextBox prescriptionDurationText;
        private System.Windows.Forms.Button submitPrescription;
        private System.Windows.Forms.Label prescriptionName;
        private System.Windows.Forms.Label presctiptionId;
        private System.Windows.Forms.Label patientId;
        private System.Windows.Forms.Label prescriptionAmount;
        private System.Windows.Forms.Label prescriptionDate;
        private System.Windows.Forms.Label prescriptionDuration;
    }
}