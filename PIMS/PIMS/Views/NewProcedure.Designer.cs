namespace PIMS.Views
{
    partial class NewProcedure
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
            this.submitProcedure = new System.Windows.Forms.Button();
            this.patientId = new System.Windows.Forms.TextBox();
            this.procedureType = new System.Windows.Forms.TextBox();
            this.durationHours = new System.Windows.Forms.TextBox();
            this.procedureNotes = new System.Windows.Forms.TextBox();
            this.durationMinutes = new System.Windows.Forms.TextBox();
            this.doctorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.stopTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submitProcedure
            // 
            this.submitProcedure.Location = new System.Drawing.Point(215, 232);
            this.submitProcedure.Name = "submitProcedure";
            this.submitProcedure.Size = new System.Drawing.Size(99, 51);
            this.submitProcedure.TabIndex = 0;
            this.submitProcedure.Text = "Submit";
            this.submitProcedure.UseVisualStyleBackColor = true;
            // 
            // patientId
            // 
            this.patientId.Location = new System.Drawing.Point(28, 41);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(199, 20);
            this.patientId.TabIndex = 1;
            // 
            // procedureType
            // 
            this.procedureType.Location = new System.Drawing.Point(28, 119);
            this.procedureType.Name = "procedureType";
            this.procedureType.Size = new System.Drawing.Size(199, 20);
            this.procedureType.TabIndex = 2;
            // 
            // durationHours
            // 
            this.durationHours.Location = new System.Drawing.Point(28, 80);
            this.durationHours.Name = "durationHours";
            this.durationHours.Size = new System.Drawing.Size(199, 20);
            this.durationHours.TabIndex = 3;
            // 
            // procedureNotes
            // 
            this.procedureNotes.Location = new System.Drawing.Point(264, 119);
            this.procedureNotes.Multiline = true;
            this.procedureNotes.Name = "procedureNotes";
            this.procedureNotes.Size = new System.Drawing.Size(258, 98);
            this.procedureNotes.TabIndex = 4;
            // 
            // durationMinutes
            // 
            this.durationMinutes.Location = new System.Drawing.Point(264, 80);
            this.durationMinutes.Name = "durationMinutes";
            this.durationMinutes.Size = new System.Drawing.Size(200, 20);
            this.durationMinutes.TabIndex = 6;
            // 
            // doctorId
            // 
            this.doctorId.Location = new System.Drawing.Point(264, 41);
            this.doctorId.Name = "doctorId";
            this.doctorId.Size = new System.Drawing.Size(200, 20);
            this.doctorId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doctor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stop Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Duration (Hours)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Procedure Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Procedure Notes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Duration (Minutes)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(27, 158);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 19;
            // 
            // stopTime
            // 
            this.stopTime.Location = new System.Drawing.Point(27, 197);
            this.stopTime.Name = "stopTime";
            this.stopTime.Size = new System.Drawing.Size(200, 20);
            this.stopTime.TabIndex = 20;
            // 
            // frmNewProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 295);
            this.Controls.Add(this.stopTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorId);
            this.Controls.Add(this.durationMinutes);
            this.Controls.Add(this.procedureNotes);
            this.Controls.Add(this.durationHours);
            this.Controls.Add(this.procedureType);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.submitProcedure);
            this.Name = "frmNewProcedures";
            this.Text = "frmNewProcedures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitProcedure;
        private System.Windows.Forms.TextBox patientId;
        private System.Windows.Forms.TextBox procedureType;
        private System.Windows.Forms.TextBox durationHours;
        private System.Windows.Forms.TextBox procedureNotes;
        private System.Windows.Forms.TextBox durationMinutes;
        private System.Windows.Forms.TextBox doctorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker stopTime;
    }
}