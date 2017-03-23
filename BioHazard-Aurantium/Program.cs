using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BioHazard_Aurantium
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
            Application.Run(new thegame());
        }
    }
}
