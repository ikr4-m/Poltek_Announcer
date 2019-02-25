Public Class AddListBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox.Text = "" Then
            MessageBox.Show("Anda belum memasukkan kata sedikitpun.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox.Text = ""
        Else
            With Launcher
                .ListBoxMarquee.Items.Add(TextBox.Text)

                Me.Close()
            End With
        End If
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Button2.PerformClick()
        End If
    End Sub
End Class