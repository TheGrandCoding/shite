Public Class MaleTest
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Public CHECKBOXES As New Dictionary(Of Integer, CheckBoxPair)

    Public SCORES As New Dictionary(Of Integer, Tuple(Of Boolean, Integer)) From
    {
        {1, New Tuple(Of Boolean, Integer)(True, 10)},
        {2, New Tuple(Of Boolean, Integer)(True, 20)},
        {3, New Tuple(Of Boolean, Integer)(True, 20)},
        {4, New Tuple(Of Boolean, Integer)(False, 5)},
        {5, New Tuple(Of Boolean, Integer)(False, 20)},
        {6, New Tuple(Of Boolean, Integer)(True, 5)},
        {7, New Tuple(Of Boolean, Integer)(False, 5)},
        {8, New Tuple(Of Boolean, Integer)(True, 5)},
        {9, New Tuple(Of Boolean, Integer)(False, 5)},
        {10, New Tuple(Of Boolean, Integer)(True, 15)},
        {11, New Tuple(Of Boolean, Integer)(False, 5)},
        {12, New Tuple(Of Boolean, Integer)(True, 5)},
        {13, New Tuple(Of Boolean, Integer)(False, 10)},
        {14, New Tuple(Of Boolean, Integer)(True, 10)},
        {15, New Tuple(Of Boolean, Integer)(True, 10)}
    }

    Public Function GetQNumber(cb As CheckBox) As Integer
        Return Integer.Parse(cb.Name.Replace("CBQ", "").Replace("yes", "").Replace("no", ""))
    End Function

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Dim confirm As String
        confirm = MsgBox("Are you sure you want to cancel the SHITE test?", vbYesNo)
        If Confirm = vbYes Then
            Me.Close()
            SHITEmenu.Show()
        End If
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control In Me.Controls
            If TypeOf control Is CheckBox Then
                Dim cb = DirectCast(control, CheckBox)
                AddHandler cb.CheckedChanged, AddressOf CB_CheckedChanged
                Dim cbPair As CheckBoxPair = Nothing
                If CHECKBOXES.TryGetValue(GetQNumber(cb), cbPair) Then
                    cbPair.Number = GetQNumber(cb)
                    If cb.Name.Contains("yes") Then
                        cbPair.Yes = cb
                    Else
                        cbPair.No = cb
                    End If
                Else
                    If cb.Name.Contains("yes") Then
                        cbPair = New CheckBoxPair(cb, Nothing)
                    Else
                        cbPair = New CheckBoxPair(Nothing, cb)
                    End If
                    cbPair.Number = GetQNumber(cb)
                    CHECKBOXES.Add(GetQNumber(cb), cbPair)
                End If
            End If
        Next
    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs)
        Dim number = GetQNumber(sender)
        Dim cbPair = CHECKBOXES(number)
        Dim cb = DirectCast(sender, CheckBox)
        If Not cb.Checked Then
            Return
        End If
        If cbPair.Yes Is sender Then
            cbPair.No.Checked = Not cbPair.Yes.Checked
        Else
            cbPair.Yes.Checked = Not cbPair.No.Checked
        End If
    End Sub

    Public Score As Integer = 0

    Private Sub CmdCheck_Click_1(sender As Object, e As EventArgs) Handles CmdCheck.Click
        Score = 0
        For Each cbPair In CHECKBOXES.Values
            Dim cb = cbPair.Yes
            Dim tuple = SCORES(cbPair.Number)
            If Not (cbPair.No.Checked Or cbPair.Yes.Checked) Then
                MsgBox("You failed to answer question " + cbPair.Number.ToString())
                Return
            End If
            If tuple.Item1 = cb.Checked Then
                Score += tuple.Item2
            End If
        Next

        SHITEmenu.LBLScored.Text = "
Your previous 
score in
the SHITE
test was:
" & Score
        Results.Show()
        Me.Hide()
    End Sub
End Class