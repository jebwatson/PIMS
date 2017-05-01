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
    public partial class NewProcedure : Form
    {
        public NewProcedure()
        {
            InitializeComponent();
        }

        //Properties
        public DateTime DateStarted { get { return this.startTime.Value.Date; } }
        public DateTime DateStopped { get { return this.stopTime.Value.Date; } }
        public string ProcedureType { get { return this.procedureType.Text; } }
        public int DurationHours { get { return Convert.ToInt32(this.durationHours.Text); } }
        public int DurationMinutes { get { return Convert.ToInt32(this.durationMinutes.Text); } }
        public string ProcedureNotes { get { return this.procedureNotes.Text; } }
        public int Id { get { return Convert.ToInt32(this.patientId.Text); } }

        private void submitProcedure_Click(object sender, EventArgs e)
        {
            DBI.Procedures MyProcedure = new DBI.Procedures(DateStarted, DateStopped, ProcedureType, DurationHours, DurationMinutes, 1, ProcedureNotes, Id, 1);

            DBI.ProceduresTable MyProceduresTable = new DBI.ProceduresTable();

            MyProceduresTable.WriteItem(MyProcedure);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelProcedure_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
