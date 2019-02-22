Imports System.IO

Public Class MonitorChanger
    Dim Proc As New Process
    Dim Location As String = Application.StartupPath
    Dim X64 As String = "dc2.exe"
    Dim X86 As String = "dc2x86.exe"

    Public Enum Mode
        Clone
        Extend
        Primary
        Secondary
    End Enum

    Public Sub Change(Modee As Mode)
        Dim Loc As String
        If Environment.Is64BitOperatingSystem Then
            Loc = X64
        Else
            Loc = X86
        End If

        Proc.StartInfo.FileName = Path.Combine(Location, Loc)

        Select Case Modee
            Case Mode.Clone
                Proc.StartInfo.Arguments = "-clone"
                Exit Select
            Case Mode.Extend
                Proc.StartInfo.Arguments = "-extend"
                Exit Select
            Case Mode.Primary
                Proc.StartInfo.Arguments = "-primary"
                Exit Select
            Case Mode.Secondary
                Proc.StartInfo.Arguments = "-secondary"
                Exit Select
        End Select

        Proc.Start()
        Proc.WaitForExit()
    End Sub
End Class
