<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewers))
        Me.LiveClock = New System.Windows.Forms.Timer(Me.components)
        Me.TimeSetting = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MarqueeText = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.MarqueeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ContainerLabel = New System.Windows.Forms.Label()
        Me.KedipanBanner = New System.Windows.Forms.Timer(Me.components)
        Me.Slideshow = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LiveClock
        '
        Me.LiveClock.Enabled = True
        '
        'TimeSetting
        '
        Me.TimeSetting.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TimeSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TimeSetting.Location = New System.Drawing.Point(0, -6)
        Me.TimeSetting.Name = "TimeSetting"
        Me.TimeSetting.Size = New System.Drawing.Size(213, 89)
        Me.TimeSetting.TabIndex = 0
        Me.TimeSetting.Text = "<Clock>"
        Me.TimeSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TimeSetting)
        Me.GroupBox1.Controls.Add(Me.MarqueeText)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 481)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'MarqueeText
        '
        Me.MarqueeText.AutoSize = True
        Me.MarqueeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarqueeText.Location = New System.Drawing.Point(681, 17)
        Me.MarqueeText.Name = "MarqueeText"
        Me.MarqueeText.Size = New System.Drawing.Size(209, 69)
        Me.MarqueeText.TabIndex = 1
        Me.MarqueeText.Text = "Label1"
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(875, 97)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "PENGUMUMAN"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MarqueeTimer
        '
        Me.MarqueeTimer.Enabled = True
        Me.MarqueeTimer.Interval = 1
        '
        'ContainerLabel
        '
        Me.ContainerLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerLabel.Location = New System.Drawing.Point(0, 97)
        Me.ContainerLabel.Name = "ContainerLabel"
        Me.ContainerLabel.Size = New System.Drawing.Size(875, 384)
        Me.ContainerLabel.TabIndex = 3
        Me.ContainerLabel.Text = "<Inputan Here>"
        Me.ContainerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KedipanBanner
        '
        Me.KedipanBanner.Enabled = True
        Me.KedipanBanner.Interval = 690
        '
        'Slideshow
        '
        Me.Slideshow.Enabled = True
        Me.Slideshow.Interval = 10000
        '
        'Viewers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 554)
        Me.Controls.Add(Me.ContainerLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Viewers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viewers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LiveClock As Timer
    Friend WithEvents TimeSetting As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents MarqueeTimer As Timer
    Friend WithEvents MarqueeText As Label
    Friend WithEvents ContainerLabel As Label
    Friend WithEvents KedipanBanner As Timer
    Friend WithEvents Slideshow As Timer
End Class
