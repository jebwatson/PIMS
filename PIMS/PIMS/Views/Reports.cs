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
    public partial class Reports : Form
    {
        // Locals
        PReports Presenter;

        public ObjectListView ReportsList { get { return this.olvReportsList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Reports()
        {
            InitializeComponent();
            Presenter = new PReports(this);
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

        private void btnPatientReport_Click(object sender, EventArgs e)
        {
            Presenter.GeneratePatientReport();
        }

        private void btnAdmissionsReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateAdmissionsReport();
        }

        private void btnBillsReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateBillsReport();
        }

        private void btnChargesReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateChargesReport();
        }

        private void btnEmergencyContactsReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateEmergencyContactsReport();
        }

        private void btnInsuranceReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateInsuranceReport();
        }

        private void btnNotesReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateNotesReport();
        }

        private void btnPrescriptionsReport_Click(object sender, EventArgs e)
        {
            Presenter.GeneratePrescriptionsReport();
        }

        private void btnProceduresReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateProceduresReport();
        }

        private void btnVisitorsReport_Click(object sender, EventArgs e)
        {
            Presenter.GenerateVisitorsReport();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            olvReportsList.SelectAll();
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            olvReportsList.DeselectAll();
        }
    }
}
