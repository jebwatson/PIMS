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
        EmergencyContactTable MyEmergencyContactTable;
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
            MyEmergencyContactTable = new EmergencyContactTable();

            View.EmergencyContactsList.SetObjects(MyEmergencyContactTable.ReadList());
        }

        public void RefreshEmergencyContactsList()
        {
            EmergencyContactTable MyEmergencyContactTable = new EmergencyContactTable();
            View.EmergencyContactsList.SetObjects(MyEmergencyContactTable.ReadList());
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyEmergencyContactTable = new EmergencyContactTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.EmergencyContactsList.SetObjects(MyEmergencyContactTable.ReadListById(p.patientId));
                else
                    View.EmergencyContactsList.UpdateObjects(MyEmergencyContactTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}