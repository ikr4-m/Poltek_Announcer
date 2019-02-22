Public Class PadStart
    Public Function Pad(Number As Integer) As String
        Dim Resources As String = ""
        Dim NumberString As String = Number.ToString()
        If NumberString.Length = 1 Then
            Resources = "0" + NumberString
        Else
            Resources = NumberString
        End If
        Return Resources
    End Function
End Class
