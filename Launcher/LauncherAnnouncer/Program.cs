using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using LauncherAnnouncer.Assets;

namespace LauncherAnnouncer
{
    class Program 
    {
        // BEGIN SHARED VARIABLE //
        public string path = Application.StartupPath;
        public string shortcutAddress = Environment.GetFolderPath(
            Environment.SpecialFolder.Startup) + @"\Poltek_Announcer.lnk";

        // BEGIN SHARED CLASS //
        private readonly StartupModule Startup = new StartupModule();
        private readonly HelpModule Help = new HelpModule();

        // BEGIN MAIN //
        static void Main(string[] args)
        {
            var p = new Program();

            foreach (string a in args)
            {
                switch (a.ToString().ToLower())
                {
                    // -help
                    case "-help": p.Help.Help(); break;
                    // -startup
                    case "-startup": p.Startup.Normal(); break;
                    // -startup-silent
                    case "-startup-silent": p.Startup.Silent(); break;
                    // -startup-remove
                    case "-startup-remove": p.Startup.DeleteStartup(p.shortcutAddress); break;
                    // -startup-location
                    case "-startup-location":
                        Console.WriteLine(p.shortcutAddress);
                        Environment.Exit(0);
                        break;
                    default: p.Help.Help(); break;
                }
            }

            int monitors = Screen.AllScreens.Length;
            string appEngine = Path.Combine(p.path, "PoltekAnnouncer.exe");
            if (monitors == 2)
            {
                Console.WriteLine("Mendetksi {0} monitor, langsung menjalankan aplikasi dan viewersnya.", monitors.ToString());
                if (File.Exists(appEngine))
                {
                    Process.Start(appEngine, "-start-viewer");
                }
                else
                {
                    Console.WriteLine("Engine tidak ditemukan!");
                    Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else if (monitors == 1)
            {
                Console.WriteLine("Hanya terdeteksi {0} monitor, menjalankan aplikasi seperti biasa.", monitors.ToString());
                if (File.Exists(appEngine))
                {
                    Process.Start(appEngine, "-start");
                }
                else
                {
                    Console.WriteLine("Engine tidak ditemukan!");
                    Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Maaf, kami hanya bisa menjangkau 2 monitor saja.\nTekan tombol terserah untuk exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
