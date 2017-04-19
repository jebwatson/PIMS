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
    class PVisitors
    {
        // Locals
        Views.Visitors View;
        PatientTable MyPatientsTable;
        VisitorsTable MyVisitorsTable;
        List<Patient> MyPatientsList;

        public PVisitors(Views.Visitors view)
        {
            View = view;
        }

        /// <summary>
        /// Populate the patients table for the first time after it is created.
        /// If there are no patients in the database, add a default case.
        /// </summary>
        public void PopulatePatientsList()
        {
            MyVisitorsTable = new VisitorsTable();

            View.PatientsList.SetObjects(MyVisitorsTable.ReadList());
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with 
        /// the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            MyVisitorsTable = new VisitorsTable();
            MyPatientsTable = new PatientTable();
            MyPatientsList = MyPatientsTable.ReadListByName(View.PatientSearch);
            int i = 0;

            foreach (Patient p in MyPatientsList)
            {
                if (i == 0)
                    View.PatientsList.SetObjects(MyVisitorsTable.ReadListById(p.patientId));
                else
                    View.PatientsList.UpdateObjects(MyVisitorsTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}