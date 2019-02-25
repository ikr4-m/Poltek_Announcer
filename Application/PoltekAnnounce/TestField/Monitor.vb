Public Class Monitor
    Dim Changer As New MonitorChanger

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Changer.Change(Changer.Mode.Extend)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Changer.Change(Changer.Mode.Primary)
    End Sub
End Class