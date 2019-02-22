Imports System.IO

Public Class ReaderDatabase
    Public Function ReadAllText(Path As String) As String
        Return File.ReadAllText(Path)
    End Function

    Public Function ReadAllLine(Path As String) As String()
        Return File.ReadAllLines(Path)
    End Function

    Public Sub WriteAllText(Path As String, Content As String)
        File.WriteAllText(Path, Content)
    End Sub

    Public Sub WritePerLine(Path As String, Content As String())
        File.WriteAllLines(Path, Content)
    End Sub
End Class
