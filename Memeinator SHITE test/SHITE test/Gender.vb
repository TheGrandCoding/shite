Imports System.Data.SqlClient
Public Class Gender
    Private Sub CMDfemale_Click(sender As Object, e As EventArgs) Handles CMDfemale.Click
        TestForm.IS_MALE = False
        TestForm.Show()
        Me.Hide()
    End Sub

    Private Sub CMDmale_Click(sender As Object, e As EventArgs) Handles CMDmale.Click
        TestForm.IS_MALE = True
        TestForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SHITEmenu.Show()
        Me.Close()
    End Sub

    Private Sub Gender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub
End Class