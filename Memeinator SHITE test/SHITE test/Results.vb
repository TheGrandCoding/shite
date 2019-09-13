Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Arrow0.Hide()
        Arrow25.Hide()
        Arrow125.Hide()
        Arrow75.Hide()
        Arrow150.Hide()

        If TestForm.Score > 0 Then
            TXTSHITEscore.Text = (TestForm.Score)
            Arrow0.Visible = TestForm.Score > 0 And TestForm.Score < 25
            Arrow25.Visible = TestForm.Score > 25 And TestForm.Score < 75
            Arrow75.Visible = TestForm.Score > 75 And TestForm.Score < 125
            Arrow125.Visible = TestForm.Score > 125 And TestForm.Score < 149
            Arrow150.Visible = TestForm.Score > 149
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Arrow150.Click

    End Sub

    Private Sub TXTSHITEscore_Click(sender As Object, e As EventArgs) Handles TXTSHITEscore.Click
        If TestForm.Score > 0 Then
            TXTSHITEscore.Text = (TestForm.Score)
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub CmdBackToMain_Click(sender As Object, e As EventArgs) Handles CmdBackToMain.Click
        Me.Hide()
        SHITEmenu.Show()
    End Sub
End Class
