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
        PatientTable MyPatientsTable;

        public PNotes(Views.Notes view)
        {
            View = view;
        }

        public void RefreshPatientsList()
        {
            MyPatientsTable = new PatientTable();
            View.PatientsList.SetObjects(MyPatientsTable.ReadList());
        }

        public void RefreshPatientsList(string patientName)
        {
            MyPatientsTable = new PatientTable();
            View.PatientsList.SetObjects(MyPatientsTable.ReadListByName(patientName));
        }

        /// <summary>
        /// Refresh the notes list.
        /// </summary>
        public void RefreshNotesList()
        {
            MyNotesTable = new NotesTable();

            if (View.PatientsList.SelectedObject != null)
            {
                View.NotesList.SetObjects(MyNotesTable.ReadListByPatientId(((Patient)(View.PatientsList.SelectedObject)).patientId));
            }
        }

        /// <summary>
        /// Open a new new patients form.
        /// </summary>
        public void AddNotes()
        {
            NewNote MyNewNotesView = new NewNote();
            if (MyNewNotesView.ShowDialog() == DialogResult.OK)
            {
                RefreshNotesList();
                MessageBox.Show("Note saved successfully.");
            }
        }

        /// <summary>
        /// Delete the selected patients from the database and refresh the list.
        /// </summary>
        public void RemoveNotes()
        {
            try
            {
                if (View.NotesList.SelectedObjects != null)
                {
                    List<DBI.Notes> ItemsForDeletion = new List<DBI.Notes>();
                    foreach (var item in View.NotesList.SelectedObjects)
                    {
                        ItemsForDeletion.Add((DBI.Notes)item);
                    }

                    if (MessageBox.Show("Are you sure you want to delete the selected notes?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        foreach (var item in ItemsForDeletion)
                        {
                            MyNotesTable.ClearTableById(item.noteId);
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
            catch (Exception)
            {
                MessageBox.Show("Unexpected error - reverting to last valid state.");
            }
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of notes.
        /// </summary>
        public void SearchNotes()
        {
            if (View.SearchText.Length > 0 && View.SearchText != "Patient Name")
            {
                PatientTable MyPatientTable = new PatientTable();
                RefreshPatientsList(View.SearchText);
            }
            else
            {
                MessageBox.Show("Please enter a patient name or partial patient name.");
            }
        }

        public void ToggleSearch()
        {
            if (View.SearchText.Length > 0)
            {
                View.SearchEnabled = true;
            }
            else
            {
                View.SearchEnabled = false;
            }
        }

        /// <summary>
        /// Open a new window for editing the notes and then refresh the notes list when the window closes.
        /// </summary>
        public void EditNotes()
        {
            try
            {
                if (DetermineEditAccess())
                {
                    NewNote EditNotes = new NewNote((DBI.Notes)View.NotesList.SelectedObject);

                    if (EditNotes.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Notes saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Problem saving notes. Notes were not saved.");
                    }
                }
                else
                {
                    MessageBox.Show("You do not have sufficient access privileges to edit this note.");
                }

                RefreshNotesList();
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error - Reverting to last valid state.");
            }
        }

        /// <summary>
        /// Determine whether or not the current user can edit a note.
        /// </summary>
        /// <returns></returns>
        private bool DetermineEditAccess()
        {
            bool CanEdit = false;

            NotesTable MyNotesTable = new NotesTable();
            DBI.Notes MyNote;

            if (View.NotesList.SelectedObject != null)
            {
                MyNotesTable.ReadListById(((DBI.Notes)View.NotesList.SelectedObject).noteId);

                if (MyNotesTable.ItemList.Count > 0)
                {
                    MyNote = MyNotesTable.ItemList[0];

                    UsersTable MyUserTable = new UsersTable();
                    List<Users> MyUsers = MyUserTable.ReadListById(MyNote.userId);
                    List<Users> MyCurrentUser = MyUserTable.ReadListById(Settings.User.Default.UserId);

                    if (MyUsers.Count > 0 && MyCurrentUser.Count > 0)
                    {
                        if (MyCurrentUser[0].accessLevel >= MyUsers[0].accessLevel)
                        {
                            CanEdit = true;
                        }
                    }
                }
            }

            return CanEdit;
        }

        public void RefreshForm()
        {
            if (View.NotesList.SelectedObjects == null)
            {
                // toggle the buttons
                View.EditEnabled = false;
                View.DeleteEnabled = false;
            }
            else
            {
                View.EditEnabled = true;
                View.DeleteEnabled = true;
            }
        }
    }
}
