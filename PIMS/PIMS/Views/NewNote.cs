using DBI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Views
{
    public partial class NewNote : Form
    {
        DBI.Notes CurrentNote;
        int patientId = -1;

        public NewNote()
        {
            InitializeComponent();
        }

        public NewNote(DBI.Notes selectedNote)
        {
            InitializeComponent();
            CurrentNote = selectedNote;
            inputNote.Text = selectedNote.notes;
        }

        private void submitNote_Click(object sender, EventArgs e)
        {
            // Save the notes.
            if (CurrentNote != null)
            {
                // Update a note
                CurrentNote.notes = inputNote.Text;
                DBI.NotesTable MyNotesTable = new DBI.NotesTable();
                MyNotesTable.UpdateItem(CurrentNote);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Create a new note
                DBI.Notes MyNote = new DBI.Notes();

                if (inputNote.Text != string.Empty)
                {
                    MyNote.notes = inputNote.Text;
                    MyNote.doctor = Settings.User.Default.Doctor;
                    MyNote.nurse = Settings.User.Default.Nurse;
                    MyNote.userId = Settings.User.Default.UserId;

                    
                    if (inputPatientId.Text != string.Empty)
                    {
                        patientId = Convert.ToInt32(inputPatientId.Text);
                        PatientTable MyPatientTable = new PatientTable();

                        if (MyPatientTable.ReadListById(patientId).Count > 0)
                        {
                            MyNote.patientId = Convert.ToInt32(inputPatientId.Text);
                            NotesTable MyNotesTable = new NotesTable();
                            MyNotesTable.WriteItem(MyNote);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid patient id to proceed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid patient id to proceed.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a note to proceed.");
                }
            }
        }

        private void inputPatientId_TextChanged(object sender, EventArgs e)
        {
            // do the search here
        }
    }
}
