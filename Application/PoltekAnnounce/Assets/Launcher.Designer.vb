<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.TambahBtn = New System.Windows.Forms.Button()
        Me.ListBoxMarquee = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PageJustice = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxPengumuman1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBoxPengumuman2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBoxPengumuman3 = New System.Windows.Forms.TextBox()
        Me.FontSize = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExecutionButton = New System.Windows.Forms.Button()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.DebugLabel = New System.Windows.Forms.Label()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HapusBtn)
        Me.GroupBox1.Controls.Add(Me.EditBtn)
        Me.GroupBox1.Controls.Add(Me.TambahBtn)
        Me.GroupBox1.Controls.Add(Me.ListBoxMarquee)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teks Berjalan"
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(266, 114)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(114, 36)
        Me.HapusBtn.TabIndex = 3
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(266, 72)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(114, 36)
        Me.EditBtn.TabIndex = 2
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'TambahBtn
        '
        Me.TambahBtn.Location = New System.Drawing.Point(266, 30)
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(114, 36)
        Me.TambahBtn.TabIndex = 1
        Me.TambahBtn.Text = "Tambah"
        Me.TambahBtn.UseVisualStyleBackColor = True
        '
        'ListBoxMarquee
        '
        Me.ListBoxMarquee.FormattingEnabled = True
        Me.ListBoxMarquee.ItemHeight = 16
        Me.ListBoxMarquee.Location = New System.Drawing.Point(14, 30)
        Me.ListBoxMarquee.Name = "ListBoxMarquee"
        Me.ListBoxMarquee.Size = New System.Drawing.Size(240, 276)
        Me.ListBoxMarquee.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PageJustice)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.FontSize)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(409, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 318)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Isi Pengumuman"
        '
        'PageJustice
        '
        Me.PageJustice.AutoSize = True
        Me.PageJustice.Location = New System.Drawing.Point(309, 285)
        Me.PageJustice.Name = "PageJustice"
        Me.PageJustice.Size = New System.Drawing.Size(16, 17)
        Me.PageJustice.TabIndex = 4
        Me.PageJustice.Text = "0"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(497, 247)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.TextBoxPengumuman1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(489, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Halaman 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 21)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Nyalakan"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxPengumuman1
        '
        Me.TextBoxPengumuman1.Location = New System.Drawing.Point(6, 33)
        Me.TextBoxPengumuman1.Multiline = True
        Me.TextBoxPengumuman1.Name = "TextBoxPengumuman1"
        Me.TextBoxPengumuman1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxPengumuman1.Size = New System.Drawing.Size(477, 179)
        Me.TextBoxPengumuman1.TabIndex = 0
        Me.TextBoxPengumuman1.WordWrap = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.TextBoxPengumuman2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(489, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Halaman 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(89, 21)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Nyalakan"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBoxPengumuman2
        '
        Me.TextBoxPengumuman2.Location = New System.Drawing.Point(6, 33)
        Me.TextBoxPengumuman2.Multiline = True
        Me.TextBoxPengumuman2.Name = "TextBoxPengumuman2"
        Me.TextBoxPengumuman2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxPengumuman2.Size = New System.Drawing.Size(477, 179)
        Me.TextBoxPengumuman2.TabIndex = 1
        Me.TextBoxPengumuman2.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.TextBoxPengumuman3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(489, 218)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Halaman 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(89, 21)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Nyalakan"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBoxPengumuman3
        '
        Me.TextBoxPengumuman3.Location = New System.Drawing.Point(6, 33)
        Me.TextBoxPengumuman3.Multiline = True
        Me.TextBoxPengumuman3.Name = "TextBoxPengumuman3"
        Me.TextBoxPengumuman3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxPengumuman3.Size = New System.Drawing.Size(477, 179)
        Me.TextBoxPengumuman3.TabIndex = 1
        Me.TextBoxPengumuman3.WordWrap = False
        '
        'FontSize
        '
        Me.FontSize.Location = New System.Drawing.Point(121, 283)
        Me.FontSize.Name = "FontSize"
        Me.FontSize.Size = New System.Drawing.Size(136, 22)
        Me.FontSize.TabIndex = 2
        Me.FontSize.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ukuran Font"
        '
        'ExecutionButton
        '
        Me.ExecutionButton.Location = New System.Drawing.Point(804, 341)
        Me.ExecutionButton.Name = "ExecutionButton"
        Me.ExecutionButton.Size = New System.Drawing.Size(114, 36)
        Me.ExecutionButton.TabIndex = 4
        Me.ExecutionButton.Text = "Jalankan"
        Me.ExecutionButton.UseVisualStyleBackColor = True
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.Location = New System.Drawing.Point(12, 357)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(70, 17)
        Me.CopyrightLabel.TabIndex = 5
        Me.CopyrightLabel.Text = "<kopirek>"
        '
        'DebugLabel
        '
        Me.DebugLabel.AutoSize = True
        Me.DebugLabel.Location = New System.Drawing.Point(12, 335)
        Me.DebugLabel.Name = "DebugLabel"
        Me.DebugLabel.Size = New System.Drawing.Size(64, 17)
        Me.DebugLabel.TabIndex = 6
        Me.DebugLabel.Text = "<debug>"
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(684, 341)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(114, 36)
        Me.StopButton.TabIndex = 7
        Me.StopButton.Text = "Hentikan"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Text = "Aplikasi Pengumuman"
        Me.NotifyIcon.Visible = True
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(928, 384)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.DebugLabel)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.ExecutionButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Pengumuman | Launcher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.FontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HapusBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents TambahBtn As Button
    Friend WithEvents ListBoxMarquee As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxPengumuman1 As TextBox
    Friend WithEvents ExecutionButton As Button
    Friend WithEvents CopyrightLabel As Label
    Friend WithEvents DebugLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FontSize As NumericUpDown
    Friend WithEvents StopButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBoxPengumuman2 As TextBox
    Friend WithEvents TextBoxPengumuman3 As TextBox
    Friend WithEvents PageJustice As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
