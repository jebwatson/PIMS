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
    public partial class Admissions : Form
    {
        // Locals
        PAdmissions Presenter;

        public ObjectListView AdmissionsList { get { return this.olvAdmissionsList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Admissions()
        {
            InitializeComponent();
            Presenter = new PAdmissions(this);
            Initialize();
        }

        private void Initialize()
        {
            Presenter.PopulatePatientsList();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            Presenter.SearchPatients();
        }
    }
}
