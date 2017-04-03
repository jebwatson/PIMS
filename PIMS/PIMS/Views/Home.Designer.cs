namespace PIMS.Views
{
    partial class Home
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
            ((System.ComponentModel.ISupportInitialize)(this.imgPims)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPims
            // 
            this.imgPims.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPims.Image = global::PIMS.Properties.Resources.Redcrossnew1;
            this.imgPims.Location = new System.Drawing.Point(12, 12);
            this.imgPims.Name = "imgPims";
            this.imgPims.Size = new System.Drawing.Size(122, 122);
            this.imgPims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPims.TabIndex = 1;
            this.imgPims.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 570);
            this.Controls.Add(this.imgPims);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.imgPims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPims;
    }
}