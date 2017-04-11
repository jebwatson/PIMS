using DBI;
using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (MyPatientsList.Count == 0)
            {
                Patient Patient1 = new Patient(1, "Doe", "Jane", "A.", "Generic Street", "Huntsville", 
                    "AL", "35758", "", "", "", "", "", "", "Bob");
                MyPatientsTable.WriteItem(Patient1);
            }

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
        /// Add a new patient to the database and refresh the list.
        /// </summary>
        public void AddPatient()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete the selected patients from the database and refresh the list.
        /// </summary>
        public void DeletePatients()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Read the database by the user specified string and populate the table with the new list of patients.
        /// </summary>
        public void SearchPatients()
        {
            throw new NotImplementedException();
        }
    }
}
