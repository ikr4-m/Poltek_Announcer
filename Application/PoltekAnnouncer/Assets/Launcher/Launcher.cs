using System;
using System.Windows.Forms;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher : Form
    {
        private void ComponentForm()
        {
            // App load
            this.Load += new EventHandler(Launcher_Load);

            // Controller adding page
            AddText.Click += AddText_Click;
            AddPicture.Click += AddPicture_Click;
            DeleteAll.Click += DeleteAll_Click;

            // Controller launcher
            ExecutionButton.Click += ExecutionButton_Click;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            // Hide pagination justice
            PageJustice.Visible = false;

            // Hide Stop Button
            StopButton.Visible = false;
        }

        public Launcher()
        {
            InitializeComponent();
            ComponentForm(); 
        }
    }
}
