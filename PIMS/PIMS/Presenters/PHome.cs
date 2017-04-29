using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS.Presenters
{
    class PHome
    {
        public void CreatePatientsForm()
        {
            Patients PatientsForm = new Patients();
            PatientsForm.ShowDialog();
        }

        public void CreateProceduresForm()
        {
            Procedures ProcedureForm = new Procedures();
            ProcedureForm.ShowDialog();
        }

        public void CreatePrescriptionsForm()
        {
            Prescriptions PrescriptionsForm = new Prescriptions();
            PrescriptionsForm.ShowDialog();
        }

        public void CreateAdmissionsForm()
        {
            Admissions AdmissionsForm = new Admissions();
            AdmissionsForm.ShowDialog();
        }

        public void CreateChargesForm()
        {
            Charges ChargesForm = new Charges();
            ChargesForm.ShowDialog();
        }

        public void CreateInsuranceForm()
        {
            Insurance InsuranceForm = new Insurance();
            InsuranceForm.ShowDialog();
        }

        public void CreateEmergencyContactForm()
        {
            EmergencyContacts EmergencyContactForm = new EmergencyContacts();
            EmergencyContactForm.ShowDialog();
        }

        public void CreateBillsForm()
        {
            Bills BillsForm = new Bills();
            BillsForm.ShowDialog();
        }

        public void CreateVisitorsForm()
        {
            Visitors VisitorsForm = new Visitors();
            VisitorsForm.ShowDialog();
        }
        public void CreateNotesForm()
        {
            Notes NotesForm = new Notes();
            NotesForm.ShowDialog();
        }

        internal void CreateReportsForm()
        {
            Reports ReportsForm = new Reports();
            ReportsForm.ShowDialog();
        }
    }
}
