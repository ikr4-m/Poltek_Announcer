Imports System.ComponentModel
Imports System.IO

Public Class Launcher
    Private Shared ReadOnly Location As String = Application.StartupPath
    Dim Reader As New ReaderDatabase

    Dim MarqueeLocation As String = Path.Combine(Location, "marquee.endb")
    Dim Pengumuman1Location As String = Path.Combine(Location, "announce1.endb")
    Dim Pengumuman2Location As String = Path.Combine(Location, "announce2.endb")
    Dim Pengumuman3Location As String = Path.Combine(Location, "announce3.endb")
    Dim Fonto As String = Path.Combine(Location, "fonto.endb")
    Dim Active As Boolean = False

    Public Shared StartUpError As Boolean
    Public Shared StartUpArgument As Boolean

    Private Sub TambahBtn_Click(sender As Object, e As EventArgs) Handles TambahBtn.Click
        AddListBox.Show()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If ListBoxMarquee.SelectedItem = "" Then
            MessageBox.Show("Anda tidak memilih item apapun.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            EditListBox.Show()
        End If
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        If ListBoxMarquee.SelectedItem = "" Then
            MessageBox.Show("Anda tidak memilih item apapun.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dialogResult As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus item tersebut?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                Dim index As Integer = ListBoxMarquee.SelectedIndex
                ListBoxMarquee.Items.RemoveAt(index)
                MessageBox.Show("Telah berhasil menghapus teks!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data
        Try
            Dim ListBoxPrepare As String() = Reader.ReadAllLine(MarqueeLocation)
            Dim Pengumuman1 As String = Reader.ReadAllText(Pengumuman1Location)
            Dim Pengumuman2 As String = Reader.ReadAllText(Pengumuman2Location)
            Dim Pengumuman3 As String = Reader.ReadAllText(Pengumuman3Location)
            Dim Fontoo As Integer = Reader.ReadAllText(Fonto)

            ListBoxMarquee.Items.AddRange(ListBoxPrepare)
            TextBoxPengumuman1.Text = Pengumuman1
            TextBoxPengumuman2.Text = Pengumuman2
            TextBoxPengumuman3.Text = Pengumuman3
            FontSize.Value = Fontoo

            CekTextBox(CheckBox1, TextBoxPengumuman1)
            CekTextBox(CheckBox2, TextBoxPengumuman2)
            CekTextBox(CheckBox3, TextBoxPengumuman3)
        Catch ex As FileNotFoundException
            MessageBox.Show("Ada file yang hilang! Tolong hubungi admin dengan menampilkan kode error tersebut:" + vbNewLine +
                            "FATAL: .ENDB was missing. (0x00000001)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End Try
        'Tanya lokasi Startup
        Dim StartupLocation As String = Path.Combine(Location, "Startup.exe")
        If File.Exists(StartupLocation) = False Then
            MessageBox.Show("Ada file yang hilang! Tolong hubungi admin dengan menampilkan kode error tersebut:" + vbNewLine +
                            "FATAL: Startup was missing. (0x00000001)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If

        'Copyright
        CopyrightLabel.Text = "(C) 2019-" + DateTime.Now.Year.ToString() + " UPT Komputer dan Sistem Informasi. All rights reserved."

        'Debug
        DebugLabelExtend("Siap beroprasi!")

        'Stop
        StopButton.Visible = False
        PageJustice.Visible = False

        'Tanya startup
        Dim StartupLoc As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\Poltek_Announcer.lnk"
        If File.Exists(StartupLoc) = False Then
            Dim dialogResult As DialogResult = MessageBox.Show("Startup belum terpasang di komputer ini, apakah anda ingin memasangnya?" + vbNewLine +
                                                               "Keuntungannya adalah anda bisa menyalakan aplikasi ini secara otomatis ketika komputer anda menyala.",
                                                               "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                Process.Start(StartupLocation, "-startup-silent")
                MessageBox.Show("Startup telah dipasang!",
                    "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub PageJusticeHandler(Check As CheckBox, Box As TextBox)
        If Check.Checked = True Then
            PageJustice.Text += 1
            Box.Enabled = True
        Else
            PageJustice.Text -= 1
            Box.Enabled = False
            Box.Text = ""
        End If
    End Sub

    Private Sub CekTextBox(Check As CheckBox, Box As TextBox)
        If Box.Text = "" Then
            Box.Enabled = False
        Else
            Check.Checked = True
        End If
    End Sub

    Private Sub ExecutionButton_Click(sender As Object, e As EventArgs) Handles ExecutionButton.Click
        ' Return Statement
        If TextBoxPengumuman1.Text = "" And ListBoxMarquee.Items.Count = 0 Then
            MessageBox.Show("Sayangnya, masih ada data yang kosong. Silahkan periksa dan jalankan kembali",
                "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Ngitung Monitor
            Dim JumlahMonitor As Integer = SystemInformation.MonitorCount
            If JumlahMonitor > 1 Then
                If ExecutionButton.Text = "Update" Then
                    DebugLabelExtend("Berhasil mengupdate data!")
                    CommitData()
                Else
                    Pindah()
                End If
            Else
                If StartUpArgument = True Then
                    StartUpError = True
                End If
                MsgBox("Sayangnya, monitor tidak terdeteksi. Silahkan ubah ke mode Extended, bukan mode Duplicate" _
                    , MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            End If
        End If
    End Sub

    Private Sub CommitData()
        With Viewers
            ' Marquee Text
            Dim ListMarquee(ListBoxMarquee.Items.Count - 1) As String
            ListBoxMarquee.Items.CopyTo(ListMarquee, 0)
            .MarqueeText.Text = String.Join("  |  ", ListMarquee).Replace("&", "&&")

            ' Textbox
            .ContainerLabel.Text = TextBoxPengumuman1.Text

            ' Font
            .ContainerLabel.Font = New Font(.ContainerLabel.Font.SystemFontName, Integer.Parse(FontSize.Value), FontStyle.Regular)

            Active = True
        End With
    End Sub

    Private Sub Pindah()
        ' Para pemindah monitor
        Dim screen As Screen = Screen.AllScreens(1)
        Viewers.StartPosition = FormStartPosition.Manual
        Viewers.Location = screen.Bounds.Location + New Point(100, 100)
        Viewers.Show()

        ' Mencari resolusi monitor
        Dim X_1 As Integer = Screen.AllScreens(1).Bounds.Width
        Dim Y_1 As Integer = Screen.AllScreens(1).Bounds.Height
        Dim XY_1 As String = X_1.ToString() + "x" + Y_1.ToString()

        ExecutionButton.Text = "Update"
        DebugLabelExtend("Berpindah ke monitor sebelah dengan resolusi " + XY_1)
        CommitData()
        StopButton.Visible = True
    End Sub

    Public Sub DebugLabelExtend(Information As String)
        DebugLabel.Text = "Info: " + Information
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StartUpError = False
        StartUpArgument = False

        Active = False
        ExecutionButton.Text = "Jalankan"
        Viewers.Close()
        StopButton.Visible = False
        DebugLabelExtend("Aplikasi berhasil dihentikan!")
    End Sub

    Private Sub Launcher_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Untuk list box
        Dim _ListBoxItem(ListBoxMarquee.Items.Count) As String
        ListBoxMarquee.Items.CopyTo(_ListBoxItem, 0)
        Dim ListBoxItem As String = String.Join(vbNewLine, _ListBoxItem)

        ' Untuk text box
        Dim TextBoxIsi1 As String = TextBoxPengumuman1.Text
        Dim TextBoxIsi2 As String = TextBoxPengumuman2.Text
        Dim TextBoxIsi3 As String = TextBoxPengumuman3.Text

        ' Tulis data
        Reader.WriteAllText(MarqueeLocation, ListBoxItem)
        Reader.WriteAllText(Pengumuman1Location, TextBoxIsi1)
        Reader.WriteAllText(Pengumuman2Location, TextBoxIsi2)
        Reader.WriteAllText(Pengumuman3Location, TextBoxIsi3)
    End Sub

    Private Sub FontSize_ValueChanged(sender As Object, e As EventArgs) Handles FontSize.ValueChanged
        If Active = True Then
            Viewers.ContainerLabel.Font = New Font(Viewers.ContainerLabel.Font.SystemFontName, Integer.Parse(FontSize.Value), FontStyle.Regular)
        End If
    End Sub

    Private Sub ListBoxMarquee_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBoxMarquee.KeyDown
        If e.KeyValue = Keys.Delete Then
            HapusBtn.PerformClick()
        ElseIf e.KeyValue = Keys.Enter Then
            EditListBox.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PageJusticeHandler(CheckBox1, TextBoxPengumuman1)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        PageJusticeHandler(CheckBox2, TextBoxPengumuman2)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        PageJusticeHandler(CheckBox3, TextBoxPengumuman3)
    End Sub
End Class