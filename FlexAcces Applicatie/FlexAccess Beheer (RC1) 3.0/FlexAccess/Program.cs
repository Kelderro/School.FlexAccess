using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlexAccess
{

    static class Program
    {
        private static bool StateLogIn = true;
        public static int inlogPerson = 0;
        public static frmFlexAccess frmMain;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (StateLogIn)
            {
                  StateLogIn = false;
                  if (frmLogin.DialogResult == DialogResult.OK)
                  {
                      frmMain = new frmFlexAccess(inlogPerson);
                      Application.Run(frmMain);
                  }
                  else
                  {
                       Application.Exit();
                  }
             }
             else
             {
                  if (frmLogin.DialogResult == DialogResult.OK)
                  {
                      frmMain = new frmFlexAccess(inlogPerson);
                      frmMain.Visible = true;
                  }
             }
        }
    }
}