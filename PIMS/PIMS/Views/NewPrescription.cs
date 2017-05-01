using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Views
{
    public partial class NewPrescription : Form
    {
        public NewPrescription()
        {
            InitializeComponent();
        }

        //Properties
        public int Id { get { return Convert.ToInt32(this.patientId.Text); } }
        public int Duration { get { return Convert.ToInt32(this.prescriptionDuration.Text); } }
        public string PrescriptionName { get { return this.prescriptionName.Text; } }
        public string PrescriptionAmount { get { return this.prescriptionAmount.Text; } }
        public DateTime DatePrescribed { get { return this.prescriptionDate.Value.Date; } }

        private void submitPrescriptions_Click(object sender, EventArgs e)
        {
            DBI.Prescriptions MyPrescription = new DBI.Prescriptions(PrescriptionName, PrescriptionAmount, DatePrescribed, Duration, Id, 1);

            DBI.PrescriptionsTable MyPrescriptionsTable = new DBI.PrescriptionsTable();

            MyPrescriptionsTable.WriteItem(MyPrescription);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelPrescriptions_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
