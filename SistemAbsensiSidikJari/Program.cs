using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemAbsensiSidikJari.View;

namespace SistemAbsensiSidikJari
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
            Application.Run(new loginForm());
            /*
            loginForm log = new loginForm();
            if (log.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            */
        }
    }
}
