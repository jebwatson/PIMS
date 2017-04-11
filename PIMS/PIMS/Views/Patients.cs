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
    public partial class Patients : Form
    {
        // Locals
        PPatients Presenter;

        public ObjectListView PatientsList { get { return this.olvPatientsList; } }

        public Patients()
        {
            InitializeComponent();
            Presenter = new PPatients(this);
            Initialize();
        }

        private void btnRefreshPatients_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePatients_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {

        }

        private void Initialize()
        {
            Presenter.PopulatePatientsList();
        }
    }
}
