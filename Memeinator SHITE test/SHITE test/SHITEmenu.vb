Public Class SHITEmenu
    Public variable_1 As String
    Private Sub cmdWaht_Click(sender As Object, e As EventArgs) Handles cmdWaht.Click
        Waht_is_it.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdCan.Click
        Dim Quitter As String
        Quitter = MsgBox("Are you sure that you don't want to take the SHITE test, you can come back and do it at anytime", vbYesNo)
        If Quitter = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdTakeIt_Click(sender As Object, e As EventArgs) Handles cmdTakeIt.Click
        Gender.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LBLScored.Click
        If FemaleTest.Score > 0 Then
            LBLScored.Text = "Your previous score in the SHITE test was: " & FemaleTest.Score
        End If
    End Sub

    Private Sub SHITEmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
