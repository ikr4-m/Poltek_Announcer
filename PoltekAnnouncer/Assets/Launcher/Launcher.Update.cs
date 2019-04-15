using System.Drawing;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher
    {
        private void UpdateJustice()
        {
            // Jalankan
            if (ExecutionButton.Text == CName.BeforeRunningButton)
            {
                viewer.Deploy(_DataPayload.Output, ListboxItems);
                viewer.Deploy(_DataPayload.Output, ListboxItems); // recurse

                StopButton.Visible = true;
                BackColor = SystemColors.ControlDark;
                ExecutionButton.Text = CName.AfterRunningButton;
                DebugLevelExtend("Aplikasi berhasil dijalankan!");
            }
            // Perbarui
            else if (ExecutionButton.Text == CName.AfterRunningButton)
            {
                viewer.Deploy(_DataPayload.Output, ListboxItems);
                DebugLevelExtend("Data berhasil diperbarui!");
            }
        }
    }
}
