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
    class PAdmissions
    {
        // Locals
        Views.Admissions View;
        PatientTable MyPatientsTable;
        AdmissionsTable MyAdmissionsTable;
        List<Patient> MyPatientsList;

        public PAdmissions(Views.Admissions view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyAdmissionsTable = new AdmissionsTable();

            View.AdmissionsList.SetObjects(MyAdmissionsTable.ReadList());
        }

        public void RefreshAdmissionsList()
        {
            AdmissionsTable MyAdmissionsTable = new AdmissionsTable();
            View.AdmissionsList.SetObjects(MyAdmissionsTable.ReadList());
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyAdmissionsTable = new AdmissionsTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.AdmissionsList.SetObjects(MyAdmissionsTable.ReadListById(p.patientId));
                else
                    View.AdmissionsList.UpdateObjects(MyAdmissionsTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}