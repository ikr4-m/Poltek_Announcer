using System;
using System.IO;
using System.Windows.Forms;

namespace PoltekAnnouncer.Assets
{
    public partial class Launcher : Form
    {
        private void ComponentForm()
        {
            // Database purposes
            this.Load += DatabaseLoad;
            this.FormClosing += SavingDatabase;
            DeleteStartup.Click += DeleteStartup_Click;

            // App load
            this.Load += new EventHandler(Launcher_Load);

            // Controller adding page
            AddText.Click += AddText_Click;
            AddPicture.Click += AddPicture_Click;
            DeleteAll.Click += DeleteAll_Click;

            // Controller launcher
            ExecutionButton.Click += ExecutionButton_Click;
            StopButton.Click += StopButton_Click;

            // Closing Handler
            this.FormClosed += Launcher_FormClosed;

            // Marquee Purposes
            TambahBtn.Click += TambahBtn_Click;
            EditBtn.Click += EditBtn_Click;
            HapusBtn.Click += HapusBtn_Click;
        }

        private void Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewer.Close();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            // Hide pagination justice
            PageJustice.Visible = false;

            // Hide Stop Button
            StopButton.Visible = false;

            // For ExecutionButton purposes
            ExecutionButton.Text = CName.BeforeRunningButton;

            // Debug Label
            CopyrightLabel.Text = string.Format("(C) 2019-{0} UPT Komputer dan Sistem Informasi. All rights reserved.", DateTime.Now.Year);
            DebugLevelExtend("Siap beroperasi!");
            
            if (startup.Check() == false)
            {
                DialogResult result = MessageBox.Show("Startup belum terpasang di dalam komputer ini. Apakah anda ingin memasangnya?",
                    "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    startup.AddStartup();
                    MessageBox.Show("Aplikasi telah berhasil dipasang di Startup!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    DeleteStartup.Enabled = false;
            }
        }

        private void DeleteStartup_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), @"\PoltekAnnouncer.lnk"));
            MessageBox.Show("Startup telah terhapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Launcher()
        {
            InitializeComponent();
            ComponentForm(); 
        }
    }
}
