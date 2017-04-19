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

        public ObjectListView NotesList { get { return this.olvNotesList; } }
        public string NoteSearch { get { return this.searchNotesBox.Text.Replace('*', '%'); } }

        public Notes()
        {
            InitializeComponent();
            Presenter = new PNotes(this);
            Initialize();
        }

        private void refreshNotes_Click(object sender, EventArgs e)
        {
            Presenter.RefreshNotesList();
        }

        private void addNotes_Click(object sender, EventArgs e)
        {
            Presenter.AddNotes();
        }

        private void removeNote_Click(object sender, EventArgs e)
        {
            Presenter.RemoveNotes();
        }

        private void searchNote_Click(object sender, EventArgs e)
        {
            Presenter.SearchNotes();
        }

        private void Initialize()
        {
            Presenter.PopulateNotesList();
        }
    }
}
