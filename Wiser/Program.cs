using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wiser
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
            wiserConnection = new WiserConnection();
            Application.Run(new MainForm());
        }
    }
}
