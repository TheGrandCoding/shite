Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Arrow0.Hide()
        Arrow25.Hide()
        Arrow125.Hide()
        Arrow75.Hide()
        Arrow150.Hide()

        If MaleTest.Score > 0 Then
            TXTSHITEscore.Text = (MaleTest.Score)
            Arrow0.Visible = MaleTest.Score > 0 And MaleTest.Score < 25
            Arrow25.Visible = MaleTest.Score > 25 And MaleTest.Score < 75
            Arrow75.Visible = MaleTest.Score > 75 And MaleTest.Score < 125
            Arrow125.Visible = MaleTest.Score > 125 And MaleTest.Score < 149
            Arrow150.Visible = MaleTest.Score > 149
        End If
        If FemaleTest.Score < 0 Then
                TXTSHITEscore.Text = "youre gay"
                If FemaleTest.Score < 25 Then
                    Arrow0.Show()
                ElseIf FemaleTest.Score > 25 And FemaleTest.Score < 75 Then
                    Arrow25.Show()
                ElseIf FemaleTest.Score > 75 And FemaleTest.Score < 125 Then
                    Arrow75.Show()
                ElseIf FemaleTest.Score > 125 And FemaleTest.Score < 149 Then
                    Arrow125.Show()
                ElseIf FemaleTest.Score = 150 Then
                    Arrow150.Show()
                Else
                    MsgBox("Error finding correct arrow")
                    SHITEmenu.Show()
                    Me.Close()
                End If
            Else

            End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Arrow150.Click

    End Sub

    Private Sub TXTSHITEscore_Click(sender As Object, e As EventArgs) Handles TXTSHITEscore.Click
        If MaleTest.Score < 0 Then
            TXTSHITEscore.Text = (MaleTest.Score)
        ElseIf FemaleTest.Score < 0 Then
            TXTSHITEscore.Text = (FemaleTest.Score)
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub CmdBackToMain_Click(sender As Object, e As EventArgs) Handles CmdBackToMain.Click
        Me.Hide()
        SHITEmenu.Show()
    End Sub
End Class
