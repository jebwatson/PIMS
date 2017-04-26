using BrightIdeasSoftware;
using PIMS.Presenters;
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
    public partial class AddNote : Form
    {
        private int patientId = 0;

        public string AddNoteStr { get { return this.txtAddNote.Text; } }

        public AddNote(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBI.Notes MyNote = new DBI.Notes(AddNoteStr, Settings.User.Default.Doctor, Settings.User.Default.Nurse, Settings.User.Default.UserId, patientId);
            NotesTable MyNotesTable = new NotesTable();
            MyNotesTable.WriteItem(MyNote);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
