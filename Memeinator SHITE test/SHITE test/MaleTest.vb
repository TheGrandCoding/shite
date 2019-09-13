Public Class MaleTest
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Dim confirm As String
        confirm = MsgBox("Are you sure you want to cancel the SHITE test?", vbYesNo)
        If Confirm = vbYes Then
            Me.Close()
            SHITEmenu.Show()
        End If
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBQ1yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ1yes.CheckedChanged
        If CBQ1no.CheckState = CheckState.Checked Then
            CBQ1no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ1no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ1no.CheckedChanged
        If CBQ1yes.CheckState = CheckState.Checked Then
            CBQ1yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ2yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ2yes.CheckedChanged
        If CBQ2no.CheckState = CheckState.Checked Then
            CBQ2no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ2no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ2no.CheckedChanged
        If CBQ2yes.CheckState = CheckState.Checked Then
            CBQ2yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ3yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ3yes.CheckedChanged
        If CBQ3no.CheckState = CheckState.Checked Then
            CBQ3no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ3no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ3no.CheckedChanged
        If CBQ3yes.CheckState = CheckState.Checked Then
            CBQ3yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ4yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ4yes.CheckedChanged
        If CBQ4no.CheckState = CheckState.Checked Then
            CBQ4no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ4no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ4no.CheckedChanged
        If CBQ4yes.CheckState = CheckState.Checked Then
            CBQ4yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ5yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ5yes.CheckedChanged
        If CBQ5no.CheckState = CheckState.Checked Then
            CBQ5no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ5no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ5no.CheckedChanged
        If CBQ5yes.CheckState = CheckState.Checked Then
            CBQ5yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ6yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ6yes.CheckedChanged
        If CBQ6no.CheckState = CheckState.Checked Then
            CBQ6no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ6no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ6no.CheckedChanged
        If CBQ6yes.CheckState = CheckState.Checked Then
            CBQ6yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ7yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ7yes.CheckedChanged
        If CBQ7no.CheckState = CheckState.Checked Then
            CBQ7no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ7no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ7no.CheckedChanged
        If CBQ7yes.CheckState = CheckState.Checked Then
            CBQ7yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ8yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ8yes.CheckedChanged
        If CBQ8no.CheckState = CheckState.Checked Then
            CBQ8no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ8no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ8no.CheckedChanged
        If CBQ8yes.CheckState = CheckState.Checked Then
            CBQ8yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ9yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ9yes.CheckedChanged
        If CBQ9no.CheckState = CheckState.Checked Then
            CBQ9no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ9no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ9no.CheckedChanged
        If CBQ9yes.CheckState = CheckState.Checked Then
            CBQ9yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ10yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ10yes.CheckedChanged
        If CBQ10no.CheckState = CheckState.Checked Then
            CBQ10no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ10no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ10no.CheckedChanged
        If CBQ10yes.CheckState = CheckState.Checked Then
            CBQ10yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ11yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ11yes.CheckedChanged
        If CBQ11no.CheckState = CheckState.Checked Then
            CBQ11no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ11no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ11no.CheckedChanged
        If CBQ11yes.CheckState = CheckState.Checked Then
            CBQ11yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ12yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ12yes.CheckedChanged
        If CBQ12no.CheckState = CheckState.Checked Then
            CBQ12no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ12no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ12no.CheckedChanged
        If CBQ12yes.CheckState = CheckState.Checked Then
            CBQ12yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ13yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ13yes.CheckedChanged
        If CBQ13no.CheckState = CheckState.Checked Then
            CBQ13no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ13no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ13no.CheckedChanged
        If CBQ13yes.CheckState = CheckState.Checked Then
            CBQ13yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ14yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ14yes.CheckedChanged
        If CBQ14no.CheckState = CheckState.Checked Then
            CBQ14no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ14no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ14no.CheckedChanged
        If CBQ14yes.CheckState = CheckState.Checked Then
            CBQ14yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ15yes_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ15yes.CheckedChanged
        If CBQ15no.CheckState = CheckState.Checked Then
            CBQ15no.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CBQ15no_CheckedChanged(sender As Object, e As EventArgs) Handles CBQ15no.CheckedChanged
        If CBQ15yes.CheckState = CheckState.Checked Then
            CBQ15yes.CheckState = CheckState.Unchecked
        End If
    End Sub

    Public Score As Integer = 0

    Private Sub CmdCheck_Click_1(sender As Object, e As EventArgs) Handles CmdCheck.Click
        If CBQ1yes.CheckState = CheckState.Checked Then
            Score = Score + 10
        End If
        If CBQ2yes.CheckState = CheckState.Checked Then
            Score = Score + 20
        End If
        If CBQ3yes.CheckState = CheckState.Checked Then
            Score = Score = 20
        End If
        If CBQ4yes.CheckState = CheckState.Unchecked Then
            Score = Score = 5
        End If
        If CBQ5yes.CheckState = CheckState.Unchecked Then
            Score = Score = 20
        End If
        If CBQ6yes.CheckState = CheckState.Checked Then
            Score = Score = 5
        End If
        If CBQ7yes.CheckState = CheckState.Unchecked Then
            Score = Score = 5
        End If
        If CBQ8yes.CheckState = CheckState.Checked Then
            Score = Score = 5
        End If
        If CBQ9yes.CheckState = CheckState.Unchecked Then
            Score = Score = 5
        End If
        If CBQ10yes.CheckState = CheckState.Checked Then
            Score = Score = 15
        End If
        If CBQ11yes.CheckState = CheckState.Unchecked Then
            Score = Score = 5
        End If
        If CBQ12yes.CheckState = CheckState.Checked Then
            Score = Score = 5
        End If
        If CBQ13yes.CheckState = CheckState.Unchecked Then
            Score = Score + 10
        End If
        If CBQ14yes.CheckState = CheckState.Checked Then
            Score = Score + 10
        End If
        If CBQ15yes.CheckState = CheckState.Checked Then
            Score = Score + 10
        End If
        SHITEmenu.LBLScored.Text = "
