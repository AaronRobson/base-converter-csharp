using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseConv
{
    static class BaseConv
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* 
            bool ok;  // the code to make sure only one instance may be running at the same time
            System.Threading.Mutex m = new System.Threading.Mutex(true, "YourNameHere", out ok);

            if (!ok)
            {
                MessageBox.Show("Another instance is already running.");
                
                return;
            }
            GC.KeepAlive(m);
            */
            Application.Run(new frm_BaseCalc(args));
        }
    }
}