Imports System.ComponentModel

Public Class Viewers
    Dim DateModified As New MonthPurposes
    Dim Resizer As New Resizer
    Dim Pad As New PadStart

    Private Sub LiveClock_Tick(sender As Object, e As EventArgs) Handles LiveClock.Tick
        Dim Day As String = Pad.Pad(Now.Day)
        Dim Hour As String = Pad.Pad(Now.Hour)
        Dim Minute As String = Pad.Pad(Now.Minute)
        Dim Second As String = Pad.Pad(Now.Second)

        TimeSetting.Text = DateModified.FetchDay() + ", " + Day + " " + DateModified.FetchMonth() +
            " " + Now.Year.ToString() + vbNewLine + Hour + ":" + Minute + ":" +
            Second
    End Sub

    Private Sub Viewers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resizer.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Viewers_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Resizer.ResizeAllControls(Me)
    End Sub

    Private Sub MarqueeTimer_Tick(sender As Object, e As EventArgs) Handles MarqueeTimer.Tick
        MarqueeText.Left = MarqueeText.Left - 1
        If MarqueeText.Left < 0 - MarqueeText.Width Then
            MarqueeText.Left = Me.Width
        End If
    End Sub

    Private Sub KedipanBanner_Tick(sender As Object, e As EventArgs) Handles KedipanBanner.Tick
        If TitleLabel.ForeColor = SystemColors.ActiveCaptionText Then
            TitleLabel.ForeColor = SystemColors.ButtonFace
        Else
            TitleLabel.ForeColor = SystemColors.ActiveCaptionText
        End If
    End Sub

    Dim Page As Integer = 1
    Private Sub Slideshow_Tick(sender As Object, e As EventArgs) Handles Slideshow.Tick
        Dim Isi As Label = ContainerLabel
        Dim MaxPage As Integer = Integer.Parse(Launcher.PageJustice.Text)
        Page += 1

        If Page > MaxPage Then
            Page = 1
        End If

        With Launcher
            If Page = 1 Then
                Isi.Text = .TextBoxPengumuman1.Text
            ElseIf Page = 2 Then
                Isi.Text = .TextBoxPengumuman2.Text
            ElseIf Page = 3 Then
                Isi.Text = .TextBoxPengumuman3.Text
            End If
        End With
    End Sub
End Class