using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlexAccess
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static frmMain clientForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clientForm = new frmMain("10.0.0.8", 1337);
            Application.Run(clientForm);
        }
    }
}