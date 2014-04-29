//
//Main function
//Gabriel Nieva M12K2712
//
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomerRegistryV2B
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
            Application.Run(new MainForm());
        }
    }
}
