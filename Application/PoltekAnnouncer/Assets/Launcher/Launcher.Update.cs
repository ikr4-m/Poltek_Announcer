using System.Windows.Forms;
using System.Drawing;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher : Form
    {
        private void UpdateJustice()
        {
            // Jalankan
            if (ExecutionButton.Text == CName.BeforeRunningButton)
            {
                viewer.Deploy(_DataPayload.Output);
                viewer.Deploy(_DataPayload.Output); // recurse

                StopButton.Visible = true;
                BackColor = SystemColors.ControlDark;
                ExecutionButton.Text = CName.AfterRunningButton;
                DebugLevelExtend("Aplikasi berhasil dijalankan!");
            }
            // Perbarui
            else if (ExecutionButton.Text == CName.AfterRunningButton)
            {
                viewer.Deploy(_DataPayload.Output);
                DebugLevelExtend("Data berhasil diperbarui!");
            }
        }
    }
}
