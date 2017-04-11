using DBI.Utilities;
using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS.Presenters
{
    class PLogin
    {
        private frmLogin view;

        public PLogin(frmLogin view)
        {
            this.view = view;
        }

        /// <summary>
        /// Attempt a login using the view's username and password.
        /// </summary>
        public void Login()
        {
            try {
                ConnectionsManager.SQLServerConnectionString = "Data Source=DESKTOP-LCTG0FT\\SQLEXPRESS;Initial Catalog=" +
                    "PIMSDev;Integrated Security=False;User Id=" + view.Username + ";Password=" + view.Password + ";MultipleActiveResultSets=True;";

                // Establish a connection and close at the end of using
                using (SqlConnection myConnection = ConnectionsManager.GetNewConnection()) {
                    // Close the view and pass control back to the calling function.
                    view.DialogResult = DialogResult.OK;
                    view.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
