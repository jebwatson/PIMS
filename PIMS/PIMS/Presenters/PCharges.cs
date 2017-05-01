using DBI;
using DBI.Utilities;
using PIMS.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PCharges
    {
        // Locals
        Views.Charges View;
        PatientTable MyPatientsTable;
        ChargesTable MyChargesTable;
        List<Patient> MyPatientsList;

        public PCharges(Views.Charges view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyChargesTable = new ChargesTable();

            View.ChargesList.SetObjects(MyChargesTable.ReadList());
        }

        public void AddCharge()
        {
            NewCharge MyNewChargesForm = new NewCharge();
            if (MyNewChargesForm.ShowDialog() == DialogResult.OK)
            {
                RefreshChargesList();
            }
        }

        public void RefreshChargesList()
        {
            ChargesTable MyChargesTable = new ChargesTable();
            View.ChargesList.SetObjects(MyChargesTable.ReadList());
        }

        public void DeleteCharges()
        {
            if (MessageBox.Show("Are you sure you want to delete the selected patients?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (View.ChargesList.SelectedObjects != null)
                {
                    foreach (var item in View.ChargesList.SelectedObjects)
                    {
                        MyChargesTable.ClearTableByCharge(((DBI.Charges)item).patientId, ((DBI.Charges)item).dateCharged);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to delete patients.");
                }

                RefreshChargesList();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyChargesTable = new ChargesTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.ChargesList.SetObjects(MyChargesTable.ReadListById(p.patientId));
                else
                    View.ChargesList.UpdateObjects(MyChargesTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}