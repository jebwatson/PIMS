namespace PIMS.Views
{
    partial class Prescriptions
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
            this.txtProceduresSearch = new System.Windows.Forms.TextBox();
            this.btnSearchProcedures = new System.Windows.Forms.Button();
            this.olvProceduresList = new BrightIdeasSoftware.ObjectListView();
            this.PrescriptionID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PrescriptionDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Duration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvProceduresList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProceduresSearch
            // 
            this.txtProceduresSearch.Location = new System.Drawing.Point(381, 52);
            this.txtProceduresSearch.Name = "txtProceduresSearch";
            this.txtProceduresSearch.Size = new System.Drawing.Size(341, 22);
            this.txtProceduresSearch.TabIndex = 8;
            // 
            // btnSearchProcedures
            // 
            this.btnSearchProcedures.Location = new System.Drawing.Point(250, 49);
            this.btnSearchProcedures.Name = "btnSearchProcedures";
            this.btnSearchProcedures.Size = new System.Drawing.Size(125, 29);
            this.btnSearchProcedures.TabIndex = 7;
            this.btnSearchProcedures.Text = "Search";
            this.btnSearchProcedures.UseVisualStyleBackColor = true;
            // 
            // olvProceduresList
            // 
            this.olvProceduresList.AllColumns.Add(this.PrescriptionID);
            this.olvProceduresList.AllColumns.Add(this.PrescriptionName);
            this.olvProceduresList.AllColumns.Add(this.PrescriptionDate);
            this.olvProceduresList.AllColumns.Add(this.Duration);
            this.olvProceduresList.CellEditUseWholeCell = false;
            this.olvProceduresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PrescriptionID,
            this.PrescriptionName,
            this.PrescriptionDate,
            this.Duration});
            this.olvProceduresList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvProceduresList.GridLines = true;
            this.olvProceduresList.Location = new System.Drawing.Point(112, 88);
            this.olvProceduresList.Name = "olvProceduresList";
            this.olvProceduresList.Size = new System.Drawing.Size(805, 279);
            this.olvProceduresList.TabIndex = 6;
            this.olvProceduresList.UseCompatibleStateImageBehavior = false;
            this.olvProceduresList.View = System.Windows.Forms.View.Details;
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.AspectName = "prescID";
            this.PrescriptionID.Text = "Prescription ID";
            this.PrescriptionID.Width = 155;
            // 
            // PrescriptionName
            // 
            this.PrescriptionName.AspectName = "prescName";
            this.PrescriptionName.Text = "Prescription Name";
            this.PrescriptionName.Width = 155;
            // 
            // PrescriptionDate
            // 
            this.PrescriptionDate.AspectName = "prescDate";
            this.PrescriptionDate.Text = "Date Prescribed";
            this.PrescriptionDate.Width = 155;
            // 
            // Duration
            // 
            this.Duration.AspectName = "duration";
            this.Duration.Text = "Duration";
            this.Duration.Width = 155;
            // 
            // Perscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.txtProceduresSearch);
            this.Controls.Add(this.btnSearchProcedures);
            this.Controls.Add(this.olvProceduresList);
            this.Name = "Perscriptions";
            this.Text = "Perscriptions";
            ((System.ComponentModel.ISupportInitialize)(this.olvProceduresList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProceduresSearch;
        private System.Windows.Forms.Button btnSearchProcedures;
        private BrightIdeasSoftware.ObjectListView olvProceduresList;
        private BrightIdeasSoftware.OLVColumn PrescriptionID;
        private BrightIdeasSoftware.OLVColumn PrescriptionName;
        private BrightIdeasSoftware.OLVColumn PrescriptionDate;
        private BrightIdeasSoftware.OLVColumn Duration;
    }
}