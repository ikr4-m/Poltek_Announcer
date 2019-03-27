using System;
using System.Windows.Forms;
using System.Diagnostics;
using PoltekAnnouncer.Assets;

namespace PoltekAnnouncer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName("PoltekAnnouncer").Length > 1)
            {
                MessageBox.Show("Sayangnya aplikasi ini telah berjalan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Launcher());
            }
        }
    }
}
