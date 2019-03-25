namespace PoltekAnnouncer.Assets
{
    partial class Launcher
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
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DebugLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.ExecutionButton = new System.Windows.Forms.Button();
            this.PageJustice = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Addon = new System.Windows.Forms.TabPage();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.AddPicture = new System.Windows.Forms.Button();
            this.AddText = new System.Windows.Forms.Button();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.TambahBtn = new System.Windows.Forms.Button();
            this.ListBoxMarquee = new System.Windows.Forms.ListBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MinimizeValidation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureDuration = new System.Windows.Forms.NumericUpDown();
            this.TextDuration = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.NumericUpDown();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox2.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Addon.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "Aplikasi Pengumuman";
            this.NotifyIcon.Visible = true;
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(9, 336);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(64, 17);
            this.DebugLabel.TabIndex = 12;
            this.DebugLabel.Text = "<debug>";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(9, 359);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(70, 17);
            this.CopyrightLabel.TabIndex = 11;
            this.CopyrightLabel.Text = "<kopirek>";
            // 
            // ExecutionButton
            // 
            this.ExecutionButton.Location = new System.Drawing.Point(884, 336);
            this.ExecutionButton.Name = "ExecutionButton";
            this.ExecutionButton.Size = new System.Drawing.Size(172, 40);
            this.ExecutionButton.TabIndex = 10;
            this.ExecutionButton.Text = "Jalankan";
            this.ExecutionButton.UseVisualStyleBackColor = true;
            // 
            // PageJustice
            // 
            this.PageJustice.AutoSize = true;
            this.PageJustice.Location = new System.Drawing.Point(213, 10);
            this.PageJustice.Name = "PageJustice";
            this.PageJustice.Size = new System.Drawing.Size(16, 17);
            this.PageJustice.TabIndex = 4;
            this.PageJustice.Text = "0";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.PageJustice);
            this.GroupBox2.Controls.Add(this.TabControl);
            this.GroupBox2.Location = new System.Drawing.Point(410, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(441, 318);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Isi Pengumuman";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Addon);
            this.TabControl.Location = new System.Drawing.Point(6, 30);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(429, 276);
            this.TabControl.TabIndex = 3;
            // 
            // Addon
            // 
            this.Addon.Controls.Add(this.DeleteAll);
            this.Addon.Controls.Add(this.AddPicture);
            this.Addon.Controls.Add(this.AddText);
            this.Addon.Location = new System.Drawing.Point(4, 25);
            this.Addon.Name = "Addon";
            this.Addon.Padding = new System.Windows.Forms.Padding(3);
            this.Addon.Size = new System.Drawing.Size(421, 247);
            this.Addon.TabIndex = 0;
            this.Addon.Text = "+";
            this.Addon.UseVisualStyleBackColor = true;
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(122, 136);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(160, 79);
            this.DeleteAll.TabIndex = 3;
            this.DeleteAll.Text = "Hapus Semua Halaman";
            this.DeleteAll.UseVisualStyleBackColor = true;
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(231, 36);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(160, 79);
            this.AddPicture.TabIndex = 1;
            this.AddPicture.Text = "Tambah Foto";
            this.AddPicture.UseVisualStyleBackColor = true;
            // 
            // AddText
            // 
            this.AddText.Location = new System.Drawing.Point(28, 36);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(160, 79);
            this.AddText.TabIndex = 0;
            this.AddText.Text = "Tambah Teks";
            this.AddText.UseVisualStyleBackColor = true;
            // 
            // HapusBtn
            // 
            this.HapusBtn.Location = new System.Drawing.Point(266, 114);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(114, 36);
            this.HapusBtn.TabIndex = 3;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(266, 72);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(114, 36);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // TambahBtn
            // 
            this.TambahBtn.Location = new System.Drawing.Point(266, 30);
            this.TambahBtn.Name = "TambahBtn";
            this.TambahBtn.Size = new System.Drawing.Size(114, 36);
            this.TambahBtn.TabIndex = 1;
            this.TambahBtn.Text = "Tambah";
            this.TambahBtn.UseVisualStyleBackColor = true;
            // 
            // ListBoxMarquee
            // 
            this.ListBoxMarquee.FormattingEnabled = true;
            this.ListBoxMarquee.ItemHeight = 16;
            this.ListBoxMarquee.Location = new System.Drawing.Point(14, 30);
            this.ListBoxMarquee.Name = "ListBoxMarquee";
            this.ListBoxMarquee.Size = new System.Drawing.Size(240, 276);
            this.ListBoxMarquee.TabIndex = 0;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(706, 336);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(172, 40);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Hentikan";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.HapusBtn);
            this.GroupBox1.Controls.Add(this.EditBtn);
            this.GroupBox1.Controls.Add(this.TambahBtn);
            this.GroupBox1.Controls.Add(this.ListBoxMarquee);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(392, 318);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Teks Berjalan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MinimizeValidation);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PictureDuration);
            this.groupBox3.Controls.Add(this.TextDuration);
            this.groupBox3.Controls.Add(this.Label1);
            this.groupBox3.Controls.Add(this.FontSize);
            this.groupBox3.Location = new System.Drawing.Point(857, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 318);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pengaturan";
            // 
            // MinimizeValidation
            // 
            this.MinimizeValidation.Location = new System.Drawing.Point(9, 114);
            this.MinimizeValidation.Name = "MinimizeValidation";
            this.MinimizeValidation.Size = new System.Drawing.Size(185, 76);
            this.MinimizeValidation.TabIndex = 3;
            this.MinimizeValidation.Text = "Buat aplikasi sembunyi di dalam System Tray ketika aplikasi sedang dijalankan.";
            this.MinimizeValidation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Durasi Teks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Durasi Foto";
            // 
            // PictureDuration
            // 
            this.PictureDuration.Location = new System.Drawing.Point(110, 86);
            this.PictureDuration.Name = "PictureDuration";
            this.PictureDuration.Size = new System.Drawing.Size(84, 22);
            this.PictureDuration.TabIndex = 4;
            this.PictureDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // TextDuration
            // 
            this.TextDuration.Location = new System.Drawing.Point(110, 58);
            this.TextDuration.Name = "TextDuration";
            this.TextDuration.Size = new System.Drawing.Size(84, 22);
            this.TextDuration.TabIndex = 3;
            this.TextDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 17);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Ukuran Font";
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(110, 30);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(84, 22);
            this.FontSize.TabIndex = 2;
            this.FontSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.ExecutionButton);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Addon.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NotifyIcon NotifyIcon;
        internal System.Windows.Forms.Label DebugLabel;
        internal System.Windows.Forms.Label CopyrightLabel;
        internal System.Windows.Forms.Button ExecutionButton;
        internal System.Windows.Forms.Label PageJustice;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TabControl TabControl;
        internal System.Windows.Forms.TabPage Addon;
        internal System.Windows.Forms.Button HapusBtn;
        internal System.Windows.Forms.Button EditBtn;
        internal System.Windows.Forms.Button TambahBtn;
        internal System.Windows.Forms.ListBox ListBoxMarquee;
        internal System.Windows.Forms.Button StopButton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox MinimizeValidation;
        private System.Windows.Forms.Button AddPicture;
        private System.Windows.Forms.Button AddText;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown FontSize;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown PictureDuration;
        internal System.Windows.Forms.NumericUpDown TextDuration;
    }
}

