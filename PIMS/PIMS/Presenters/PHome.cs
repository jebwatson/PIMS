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

    }
}
