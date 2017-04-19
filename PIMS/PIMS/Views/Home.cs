using DBI;
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
        private frmLogin loggedIn;
        private UsersTable MyUsersTable;
        private List<Users> MyUsersList;

        public frmHome(frmLogin login)
        {
            InitializeComponent();

            Presenter = new PHome();
            loggedIn = login;

            MyUsersTable = new UsersTable();
            MyUsersList = MyUsersTable.ReadList();

            foreach (Users user in MyUsersList)
            {
                if (user.username == loggedIn.Username)
                {
                    if (user.accessLevel == 1)
                    {
                        btnPatients.Enabled = false;
                        btnPrescriptions.Enabled = false;
                        btnProcedures.Enabled = false;
                        btnEmergencyContact.Enabled = false;
                        btnInsurance.Enabled = false;
                        btnCharges.Enabled = false;
                        btnBills.Enabled = false;
                        btnNotes.Enabled = false;
                        btnReports.Enabled = false;
                    }

                    if (user.accessLevel == 2)
                    {
                        btnAdmissions.Enabled = false;
                        btnVisitors.Enabled = false;
                        btnPrescriptions.Enabled = false;
                        btnProcedures.Enabled = false;
                        btnEmergencyContact.Enabled = false;
                        btnNotes.Enabled = false;
                        btnReports.Enabled = false;
                    }
                }
            }
        }

        #region Event Handlers
        
        private void btnPatients_Click(object sender, EventArgs e)
        {
            Presenter.CreatePatientsForm();
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (loggedIn.ShowDialog() == DialogResult.OK)
            {
                this.Show();

                MyUsersTable = new UsersTable();
                MyUsersList = MyUsersTable.ReadList();

                foreach (Users user in MyUsersList)
                {
                    if (user.username == loggedIn.Username)
                    {
                        if (user.accessLevel == 1)
                        {
                            btnPrescriptions.Enabled = false;
                            btnProcedures.Enabled = false;
                            btnEmergencyContact.Enabled = false;
                            btnInsurance.Enabled = false;
                            btnCharges.Enabled = false;
                            btnBills.Enabled = false;
                            btnNotes.Enabled = false;
                            btnReports.Enabled = false;
                        }

                        if (user.accessLevel == 2)
                        {
                            btnAdmissions.Enabled = false;
                            btnVisitors.Enabled = false;
                            btnPrescriptions.Enabled = false;
                            btnProcedures.Enabled = false;
                            btnEmergencyContact.Enabled = false;
                            btnNotes.Enabled = false;
                            btnReports.Enabled = false;
                        }

                        if (user.accessLevel == 3 || user.accessLevel == 4)
                        {
                            btnAdmissions.Enabled = true;
                            btnVisitors.Enabled = true;
                            btnPrescriptions.Enabled = true;
                            btnProcedures.Enabled = true;
                            btnEmergencyContact.Enabled = true;
                            btnInsurance.Enabled = true;
                            btnCharges.Enabled = true;
                            btnBills.Enabled = true;
                            btnNotes.Enabled = true;
                            btnReports.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            Presenter.CreateBillsForm();
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            Presenter.CreateChargesForm();
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
            Presenter.CreateVisitorsForm();
        }

        private void btnEmergencyContact_Click(object sender, EventArgs e)
        {
            Presenter.CreateEmergencyContactForm();
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            Presenter.CreateInsuranceForm();
        }
        #endregion
    }
}
