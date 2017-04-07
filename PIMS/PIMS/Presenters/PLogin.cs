using PIMS.Views;
using System;
using System.Collections.Generic;
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
            if (view.Username.Equals("test") && view.Password.Equals("test"))
            {
                // Close the view and pass control back to the calling function.
                view.DialogResult = DialogResult.OK;
                view.Close();
            }
            else
            {
                // Throw up an error message.
                MessageBox.Show("Your username and/or password is incorrect.", "Invalid Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
