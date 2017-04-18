namespace PIMS.Views
{
    partial class Procedures
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
            this.ProcedureID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProcedureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DurationHrs = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DurationMins = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StartTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StopTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvProceduresList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProceduresSearch
            // 
            this.txtProceduresSearch.Location = new System.Drawing.Point(426, 82);
            this.txtProceduresSearch.Name = "txtProceduresSearch";
            this.txtProceduresSearch.Size = new System.Drawing.Size(341, 22);
            this.txtProceduresSearch.TabIndex = 5;
            // 
            // btnSearchProcedures
            // 
            this.btnSearchProcedures.Location = new System.Drawing.Point(279, 79);
            this.btnSearchProcedures.Name = "btnSearchProcedures";
            this.btnSearchProcedures.Size = new System.Drawing.Size(125, 29);
            this.btnSearchProcedures.TabIndex = 4;
            this.btnSearchProcedures.Text = "Search";
            this.btnSearchProcedures.UseVisualStyleBackColor = true;
            // 
            // olvProceduresList
            // 
            this.olvProceduresList.AllColumns.Add(this.ProcedureID);
            this.olvProceduresList.AllColumns.Add(this.ProcedureType);
            this.olvProceduresList.AllColumns.Add(this.DurationHrs);
            this.olvProceduresList.AllColumns.Add(this.DurationMins);
            this.olvProceduresList.AllColumns.Add(this.StartTime);
            this.olvProceduresList.AllColumns.Add(this.StopTime);
            this.olvProceduresList.CellEditUseWholeCell = false;
            this.olvProceduresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcedureID,
            this.ProcedureType,
            this.DurationHrs,
            this.DurationMins,
            this.StartTime,
            this.StopTime});
            this.olvProceduresList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvProceduresList.GridLines = true;
            this.olvProceduresList.Location = new System.Drawing.Point(60, 118);
            this.olvProceduresList.Name = "olvProceduresList";
            this.olvProceduresList.Size = new System.Drawing.Size(934, 279);
            this.olvProceduresList.TabIndex = 3;
            this.olvProceduresList.UseCompatibleStateImageBehavior = false;
            this.olvProceduresList.View = System.Windows.Forms.View.Details;
            // 
            // ProcedureID
            // 
            this.ProcedureID.AspectName = "procId";
            this.ProcedureID.Text = "Procedure ID";
            this.ProcedureID.Width = 155;
            // 
            // ProcedureType
            // 
            this.ProcedureType.AspectName = "procType";
            this.ProcedureType.Text = "Procedure Type";
            this.ProcedureType.Width = 155;
            // 
            // DurationHrs
            // 
            this.DurationHrs.AspectName = "durationHrs";
            this.DurationHrs.Text = "Durations(Hours)";
            this.DurationHrs.Width = 155;
            // 
            // DurationMins
            // 
            this.DurationMins.AspectName = "durationMins";
            this.DurationMins.Text = "DurationMins";
            this.DurationMins.Width = 155;
            // 
            // StartTime
            // 
            this.StartTime.AspectName = "startTime";
            this.StartTime.Text = "Start Time";
            this.StartTime.Width = 155;
            // 
            // StopTime
            // 
            this.StopTime.AspectName = "stopTime";
            this.StopTime.Text = "Stop Time";
            this.StopTime.Width = 155;
            // 
            // Procedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 497);
            this.Controls.Add(this.txtProceduresSearch);
            this.Controls.Add(this.btnSearchProcedures);
            this.Controls.Add(this.olvProceduresList);
            this.Name = "Procedures";
            this.Text = "Procedures";
            ((System.ComponentModel.ISupportInitialize)(this.olvProceduresList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProceduresSearch;
        private System.Windows.Forms.Button btnSearchProcedures;
        private BrightIdeasSoftware.ObjectListView olvProceduresList;
        private BrightIdeasSoftware.OLVColumn ProcedureID;
        private BrightIdeasSoftware.OLVColumn ProcedureType;
        private BrightIdeasSoftware.OLVColumn DurationHrs;
        private BrightIdeasSoftware.OLVColumn DurationMins;
        private BrightIdeasSoftware.OLVColumn StartTime;
        private BrightIdeasSoftware.OLVColumn StopTime;
    }
}