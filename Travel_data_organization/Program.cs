using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Travel_data_organization.PL;

namespace Travel_data_organization
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
            Application.Run(new FRM_Main());
        }
    }
}
