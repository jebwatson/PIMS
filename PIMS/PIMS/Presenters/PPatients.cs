using DBI;
using DBI.Utilities;
using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PPatients
    {
        // Locals
        Patients View;
        PatientTable MyPatientsTable;
        List<Patient> MyPatientsList;

        public PPatients(Patients view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadList();

            View.PatientsList.SetObjects(MyPatientsTable.ReadList());
        }

        /// <summary>
        /// Refresh the patients list.
        /// </summary>
        public void RefreshPatientsList()
        {
            MyPatientsTable = new PatientTable();
            View.PatientsList.SetObjects(MyPatientsTable.ReadList());
        }

        /// <summary>
        /// Open a new new patients form.
        /// </summary>
        public void AddPatient()
        {
            frmNewPatient MyNewPatientsForm = new frmNewPatient();
            if (MyNewPatientsForm.ShowDialog() == DialogResult.OK)
            {
                RefreshPatientsList();
            }
        }

        /// <summary>
        /// Delete the selected patients from the database and refresh the list.
        /// </summary>
        public void DeletePatients()
        {
            if (MessageBox.Show("Are you sure you want to delete the selected patients?", 
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (View.PatientsList.SelectedObjects != null)
                {
                    foreach (var item in View.PatientsList.SelectedObjects)
                    {
                        MyPatientsTable.ClearTableById(((Patient)item).patientId);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to delete patients.");
                }

                RefreshPatientsList();
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
            MyPatientsTable = new PatientTable();
            View.PatientsList.SetObjects(MyPatientsTable.ReadListByName(View.PatientSearch));
        }
    }
}
