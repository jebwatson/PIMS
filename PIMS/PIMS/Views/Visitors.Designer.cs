namespace PIMS.Views
{
    partial class Visitors
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
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.olvVisitorsList = new BrightIdeasSoftware.ObjectListView();
            this.patientid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PatientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NameLast = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NameFirst = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Relation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastVisit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.addVisitor = new System.Windows.Forms.Button();
            this.deleteVisitor = new System.Windows.Forms.Button();
            this.refreshVisitors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvVisitorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientSearch.Location = new System.Drawing.Point(125, 29);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(206, 20);
            this.txtPatientSearch.TabIndex = 5;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPatients.Location = new System.Drawing.Point(27, 26);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(94, 24);
            this.btnSearchPatients.TabIndex = 4;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // olvVisitorsList
            // 
            this.olvVisitorsList.AllColumns.Add(this.patientid);
            this.olvVisitorsList.AllColumns.Add(this.PatientName);
            this.olvVisitorsList.AllColumns.Add(this.NameLast);
            this.olvVisitorsList.AllColumns.Add(this.NameFirst);
            this.olvVisitorsList.AllColumns.Add(this.Relation);
            this.olvVisitorsList.AllColumns.Add(this.LastVisit);
            this.olvVisitorsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olvVisitorsList.CellEditUseWholeCell = false;
            this.olvVisitorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientid,
            this.PatientName,
            this.NameLast,
            this.NameFirst,
            this.Relation,
            this.LastVisit});
            this.olvVisitorsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvVisitorsList.FullRowSelect = true;
            this.olvVisitorsList.GridLines = true;
            this.olvVisitorsList.HideSelection = false;
            this.olvVisitorsList.Location = new System.Drawing.Point(27, 54);
            this.olvVisitorsList.Margin = new System.Windows.Forms.Padding(2);
            this.olvVisitorsList.Name = "olvVisitorsList";
            this.olvVisitorsList.ShowGroups = false;
            this.olvVisitorsList.Size = new System.Drawing.Size(679, 232);
            this.olvVisitorsList.TabIndex = 3;
            this.olvVisitorsList.UseCompatibleStateImageBehavior = false;
            this.olvVisitorsList.View = System.Windows.Forms.View.Details;
            // 
            // patientid
            // 
            this.patientid.AspectName = "patientId";
            this.patientid.Text = "Patient ID";
            this.patientid.Width = 120;
            // 
            // PatientName
            // 
            this.PatientName.AspectName = "patientName";
            this.PatientName.Text = "Name";
            // 
            // NameLast
            // 
            this.NameLast.AspectName = "nameLast";
            this.NameLast.Text = "Visitor Last Name";
            this.NameLast.Width = 230;
            // 
            // NameFirst
            // 
            this.NameFirst.AspectName = "nameFirst";
            this.NameFirst.Text = "Visitor First Name";
            this.NameFirst.Width = 213;
            // 
            // Relation
            // 
            this.Relation.AspectName = "relation";
            this.Relation.Text = "Relation";
            this.Relation.Width = 209;
            // 
            // LastVisit
            // 
            this.LastVisit.AspectName = "lastVisit";
            this.LastVisit.Text = "Last Visit";
            this.LastVisit.Width = 155;
            // 
            // addVisitor
            // 
            this.addVisitor.Location = new System.Drawing.Point(277, 296);
            this.addVisitor.Name = "addVisitor";
            this.addVisitor.Size = new System.Drawing.Size(78, 31);
            this.addVisitor.TabIndex = 6;
            this.addVisitor.Text = "Add Visitor";
            this.addVisitor.UseVisualStyleBackColor = true;
            // 
            // deleteVisitor
            // 
            this.deleteVisitor.Location = new System.Drawing.Point(380, 296);
            this.deleteVisitor.Name = "deleteVisitor";
            this.deleteVisitor.Size = new System.Drawing.Size(78, 31);
            this.deleteVisitor.TabIndex = 7;
            this.deleteVisitor.Text = "Delete Visitor";
            this.deleteVisitor.UseVisualStyleBackColor = true;
            // 
            // refreshVisitors
            // 
            this.refreshVisitors.Location = new System.Drawing.Point(171, 296);
            this.refreshVisitors.Name = "refreshVisitors";
            this.refreshVisitors.Size = new System.Drawing.Size(78, 31);
            this.refreshVisitors.TabIndex = 8;
            this.refreshVisitors.Text = "Refresh";
            this.refreshVisitors.UseVisualStyleBackColor = true;
            this.refreshVisitors.Click += new System.EventHandler(this.refreshVisitors_Click);
            // 
            // Visitors
            // 
            this.AcceptButton = this.btnSearchPatients;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 339);
            this.Controls.Add(this.refreshVisitors);
            this.Controls.Add(this.deleteVisitor);
            this.Controls.Add(this.addVisitor);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.olvVisitorsList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Visitors";
            this.Text = "Visitors";
            ((System.ComponentModel.ISupportInitialize)(this.olvVisitorsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.Button btnSearchPatients;
        private BrightIdeasSoftware.ObjectListView olvVisitorsList;
        private BrightIdeasSoftware.OLVColumn patientid;
        private BrightIdeasSoftware.OLVColumn NameLast;
        private BrightIdeasSoftware.OLVColumn NameFirst;
        private BrightIdeasSoftware.OLVColumn Relation;
        private BrightIdeasSoftware.OLVColumn LastVisit;
        private BrightIdeasSoftware.OLVColumn PatientName;
        private System.Windows.Forms.Button addVisitor;
        private System.Windows.Forms.Button deleteVisitor;
        private System.Windows.Forms.Button refreshVisitors;
    }
}