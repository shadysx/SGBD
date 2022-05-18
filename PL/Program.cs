using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CONNECTION TEMPORAIRE MAIN, NE PAS OUBLIER D'ENLEVER LE COMPTE DANS LAOD_MAIN
            Application.Run(new Main());
        }
    }
}
