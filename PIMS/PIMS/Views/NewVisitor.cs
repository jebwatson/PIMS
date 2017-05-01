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
    public partial class NewVisitor : Form
    {
        public NewVisitor()
        {
            InitializeComponent();
        }

        //Properties
        public string LastName { get { return this.lastName.Text; } }
        public string FirstName { get { return this.firstName.Text; } }
        public string Relation { get { return this.visitorRelation.Text; } }
        public DateTime LastVisit { get { return this.lastVisit.Value.Date; } }
        public int Id { get { return Convert.ToInt32(this.patientId.Text); } }

        private void submitVisitors_Click(object sender, EventArgs e)
        {
            DBI.Visitors MyVisitor = new DBI.Visitors(LastName, FirstName, Relation, LastVisit, Id, 1);

            DBI.VisitorsTable MyVisitorsTable = new DBI.VisitorsTable();

            MyVisitorsTable.WriteItem(MyVisitor);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelVisitor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
