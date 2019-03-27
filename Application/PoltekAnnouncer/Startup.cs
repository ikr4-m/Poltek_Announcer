using System;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace PoltekAnnouncer
{
    public class Startup
    {
        private readonly string InkName = @"\PoltekAnnouncer.lnk";

        public bool Check()
        {
            WshShell shell = new WshShell();
            string shortcutAddress = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), InkName);

            if (System.IO.File.Exists(shortcutAddress)) return true;
            else return false;
        }

        public void AddStartup()
        {
            WshShell shell = new WshShell();
            string shortcutAddress = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), InkName);

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "PoltekAnnouncer.";
            shortcut.TargetPath = Path.Combine(Application.StartupPath, "PoltekAnnouncer.exe");
            shortcut.Save();
        }
    }
}
