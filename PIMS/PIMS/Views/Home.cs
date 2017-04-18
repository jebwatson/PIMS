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
    public partial class frmHome : Form
    {
        private PHome Presenter;

        public frmHome()
        {
            InitializeComponent();
            Presenter = new PHome();
        }

        #region Event Handlers
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Presenter.CreatePatientsForm();
        }


        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin logout = new frmLogin();
            logout.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {

        }

        private void btnCharges_Click(object sender, EventArgs e)
        {

        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            Presenter.CreatePrescriptionsForm();
        }

        private void btnProcedures_Click(object sender, EventArgs e)
        {
            Presenter.CreateProceduresForm();
        }

        private void btnAdmissions_Click(object sender, EventArgs e)
        {
            Presenter.CreateAdmissionsForm();
        }

        private void btnVisitors_Click(object sender, EventArgs e)
        {

        }

        private void btnEmergencyContact_Click(object sender, EventArgs e)
        {

        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
