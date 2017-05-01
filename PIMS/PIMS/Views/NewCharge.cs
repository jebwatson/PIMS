using BrightIdeasSoftware;
using DBI;
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
    public partial class NewCharge : Form
    {
        public NewCharge()
        {
            InitializeComponent();
        }

        // Properties
        public int Id { get { return Convert.ToInt32(this.txtPatientId.Text); } }
        public string Description { get { return this.txtDescription.Text; } }
        public DateTime DateCharged { get { return this.dtpDateCharged.Value.Date; } }
        public DateTime DateDue { get { return this.dtpDateDue.Value.Date; } }
        public string AmountTotal { get { return this.txtAmountTotal.Text; } }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DBI.Charges MyCharge = new DBI.Charges(Description, AmountTotal, DateCharged, DateDue, 1, 1, Id, 1);

            ChargesTable MyChargesTable = new ChargesTable();

            MyChargesTable.WriteItem(MyCharge);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
