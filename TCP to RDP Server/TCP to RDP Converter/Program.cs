using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_to_RDP_Converter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "UMC REMOTE DESKTOP", out result);
            if (!result)
            {
                MessageBox.Show("Program is already running.");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 main = new Form1();
            Application.Run();
        }
    }
}
