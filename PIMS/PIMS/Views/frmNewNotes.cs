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
    public partial class frmNewNotes : Form
    {
        DBI.Notes CurrentNote;

        public frmNewNotes()
        {
            InitializeComponent();
        }

        public frmNewNotes(DBI.Notes selectedNote)
        {
            InitializeComponent();
            CurrentNote = selectedNote;
            inputNote.Text = selectedNote.notes;
        }

        private void inputPatientId_TextChanged(object sender, EventArgs e)
        {
            // do patient search here.
        }

        private void submitNote_Click(object sender, EventArgs e)
        {
            // Save the notes.
            CurrentNote.notes = inputNote.Text;
            DBI.NotesTable MyNotesTable = new DBI.NotesTable();
            MyNotesTable.UpdateItem(CurrentNote);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
