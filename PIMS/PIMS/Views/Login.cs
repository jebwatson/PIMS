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
    public partial class frmLogin : Form
    {
        private PLogin Presenter;

        /// <summary>
        /// Initialize the presenter, passing the view in as a dependency.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            Presenter = new PLogin(this);
        }

        #region Properties
        public string Username { get { return this.txtUsername.Text; } }
        public string Password { get { return this.txtPassword.Text; } }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Raise a LoginClick event for the presenter to handle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Presenter.Login();
        }
        #endregion

    }
}
