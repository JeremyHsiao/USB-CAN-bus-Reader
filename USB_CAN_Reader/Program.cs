using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace USB_CAN_READER
{
    static class Program
    {
        /// <summary>
        /// Main Entry point of application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CAN_Reader_Form());
        }
    }
}