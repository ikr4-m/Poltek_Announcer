Public Class MonthPurposes
    Public Function FetchDay() As String
        Dim Resources As String = ""
        Select Case Now.DayOfWeek
            Case 0
                Resources = "Ahad"
            Case 1
                Resources = "Senin"
            Case 2
                Resources = "Selasa"
            Case 3
                Resources = "Rabu"
            Case 4
                Resources = "Kamis"
            Case 5
                Resources = "Jum'at"
            Case 6
                Resources = "Sabtu"
        End Select
        Return Resources
    End Function

    Public Function FetchMonth() As String
        Dim Resources As String = ""
        Select Case Now.Month
            Case 1
                Resources = "Januari"
            Case 2
                Resources = "Februari"
            Case 3
                Resources = "Maret"
            Case 4
                Resources = "April"
            Case 5
                Resources = "Mei"
            Case 6
                Resources = "Juni"
            Case 7
                Resources = "Juli"
            Case 8
                Resources = "Agustus"
            Case 9
                Resources = "September"
            Case 10
                Resources = "Oktober"
            Case 11
                Resources = "November"
            Case 12
                Resources = "Desember"
        End Select
        Return Resources
    End Function
End Class
