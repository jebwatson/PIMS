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
    public partial class Insurance : Form
    {
        // Locals
        PInsurance Presenter;

        public ObjectListView InsuranceList { get { return this.olvInsuranceList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Insurance()
        {
            InitializeComponent();
            Presenter = new PInsurance(this);
            Initialize();
        }

        private void Initialize()
        {
            Presenter.PopulatePatientsList();
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            Presenter.SearchPatients();
        }

        private void refreshInsurance_Click(object sender, EventArgs e)
        {
            Presenter.RefreshInsuranceList();
        }
    }
}
