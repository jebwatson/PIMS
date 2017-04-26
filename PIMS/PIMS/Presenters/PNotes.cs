using DBI;
using DBI.Utilities;
using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PNotes
    {
        // Locals
        Views.Notes View;
        NotesTable MyNotesTable;

        public PNotes(Views.Notes view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the notes table for the first time after it is created.
        /// If there are no notes in the database, add a default case.
        /// </summary>
        public void PopulateNotesList()
        {
            MyNotesTable = new NotesTable();
            View.NotesList.SetObjects(MyNotesTable.ReadList());
        }

        /// <summary>
        /// Refresh the notes list.
        /// </summary>
        public void RefreshNotesList()
        {
            MyNotesTable = new NotesTable();
            View.NotesList.SetObjects(MyNotesTable.ReadList());
        }

        /// <summary>
        /// Open a new new patients form.
        /// </summary>
        public void AddNotes()
        {
            AddNote MyAddNoteView = new AddNote(((DBI.Notes)View.NotesList.Objects).patientId);
            if (MyAddNoteView.ShowDialog() == DialogResult.OK)
            {
                RefreshNotesList();
            }
        }

        /// <summary>
        /// Delete the selected patients from the database and refresh the list.
        /// </summary>
        public void RemoveNotes()
        {
            if (MessageBox.Show("Are you sure you want to delete the selected notes?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (View.NotesList.SelectedObjects != null)
                {
                    foreach (var item in View.NotesList.SelectedObjects)
                    {
                        MyNotesTable.ClearTableById(((DBI.Notes)item).patientId);
                    }
                }
                else
                {
                    MessageBox.Show("No notes available.");
                }

                RefreshNotesList();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of notes.
        /// </summary>
        public void SearchNotes()
        {
           
        }
    }
}
