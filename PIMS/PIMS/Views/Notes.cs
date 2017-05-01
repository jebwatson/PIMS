using BrightIdeasSoftware;
using PIMS.Presenters;
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
    public partial class Notes : Form
    {
        // Locals
        PNotes Presenter;

        // Properties
        public ObjectListView NotesList { get { return this.olvNotesList; } }
        public ObjectListView PatientsList { get { return this.olvPatientsList; } }
        public bool EditEnabled { get { return this.btnEditNote.Enabled; } set { this.btnEditNote.Enabled = value; } }
        public bool DeleteEnabled { get { return this.removeNote.Enabled; } set { this.removeNote.Enabled = value; } }
        public string SearchText { get { return this.searchNotesBox.Text; } set { this.searchNotesBox.Text = value; } }
        public bool SearchEnabled { get { return this.searchNote.Enabled; } set { this.searchNote.Enabled = value; } }

        public Notes()
        {
            InitializeComponent();
            Presenter = new PNotes(this);
            Initialize();
        }

        private void Initialize()
        {
            Presenter.RefreshPatientsList();
            Presenter.RefreshNotesList();
        }

        private void removeNote_Click(object sender, EventArgs e)
        {
            Presenter.RemoveNotes();
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            Presenter.AddNotes();
        }

        private void btnEditNote_Click(object sender, EventArgs e)
        {
            Presenter.EditNotes();
        }

        private void refreshNotes_Click(object sender, EventArgs e)
        {
            Presenter.RefreshNotesList();
        }

        private void searchNote_Click(object sender, EventArgs e)
        {
            Presenter.SearchNotes();
        }

        private void searchNotesBox_TextChanged(object sender, EventArgs e)
        {
            Presenter.ToggleSearch();
        }

        private void olvNotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.RefreshForm();
        }

        private void olvPatientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.RefreshNotesList();
        }

        private void searchNotesBox_Click(object sender, EventArgs e)
        {
            searchNotesBox.SelectAll();
        }
    }
}
