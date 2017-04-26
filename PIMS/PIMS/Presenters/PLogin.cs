//#define JEBSCOMPUTER

using DBI;
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
            try
            {
                // Comment out the #define statement at the beginning of this file to disable this.
#if JEBSCOMPUTER
                view.ServerName = "CSSA-JEB\\SQLEXPRESS";
                view.DatabaseName = "PIMSFeatureTest";
                view.Username = "doctor";
                view.Password = "test";
#endif

                ConnectionsManager.SQLServerConnectionString = "Data Source=" + view.ServerName + ";Initial Catalog=" +
                    view.DatabaseName + ";Integrated Security=False;User Id=" + view.Username + ";Password=" + view.Password + ";MultipleActiveResultSets=True;";

                // Establish a connection and close at the end of using
                using (SqlConnection myConnection = ConnectionsManager.GetNewConnection())
                {
                    if (myConnection != null)
                    {
                        UsersTable MyUsersTable = new UsersTable();
                        List<Users> MyUsersList = MyUsersTable.ReadListByUserName(view.Username);

                        Settings.User.Default.UserId = MyUsersList[0].userId;
                        Settings.User.Default.UserName = MyUsersList[0].username;

                        if (MyUsersList[0].accessLevel == 3)
                        {
                            Settings.User.Default.Doctor = false;
                            Settings.User.Default.Nurse = true;
                        }
                        else if (MyUsersList[0].accessLevel == 4)
                        {
                            Settings.User.Default.Doctor = true;
                            Settings.User.Default.Nurse = false;
                        }
                        else
                        {
                            Settings.User.Default.Doctor = false;
                            Settings.User.Default.Nurse = false;
                        }

                        // Close the view and pass control back to the calling function.
                        view.DialogResult = DialogResult.OK;
                        view.Hide();
                    }
                    else
                    {
                        throw new Exception("Bad database connection.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
