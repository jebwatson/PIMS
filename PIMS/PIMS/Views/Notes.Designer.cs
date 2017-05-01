namespace PIMS.Views
{
    partial class Notes
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
            this.searchNote = new System.Windows.Forms.Button();
            this.searchNotesBox = new System.Windows.Forms.TextBox();
            this.olvNotesList = new BrightIdeasSoftware.ObjectListView();
            this.patientId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PatientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.note = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.refreshNotes = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.removeNote = new System.Windows.Forms.Button();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.olvPatientsList = new BrightIdeasSoftware.ObjectListView();
            this.Id = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NotesCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvNotesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvPatientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchNote
            // 
            this.searchNote.Location = new System.Drawing.Point(126, 12);
            this.searchNote.Name = "searchNote";
            this.searchNote.Size = new System.Drawing.Size(91, 21);
            this.searchNote.TabIndex = 2;
            this.searchNote.Text = "Search";
            this.searchNote.UseVisualStyleBackColor = true;
            this.searchNote.Click += new System.EventHandler(this.searchNote_Click);
            // 
            // searchNotesBox
            // 
            this.searchNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNotesBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchNotesBox.Location = new System.Drawing.Point(223, 13);
            this.searchNotesBox.Name = "searchNotesBox";
            this.searchNotesBox.Size = new System.Drawing.Size(378, 20);
            this.searchNotesBox.TabIndex = 7;
            this.searchNotesBox.Text = "Patient Name";
            this.searchNotesBox.Click += new System.EventHandler(this.searchNotesBox_Click);
            this.searchNotesBox.TextChanged += new System.EventHandler(this.searchNotesBox_TextChanged);
            // 
            // olvNotesList
            // 
            this.olvNotesList.AllColumns.Add(this.patientId);
            this.olvNotesList.AllColumns.Add(this.PatientName);
            this.olvNotesList.AllColumns.Add(this.note);
            this.olvNotesList.CellEditUseWholeCell = false;
            this.olvNotesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientId,
            this.PatientName,
            this.note});
            this.olvNotesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNotesList.FullRowSelect = true;
            this.olvNotesList.GridLines = true;
            this.olvNotesList.Location = new System.Drawing.Point(35, 188);
            this.olvNotesList.Name = "olvNotesList";
            this.olvNotesList.ShowGroups = false;
            this.olvNotesList.Size = new System.Drawing.Size(566, 181);
            this.olvNotesList.TabIndex = 1;
            this.olvNotesList.UseCompatibleStateImageBehavior = false;
            this.olvNotesList.View = System.Windows.Forms.View.Details;
            this.olvNotesList.SelectedIndexChanged += new System.EventHandler(this.olvNotesList_SelectedIndexChanged);
            // 
            // patientId
            // 
            this.patientId.AspectName = "patientId";
            this.patientId.Text = "Patient ID";
            this.patientId.Width = 63;
            // 
            // PatientName
            // 
            this.PatientName.AspectName = "name";
            this.PatientName.Text = "Name";
            this.PatientName.Width = 90;
            // 
            // note
            // 
            this.note.AspectName = "notes";
            this.note.Text = "Note";
            this.note.Width = 406;
            // 
            // refreshNotes
            // 
            this.refreshNotes.Location = new System.Drawing.Point(91, 375);
            this.refreshNotes.Name = "refreshNotes";
            this.refreshNotes.Size = new System.Drawing.Size(91, 54);
            this.refreshNotes.TabIndex = 3;
            this.refreshNotes.Text = "Refresh";
            this.refreshNotes.UseVisualStyleBackColor = true;
            this.refreshNotes.Click += new System.EventHandler(this.refreshNotes_Click);
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(188, 375);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(91, 54);
            this.addNote.TabIndex = 4;
            this.addNote.Text = "Add Note";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // removeNote
            // 
            this.removeNote.Enabled = false;
            this.removeNote.Location = new System.Drawing.Point(393, 375);
            this.removeNote.Name = "removeNote";
            this.removeNote.Size = new System.Drawing.Size(91, 54);
            this.removeNote.TabIndex = 6;
            this.removeNote.Text = "Remove Note";
            this.removeNote.UseVisualStyleBackColor = true;
            this.removeNote.Click += new System.EventHandler(this.removeNote_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Enabled = false;
            this.btnEditNote.Location = new System.Drawing.Point(285, 375);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(102, 54);
            this.btnEditNote.TabIndex = 8;
            this.btnEditNote.Text = "Edit Note";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // olvPatientsList
            // 
            this.olvPatientsList.AllColumns.Add(this.Id);
            this.olvPatientsList.AllColumns.Add(this.FirstName);
            this.olvPatientsList.AllColumns.Add(this.LastName);
            this.olvPatientsList.AllColumns.Add(this.NotesCount);
            this.olvPatientsList.CellEditUseWholeCell = false;
            this.olvPatientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.NotesCount});
            this.olvPatientsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPatientsList.FullRowSelect = true;
            this.olvPatientsList.GridLines = true;
            this.olvPatientsList.Location = new System.Drawing.Point(35, 39);
            this.olvPatientsList.MultiSelect = false;
            this.olvPatientsList.Name = "olvPatientsList";
            this.olvPatientsList.ShowGroups = false;
            this.olvPatientsList.Size = new System.Drawing.Size(566, 143);
            this.olvPatientsList.TabIndex = 9;
            this.olvPatientsList.UseCompatibleStateImageBehavior = false;
            this.olvPatientsList.View = System.Windows.Forms.View.Details;
            this.olvPatientsList.SelectedIndexChanged += new System.EventHandler(this.olvPatientsList_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.AspectName = "patientId";
            this.Id.Text = "Patient Id";
            this.Id.Width = 63;
            // 
            // FirstName
            // 
            this.FirstName.AspectName = "nameFirst";
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 123;
            // 
            // LastName
            // 
            this.LastName.AspectName = "nameLast";
            this.LastName.Text = "Last Name";
            this.LastName.Width = 202;
            // 
            // NotesCount
            // 
            this.NotesCount.AspectName = "NotesCount";
            this.NotesCount.FillsFreeSpace = true;
            this.NotesCount.Text = "Number of Notes";
            this.NotesCount.Width = 174;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.olvPatientsList);
            this.Controls.Add(this.btnEditNote);
            this.Controls.Add(this.searchNotesBox);
            this.Controls.Add(this.removeNote);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.refreshNotes);
            this.Controls.Add(this.searchNote);
            this.Controls.Add(this.olvNotesList);
            this.Name = "Notes";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.olvNotesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvPatientsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvNotesList;
        private BrightIdeasSoftware.OLVColumn note;
        private BrightIdeasSoftware.OLVColumn patientId;
        private System.Windows.Forms.Button searchNote;
        private System.Windows.Forms.TextBox searchNotesBox;
        private System.Windows.Forms.Button refreshNotes;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button removeNote;
        private BrightIdeasSoftware.OLVColumn PatientName;
        private System.Windows.Forms.Button btnEditNote;
        private BrightIdeasSoftware.ObjectListView olvPatientsList;
        private BrightIdeasSoftware.OLVColumn Id;
        private BrightIdeasSoftware.OLVColumn FirstName;
        private BrightIdeasSoftware.OLVColumn LastName;
        private BrightIdeasSoftware.OLVColumn NotesCount;
    }
}