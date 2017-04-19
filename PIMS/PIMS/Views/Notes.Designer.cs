﻿namespace PIMS.Views
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
            this.editNote = new System.Windows.Forms.Button();
            this.searchNotesBox = new System.Windows.Forms.TextBox();
            this.olvNotesList = new BrightIdeasSoftware.ObjectListView();
            this.note = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.UserId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.patientId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.refreshNotes = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.removeNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotesList)).BeginInit();
            this.SuspendLayout();
            // 
            // searchNote
            // 
            this.searchNote.Location = new System.Drawing.Point(168, 15);
            this.searchNote.Margin = new System.Windows.Forms.Padding(4);
            this.searchNote.Name = "searchNote";
            this.searchNote.Size = new System.Drawing.Size(121, 26);
            this.searchNote.TabIndex = 2;
            this.searchNote.Text = "Search";
            this.searchNote.UseVisualStyleBackColor = true;
            // 
            // editNote
            // 
            this.editNote.Location = new System.Drawing.Point(427, 462);
            this.editNote.Margin = new System.Windows.Forms.Padding(4);
            this.editNote.Name = "editNote";
            this.editNote.Size = new System.Drawing.Size(121, 66);
            this.editNote.TabIndex = 5;
            this.editNote.Text = "Edit Note";
            this.editNote.UseVisualStyleBackColor = true;
            this.editNote.Click += new System.EventHandler(this.editNote_Click);
            // 
            // searchNotesBox
            // 
            this.searchNotesBox.Location = new System.Drawing.Point(297, 16);
            this.searchNotesBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchNotesBox.Name = "searchNotesBox";
            this.searchNotesBox.Size = new System.Drawing.Size(503, 22);
            this.searchNotesBox.TabIndex = 7;
            // 
            // olvNotesList
            // 
            this.olvNotesList.AllColumns.Add(this.patientId);
            this.olvNotesList.AllColumns.Add(this.note);
            this.olvNotesList.AllColumns.Add(this.UserId);
            this.olvNotesList.CellEditUseWholeCell = false;
            this.olvNotesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientId,
            this.note,
            this.UserId});
            this.olvNotesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNotesList.FullRowSelect = true;
            this.olvNotesList.GridLines = true;
            this.olvNotesList.Location = new System.Drawing.Point(47, 58);
            this.olvNotesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olvNotesList.Name = "olvNotesList";
            this.olvNotesList.ShowGroups = false;
            this.olvNotesList.Size = new System.Drawing.Size(784, 397);
            this.olvNotesList.TabIndex = 1;
            this.olvNotesList.UseCompatibleStateImageBehavior = false;
            this.olvNotesList.View = System.Windows.Forms.View.Details;
            // 
            // note
            // 
            this.note.AspectName = "notes";
            this.note.Text = "Note";
            this.note.Width = 358;
            // 
            // UserId
            // 
            this.UserId.AspectName = "userId";
            this.UserId.Text = "User ID";
            // 
            // patientId
            // 
            this.patientId.AspectName = "patientId";
            this.patientId.Text = "Patient ID";
            this.patientId.Width = 75;
            // 
            // refreshNotes
            // 
            this.refreshNotes.Location = new System.Drawing.Point(168, 462);
            this.refreshNotes.Margin = new System.Windows.Forms.Padding(4);
            this.refreshNotes.Name = "refreshNotes";
            this.refreshNotes.Size = new System.Drawing.Size(121, 66);
            this.refreshNotes.TabIndex = 3;
            this.refreshNotes.Text = "Refresh";
            this.refreshNotes.UseVisualStyleBackColor = true;
            this.refreshNotes.Click += new System.EventHandler(this.refreshNotes_Click);
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(297, 462);
            this.addNote.Margin = new System.Windows.Forms.Padding(4);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(121, 66);
            this.addNote.TabIndex = 4;
            this.addNote.Text = "Add Note";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // removeNote
            // 
            this.removeNote.Location = new System.Drawing.Point(556, 462);
            this.removeNote.Margin = new System.Windows.Forms.Padding(4);
            this.removeNote.Name = "removeNote";
            this.removeNote.Size = new System.Drawing.Size(121, 66);
            this.removeNote.TabIndex = 6;
            this.removeNote.Text = "Remove Note";
            this.removeNote.UseVisualStyleBackColor = true;
            this.removeNote.Click += new System.EventHandler(this.removeNote_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 543);
            this.Controls.Add(this.searchNotesBox);
            this.Controls.Add(this.removeNote);
            this.Controls.Add(this.editNote);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.refreshNotes);
            this.Controls.Add(this.searchNote);
            this.Controls.Add(this.olvNotesList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notes";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.olvNotesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvNotesList;
        private BrightIdeasSoftware.OLVColumn note;
        private BrightIdeasSoftware.OLVColumn patientId;
        private System.Windows.Forms.Button searchNote;
        private System.Windows.Forms.Button editNote;
        private System.Windows.Forms.TextBox searchNotesBox;
        private BrightIdeasSoftware.OLVColumn UserId;
        private System.Windows.Forms.Button refreshNotes;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button removeNote;
    }
}