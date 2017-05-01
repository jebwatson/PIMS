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
    public partial class Bills : Form
    {
        // Locals
        PBills Presenter;

        public ObjectListView BillsList { get { return this.olvBillsList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Bills()
        {
            InitializeComponent();
            Presenter = new PBills(this);
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

        private void refreshBills_Click(object sender, EventArgs e)
        {
            Presenter.RefreshBillsList();
        }
    }
}
