using BrightIdeasSoftware;
using PIMS.Presenters;
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
    public partial class Reports : Form
    {

        PReports Presenter;

        public ObjectListView 

        public Reports()
        {
            InitializeComponent();
            Presenter = new PReports(this);
            Initialize();
        }

        private void searchReports_Click(object sender, EventArgs e)
        {
            Pesenter.SearchReports();
        }

        private void printOneReport_Click(object sender, EventArgs e)
        {

        }

        private void printAllPatients_Click(object sender, EventArgs e)
        {

        }
    }
}
