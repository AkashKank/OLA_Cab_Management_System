using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OLA_CAB_Management_Syatem
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
            Application.Run(new frm_Loding());
            //Application.Run(new frm_MDI_OlaCab());
        }
    }
}
