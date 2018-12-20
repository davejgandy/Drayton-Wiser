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
        private static MainForm _mainForm;
        internal static MainForm MainForm { get { return _mainForm; } }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            wiserConnection = new WiserConnection();
            _mainForm = new MainForm();
            Application.Run(_mainForm);
        }

    }
}
