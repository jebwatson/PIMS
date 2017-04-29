namespace PIMS.Views
{
    partial class frmNewNotes
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
            this.inputNote = new System.Windows.Forms.TextBox();
            this.inputPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNote
            // 
            this.inputNote.Location = new System.Drawing.Point(135, 61);
            this.inputNote.Multiline = true;
            this.inputNote.Name = "inputNote";
            this.inputNote.Size = new System.Drawing.Size(299, 162);
            this.inputNote.TabIndex = 0;
            // 
            // inputPatientId
            // 
            this.inputPatientId.Location = new System.Drawing.Point(12, 121);
            this.inputPatientId.Name = "inputPatientId";
            this.inputPatientId.Size = new System.Drawing.Size(100, 20);
            this.inputPatientId.TabIndex = 1;
            this.inputPatientId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient ID";
            // 
            // submitNote
            // 
            this.submitNote.Location = new System.Drawing.Point(172, 241);
            this.submitNote.Name = "submitNote";
            this.submitNote.Size = new System.Drawing.Size(104, 50);
            this.submitNote.TabIndex = 4;
            this.submitNote.Text = "Submit";
            this.submitNote.UseVisualStyleBackColor = true;
            // 
            // frmNewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 303);
            this.Controls.Add(this.submitNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPatientId);
            this.Controls.Add(this.inputNote);
            this.Name = "frmNewNotes";
            this.Text = "frmNewNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNote;
        private System.Windows.Forms.TextBox inputPatientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitNote;
    }
}