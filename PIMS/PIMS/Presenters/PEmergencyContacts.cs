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
    class PEmergencyContacts
    {
        // Locals
        Views.EmergencyContacts View;
        PatientTable MyPatientsTable;
        EmergencyContactTable MyEmergencyContactsTable;
        List<Patient> MyPatientsList;

        public PEmergencyContacts(Views.EmergencyContacts view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyEmergencyContactsTable = new EmergencyContactTable();

            View.PatientsList.SetObjects(MyEmergencyContactsTable.ReadList());
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyEmergencyContactsTable = new EmergencyContactTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.PatientsList.SetObjects(MyEmergencyContactsTable.ReadListById(p.patientId));
                else
                    View.PatientsList.UpdateObjects(MyEmergencyContactsTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}