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
        public string Description { get { return this.txtDescription.Text; } }
        public string DateAdded { get { return this.dtpDateCharged.Value.Date.ToString() + " " + this.dtpDateCharged.Value.TimeOfDay.ToString(); } }
        public string DateDue { get { return this.dtpDateDue.Value.Date.ToString() + " " + this.dtpDateDue.Value.TimeOfDay.ToString(); } }
        public string AmountTotal { get { return this.txtAmountTotal.Text; } }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