Your previous 
score in
the SHITE
test was:
" & Score

        If Score > 0 Then
            If CBQ1yes.Checked Or CBQ1no.Checked Then
                If CBQ2yes.Checked Or CBQ2no.Checked Then
                    If CBQ3yes.Checked Or CBQ3no.Checked Then
                        If CBQ4yes.Checked Or CBQ4no.Checked Then
                            If CBQ5yes.Checked Or CBQ5no.Checked Then
                                If CBQ6yes.Checked Or CBQ6no.Checked Then
                                    If CBQ7yes.Checked Or CBQ7no.Checked Then
                                        If CBQ8yes.Checked Or CBQ8no.Checked Then
                                            If CBQ9yes.Checked Or CBQ9no.Checked Then
                                                If CBQ10yes.Checked Or CBQ10no.Checked Then
                                                    If CBQ11yes.Checked Or CBQ11no.Checked Then
                                                        If CBQ12yes.Checked Or CBQ12no.Checked Then
                                                            If CBQ13yes.Checked Or CBQ13no.Checked Then
                                                                If CBQ14yes.Checked Or CBQ14no.Checked Then
                                                                    If CBQ15yes.Checked Or CBQ15no.Checked Then
                                                                        Results.Show()
                                                                        Me.Hide()
                                                                    Else
                                                                        MsgBox("You didn't answer a question")
                                                                    End If
                                                                Else
                                                                    MsgBox("You didn't answer a question")
                                                                End If
                                                            Else
                                                                MsgBox("You didn't answer a question")
                                                            End If
                                                        Else
                                                            MsgBox("You didn't answer a question")
                                                        End If
                                                    Else
                                                        MsgBox("You didn't answer a question")
                                                    End If
                                                Else
                                                    MsgBox("You didn't answer a question")
                                                End If
                                            Else
                                                MsgBox("You didn't answer a question")
                                            End If
                                        Else
                                            MsgBox("You didn't answer a question")
                                        End If
                                    Else
                                        MsgBox("You didn't answer a question")
                                    End If
                                Else
                                    MsgBox("You didn't answer a question")
                                End If
                            Else
                                MsgBox("You didn't answer a question")
                            End If
                        Else
                            MsgBox("You didn't answer a question")
                        End If
                    Else
                        MsgBox("You didn't answer a question")
                    End If
                Else
                    MsgBox("You didn't answer a question")
                End If
            Else
                MsgBox("You didn't answer a question")
            End If
        Else
            MsgBox("You havent selected any boxes!")
        End If
    End Sub
End Class