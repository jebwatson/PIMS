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
            this.olvNotesList = new BrightIdeasSoftware.ObjectListView();
            this.noteId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.note = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.doctorId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.patientId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.searchNote = new System.Windows.Forms.Button();
            this.refreshNotes = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.editNote = new System.Windows.Forms.Button();
            this.removeNote = new System.Windows.Forms.Button();
            this.searchNotesBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotesList)).BeginInit();
            this.SuspendLayout();
            // 
            // olvNotesList
            // 
            this.olvNotesList.AllColumns.Add(this.noteId);
            this.olvNotesList.AllColumns.Add(this.note);
            this.olvNotesList.AllColumns.Add(this.doctorId);
            this.olvNotesList.AllColumns.Add(this.patientId);
            this.olvNotesList.CellEditUseWholeCell = false;
            this.olvNotesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.noteId,
            this.note,
            this.doctorId,
            this.patientId});
            this.olvNotesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNotesList.GridLines = true;
            this.olvNotesList.Location = new System.Drawing.Point(35, 47);
            this.olvNotesList.Margin = new System.Windows.Forms.Padding(2);
            this.olvNotesList.Name = "olvNotesList";
            this.olvNotesList.ShowGroups = false;
            this.olvNotesList.Size = new System.Drawing.Size(566, 323);
            this.olvNotesList.TabIndex = 1;
            this.olvNotesList.UseCompatibleStateImageBehavior = false;
            this.olvNotesList.View = System.Windows.Forms.View.Details;
            // 
            // noteId
            // 
            this.noteId.AspectName = "noteId";
            this.noteId.Text = "Note ID";
            this.noteId.Width = 65;
            // 
            // note
            // 
            this.note.AspectName = "note";
            this.note.Text = "Note";
            this.note.Width = 358;
            // 
            // doctorId
            // 
            this.doctorId.AspectName = "doctorId";
            this.doctorId.Text = "Doctor ID";
            this.doctorId.Width = 76;
            // 
            // patientId
            // 
            this.patientId.AspectName = "patientId";
            this.patientId.Text = "Patient ID";
            this.patientId.Width = 66;
            // 
            // searchNote
            // 
            this.searchNote.Location = new System.Drawing.Point(126, 12);
            this.searchNote.Name = "searchNote";
            this.searchNote.Size = new System.Drawing.Size(91, 21);
            this.searchNote.TabIndex = 2;
            this.searchNote.Text = "Search";
            this.searchNote.UseVisualStyleBackColor = true;
            // 
            // refreshNotes
            // 
            this.refreshNotes.Location = new System.Drawing.Point(126, 375);
            this.refreshNotes.Name = "refreshNotes";
            this.refreshNotes.Size = new System.Drawing.Size(91, 54);
            this.refreshNotes.TabIndex = 3;
            this.refreshNotes.Text = "Refresh";
            this.refreshNotes.UseVisualStyleBackColor = true;
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(223, 375);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(91, 54);
            this.addNote.TabIndex = 4;
            this.addNote.Text = "Add Note";
            this.addNote.UseVisualStyleBackColor = true;
            // 
            // editNote
            // 
            this.editNote.Location = new System.Drawing.Point(320, 375);
            this.editNote.Name = "editNote";
            this.editNote.Size = new System.Drawing.Size(91, 54);
            this.editNote.TabIndex = 5;
            this.editNote.Text = "Edit Note";
            this.editNote.UseVisualStyleBackColor = true;
            // 
            // removeNote
            // 
            this.removeNote.Location = new System.Drawing.Point(417, 375);
            this.removeNote.Name = "removeNote";
            this.removeNote.Size = new System.Drawing.Size(91, 54);
            this.removeNote.TabIndex = 6;
            this.removeNote.Text = "Remove Note";
            this.removeNote.UseVisualStyleBackColor = true;
            // 
            // searchNotesBox
            // 
            this.searchNotesBox.Location = new System.Drawing.Point(223, 13);
            this.searchNotesBox.Name = "searchNotesBox";
            this.searchNotesBox.Size = new System.Drawing.Size(378, 20);
            this.searchNotesBox.TabIndex = 7;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 441);
            this.Controls.Add(this.searchNotesBox);
            this.Controls.Add(this.removeNote);
            this.Controls.Add(this.editNote);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.refreshNotes);
            this.Controls.Add(this.searchNote);
            this.Controls.Add(this.olvNotesList);
            this.Name = "Notes";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.olvNotesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvNotesList;
        private BrightIdeasSoftware.OLVColumn noteId;
        private BrightIdeasSoftware.OLVColumn note;
        private BrightIdeasSoftware.OLVColumn doctorId;
        private BrightIdeasSoftware.OLVColumn patientId;
        private System.Windows.Forms.Button searchNote;
        private System.Windows.Forms.Button refreshNotes;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button editNote;
        private System.Windows.Forms.Button removeNote;
        private System.Windows.Forms.TextBox searchNotesBox;
    }
}