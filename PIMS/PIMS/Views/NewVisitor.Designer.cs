namespace PIMS.Views
{
    partial class NewVisitor
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
            this.submitVisitors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.TextBox();
            this.visitorRelation = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastVisit = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submitVisitors
            // 
            this.submitVisitors.Location = new System.Drawing.Point(276, 117);
            this.submitVisitors.Name = "submitVisitors";
            this.submitVisitors.Size = new System.Drawing.Size(109, 36);
            this.submitVisitors.TabIndex = 0;
            this.submitVisitors.Text = "Submit";
            this.submitVisitors.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Visit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Relation";
            // 
            // patientId
            // 
            this.patientId.Location = new System.Drawing.Point(12, 34);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(200, 20);
            this.patientId.TabIndex = 6;
            // 
            // visitorRelation
            // 
            this.visitorRelation.Location = new System.Drawing.Point(276, 34);
            this.visitorRelation.Name = "visitorRelation";
            this.visitorRelation.Size = new System.Drawing.Size(200, 20);
            this.visitorRelation.TabIndex = 7;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(276, 82);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 20);
            this.lastName.TabIndex = 8;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 82);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 20);
            this.firstName.TabIndex = 9;
            // 
            // lastVisit
            // 
            this.lastVisit.Location = new System.Drawing.Point(12, 133);
            this.lastVisit.Name = "lastVisit";
            this.lastVisit.Size = new System.Drawing.Size(200, 20);
            this.lastVisit.TabIndex = 10;
            // 
            // NewVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 188);
            this.Controls.Add(this.lastVisit);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.visitorRelation);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitVisitors);
            this.Name = "NewVisitor";
            this.Text = "New Visitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitVisitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientId;
        private System.Windows.Forms.TextBox visitorRelation;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.DateTimePicker lastVisit;
    }
}