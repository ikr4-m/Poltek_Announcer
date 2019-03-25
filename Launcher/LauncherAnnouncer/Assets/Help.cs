using System;

namespace LauncherAnnouncer.Assets
{
    class HelpModule
    {
        private readonly string help = "Penggunaan:\n" +
                              "    startup.exe <flag>\n\n" +
                              "Adapun beberapa flag yang diperbolehkan di sini adalah:\n" +
                              "-startup\n" +
                              "    Untuk memasang startup di komputer ini.\n" +
                              "-startup-remove\n" +
                              "    Untuk menghapus startup di komputer ini.\n\n";
        public void Help()
        {
            Console.WriteLine(help);
            Environment.Exit(0);
        }
    }
}
