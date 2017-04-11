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
    }
}
