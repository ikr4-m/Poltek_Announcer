using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using IWshRuntimeLibrary;

namespace LauncherAnnouncer
{
    class Program
    {
        static void Main(string[] args)
        {
            int monitors = Screen.AllScreens.Length;
            string path = Application.StartupPath;
            string appEngine = Path.Combine(path, "PoltekAnnouncer.exe");
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Poltek_Announcer.lnk";

            foreach (string a in args) {
                if (a.ToLower() == "-help")
                {
                    Console.WriteLine(
                        "Penggunaan:\n" +
                        "    startup.exe <flag>\n\n" +
                        "Adapun beberapa flag yang diperbolehkan di sini adalah:\n" +
                        "-startup\n" +
                        "    Untuk memasang startup di komputer ini.\n" +
                        "-startup-remove\n" +
                        "    Untuk menghapus startup di komputer ini.\n\n");
                    Environment.Exit(0x00000000);
                }
                else if (a.ToLower() == "-startup")
                {
                    WshShell shell = new WshShell();

                    Console.WriteLine("Startup terpasang di {0}", shortcutAddress);
                    if (!System.IO.File.Exists(shortcutAddress))
                    {
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.Description = "Poltek_Announcer";
                        shortcut.TargetPath = Path.Combine(path, "Startup.exe");
                        shortcut.Save();
                    }
                    Console.WriteLine("Aplikasi telah berhasil terpasang di Startup!\nTekan sembarang tombol untuk keluar.");
                    Console.ReadLine();
                    Environment.Exit(0x00000000);
                }
                else if (a.ToLower() == "-startup-remove")
                {
                    string pathStartup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                    if (System.IO.File.Exists(shortcutAddress))
                    {
                        System.IO.File.Delete(shortcutAddress);
                        Console.WriteLine("Startup berhasil dicopot!");
                        Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                        Console.ReadLine();
                        Environment.Exit(0x00000000);
                    }
                    else
                    {
                        Console.WriteLine("Startup belum terpasang! Launch aplikasi ini dengan -shortcut untuk memasang startup di komputer anda.");
                        Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                        Console.ReadLine();
                        Environment.Exit(0x00000000);
                    }
                }
            }

            if (monitors == 2)
            {
                Console.WriteLine("Mendetksi {0} monitor, langsung menjalankan aplikasi dan viewersnya.", monitors.ToString());
                if (System.IO.File.Exists(appEngine))
                {
                    Process.Start(appEngine, "-start-viewer");
                }
                else
                {
                    Console.WriteLine("Engine tidak ditemukan!");
                    Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                    Console.ReadLine();
                    Environment.Exit(0x00000000);
                }
            }
            else if (monitors == 1)
            {
                Console.WriteLine("Hanya terdeteksi {0} monitor, menjalankan aplikasi seperti biasa.", monitors.ToString());
                if (System.IO.File.Exists(appEngine))
                {
                    Process.Start(appEngine, "-start");
                }
                else
                {
                    Console.WriteLine("Engine tidak ditemukan!");
                    Console.WriteLine("Tekan ENTER untuk keluar dari aplikasi ini.");
                    Console.ReadLine();
                    Environment.Exit(0x00000000);
                }
            }
            else
            {
                Console.WriteLine("Maaf, kami hanya bisa menjangkau 2 monitor saja.\nTekan tombol terserah untuk exit.");
                Console.ReadLine();
                Environment.Exit(0x00000000);
            }
        }
    }
}
