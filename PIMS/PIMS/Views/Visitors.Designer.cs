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
            this.NameLast = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NameFirst = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Relation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastVisit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvVisitorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(1098, 158);
            this.txtPatientSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(341, 35);
            this.txtPatientSearch.TabIndex = 5;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(869, 148);
            this.btnSearchPatients.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(219, 54);
            this.btnSearchPatients.TabIndex = 4;
            this.btnSearchPatients.Text = "Search";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // olvVisitorsList
            // 
            this.olvVisitorsList.AllColumns.Add(this.patientid);
            this.olvVisitorsList.AllColumns.Add(this.NameLast);
            this.olvVisitorsList.AllColumns.Add(this.NameFirst);
            this.olvVisitorsList.AllColumns.Add(this.Relation);
            this.olvVisitorsList.AllColumns.Add(this.LastVisit);
            this.olvVisitorsList.CellEditUseWholeCell = false;
            this.olvVisitorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientid,
            this.NameLast,
            this.NameFirst,
            this.Relation,
            this.LastVisit});
            this.olvVisitorsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvVisitorsList.GridLines = true;
            this.olvVisitorsList.Location = new System.Drawing.Point(105, 218);
            this.olvVisitorsList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.olvVisitorsList.Name = "olvVisitorsList";
            this.olvVisitorsList.ShowGroups = false;
            this.olvVisitorsList.Size = new System.Drawing.Size(1334, 501);
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
            // Visitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 975);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.olvVisitorsList);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
    }
}