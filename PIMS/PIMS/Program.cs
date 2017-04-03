using PIMS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();

            login.Show();

           
           Application.Run();

            //if (new Login().ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Home());
            //}
        }
    }
}
