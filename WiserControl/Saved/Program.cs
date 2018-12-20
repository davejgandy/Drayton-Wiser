using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Wiser;

namespace WiserControl
{
    static class Program
    {
        public static WiserConnection wiserConnection;

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
