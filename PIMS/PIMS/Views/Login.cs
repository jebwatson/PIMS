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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("test") && txtPassword.Text.Equals("test"))
            {
                this.Close();
                frmHome home = new frmHome();
                home.Show();
            }
            else
            {
                MessageBox.Show("Your username and/or password is incorrect.", "Invalid Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getUsername()
        {
            return txtUsername.Text;
        }

        public string getPassword()
        {
            return txtPassword.Text;
        }

     
    }
}
