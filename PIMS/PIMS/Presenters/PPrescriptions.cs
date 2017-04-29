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
    class PPrescriptions
    {
        // Locals
        Views.Prescriptions View;
        PatientTable MyPatientsTable;
        PrescriptionsTable MyPrescriptionsTable;
        List<Patient> MyPatientsList;

        public PPrescriptions(Views.Prescriptions view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyPrescriptionsTable = new PrescriptionsTable();

            View.PrescriptionsList.SetObjects(MyPrescriptionsTable.ReadList());
        }

        public void RefreshPrescriptionsList()
        {
            PrescriptionsTable MyPrescriptionsTable = new PrescriptionsTable();
            View.PrescriptionsList.SetObjects(MyPrescriptionsTable.ReadList());
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyPrescriptionsTable = new PrescriptionsTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.PrescriptionsList.SetObjects(MyPrescriptionsTable.ReadListById(p.patientId));
                else
                    View.PrescriptionsList.UpdateObjects(MyPrescriptionsTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}