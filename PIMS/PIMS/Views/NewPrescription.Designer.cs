namespace PIMS.Views
{
    partial class NewPrescription
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
            this.submitPrescriptions = new System.Windows.Forms.Button();
            this.patientId = new System.Windows.Forms.TextBox();
            this.prescriptionDuration = new System.Windows.Forms.TextBox();
            this.prescriptionName = new System.Windows.Forms.TextBox();
            this.prescriptionAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prescriptionDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submitPrescriptions
            // 
            this.submitPrescriptions.Location = new System.Drawing.Point(297, 159);
            this.submitPrescriptions.Name = "submitPrescriptions";
            this.submitPrescriptions.Size = new System.Drawing.Size(110, 50);
            this.submitPrescriptions.TabIndex = 0;
            this.submitPrescriptions.Text = "Submit";
            this.submitPrescriptions.UseVisualStyleBackColor = true;
            // 
            // patientId
            // 
            this.patientId.Location = new System.Drawing.Point(29, 60);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(200, 20);
            this.patientId.TabIndex = 1;
            // 
            // prescriptionDuration
            // 
            this.prescriptionDuration.Location = new System.Drawing.Point(29, 175);
            this.prescriptionDuration.Name = "prescriptionDuration";
            this.prescriptionDuration.Size = new System.Drawing.Size(200, 20);
            this.prescriptionDuration.TabIndex = 2;
            // 
            // prescriptionName
            // 
            this.prescriptionName.Location = new System.Drawing.Point(255, 60);
            this.prescriptionName.Name = "prescriptionName";
            this.prescriptionName.Size = new System.Drawing.Size(200, 20);
            this.prescriptionName.TabIndex = 3;
            // 
            // prescriptionAmount
            // 
            this.prescriptionAmount.Location = new System.Drawing.Point(29, 120);
            this.prescriptionAmount.Name = "prescriptionAmount";
            this.prescriptionAmount.Size = new System.Drawing.Size(200, 20);
            this.prescriptionAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prescription Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prescription Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duration";
            // 
            // prescriptionDate
            // 
            this.prescriptionDate.Location = new System.Drawing.Point(255, 120);
            this.prescriptionDate.Name = "prescriptionDate";
            this.prescriptionDate.Size = new System.Drawing.Size(200, 20);
            this.prescriptionDate.TabIndex = 10;
            // 
            // frmNewPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 232);
            this.Controls.Add(this.prescriptionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prescriptionAmount);
            this.Controls.Add(this.prescriptionName);
            this.Controls.Add(this.prescriptionDuration);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.submitPrescriptions);
            this.Name = "frmNewPrescriptions";
            this.Text = "frmNewPrescriptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitPrescriptions;
        private System.Windows.Forms.TextBox patientId;
        private System.Windows.Forms.TextBox prescriptionDuration;
        private System.Windows.Forms.TextBox prescriptionName;
        private System.Windows.Forms.TextBox prescriptionAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker prescriptionDate;
    }
}