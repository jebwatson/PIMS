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

            View.VisitorsList.SetObjects(MyVisitorsTable.ReadList());
        }

        public void RefreshVisitorsList()
        {
            VisitorsTable MyVisitorsTable = new VisitorsTable();
            View.VisitorsList.SetObjects(MyVisitorsTable.ReadList());
        }

        public void DeleteVisitors()
        {
            if (MessageBox.Show("Are you sure you want to delete the selected visitors?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (View.VisitorsList.SelectedObjects != null)
                {
                    foreach (var item in View.VisitorsList.SelectedObjects)
                    {
                        MyVisitorsTable.ClearTableByVisitor(((DBI.Visitors)item).patientId, ((DBI.Visitors)item).lastVisit);
                    }
                }
                else
                {
                    MessageBox.Show("No visitors available.");
                }

                RefreshVisitorsList();
            }
            else
            {
                return;
            }
        }

        public void AddVisitors()
        {
            NewVisitor MyNewVisitorForm = new NewVisitor();
            if (MyNewVisitorForm.ShowDialog() == DialogResult.OK)
            {
                RefreshVisitorsList();
            }
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
                    View.VisitorsList.SetObjects(MyVisitorsTable.ReadListById(p.patientId));
                else
                    View.VisitorsList.UpdateObjects(MyVisitorsTable.ReadListById(p.patientId));

                i++;
            }
        }
    }
}