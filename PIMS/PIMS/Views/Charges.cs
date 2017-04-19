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
    public partial class Charges : Form
    {
        // Locals
        PCharges Presenter;

        public ObjectListView ChargesList { get { return this.olvChargesList; } }
        public string PatientSearch { get { return this.txtPatientSearch.Text.Replace('*', '%'); } }

        public Charges()
        {
            InitializeComponent();
            Presenter = new PCharges(this);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.AddCharge();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Presenter.DeleteCharges();
        }
    }
}
