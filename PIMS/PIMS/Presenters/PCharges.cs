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

            View.PatientsList.SetObjects(MyChargesTable.ReadList());
        }

        public void AddCharge()
        {
            throw new NotImplementedException();
        }

        public void DeleteCharges()
        {
            throw new NotImplementedException();
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
                    View.PatientsList.SetObjects(MyChargesTable.ReadListById(p.patientId));
                else
                    View.PatientsList.UpdateObjects(MyChargesTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}