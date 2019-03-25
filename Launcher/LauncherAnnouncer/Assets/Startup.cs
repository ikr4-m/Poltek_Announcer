using System;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace LauncherAnnouncer.Assets
{
    class StartupModule
    {
        private void Start(bool silent)
        {   
            string path = Application.StartupPath;
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Poltek_Announcer.lnk";
            WshShell shell = new WshShell();

            Console.WriteLine("Startup terpasang di {0}", shortcutAddress);
            if (!System.IO.File.Exists(shortcutAddress))
            {
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "Poltek_Announcer";
                shortcut.TargetPath = Path.Combine(path, "Startup.exe");
                shortcut.Save();
            }
            // silent default = false
            if (silent != true)
            {
                Console.WriteLine("Aplikasi telah berhasil terpasang di Startup!\nTekan tombol ENTER untuk keluar.");
                Console.ReadLine();
            }
            Environment.Exit(0);
        }
        public void Normal()
        {
            Start(false);
        }
        public void Silent()
        {
            Start(true);
        }
        public void DeleteStartup(string ShortcutAddress)
        {
            string pathStartup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            if (System.IO.File.Exists(ShortcutAddress))
            {
                System.IO.File.Delete(ShortcutAddress);
                Console.WriteLine("Startup berhasil dicopot!");
                Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Startup belum terpasang! Launch aplikasi ini dengan -shortcut untuk memasang startup di komputer anda.");
                Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
