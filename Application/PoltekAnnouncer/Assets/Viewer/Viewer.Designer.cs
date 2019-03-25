namespace PoltekAnnouncer.Assets
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LiveClock = new System.Windows.Forms.Timer(this.components);
            this.TimeSetting = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.MarqueeText = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MarqueeTimer = new System.Windows.Forms.Timer(this.components);
            this.KedipanBanner = new System.Windows.Forms.Timer(this.components);
            this.Slideshow = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LiveClock
            // 
            this.LiveClock.Enabled = true;
            this.LiveClock.Tick += new System.EventHandler(this.LiveClock_Tick);
            // 
            // TimeSetting
            // 
            this.TimeSetting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeSetting.Location = new System.Drawing.Point(0, -6);
            this.TimeSetting.Name = "TimeSetting";
            this.TimeSetting.Size = new System.Drawing.Size(213, 89);
            this.TimeSetting.TabIndex = 0;
            this.TimeSetting.Text = "<Clock>";
            this.TimeSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox1.Controls.Add(this.TimeSetting);
            this.GroupBox1.Controls.Add(this.MarqueeText);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(0, 481);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(875, 73);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            // 
            // MarqueeText
            // 
            this.MarqueeText.AutoSize = true;
            this.MarqueeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarqueeText.Location = new System.Drawing.Point(693, 12);
            this.MarqueeText.Name = "MarqueeText";
            this.MarqueeText.Size = new System.Drawing.Size(176, 58);
            this.MarqueeText.TabIndex = 1;
            this.MarqueeText.Text = "Label1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(875, 97);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "PENGUMUMAN";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarqueeTimer
            // 
            this.MarqueeTimer.Enabled = true;
            this.MarqueeTimer.Interval = 1;
            this.MarqueeTimer.Tick += new System.EventHandler(this.MarqueeTimer_Tick);
            // 
            // KedipanBanner
            // 
            this.KedipanBanner.Enabled = true;
            this.KedipanBanner.Interval = 690;
            // 
            // Slideshow
            // 
            this.Slideshow.Enabled = true;
            this.Slideshow.Interval = 10000;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(3, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 402);
            this.tabControl1.TabIndex = 6;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 554);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Timer LiveClock;
        internal System.Windows.Forms.Label TimeSetting;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label MarqueeText;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.Timer MarqueeTimer;
        internal System.Windows.Forms.Timer KedipanBanner;
        internal System.Windows.Forms.Timer Slideshow;
        private System.Windows.Forms.TabControl tabControl1;
    }
}