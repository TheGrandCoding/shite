Public Class TestForm
    Public CHECKBOXES As New Dictionary(Of Integer, CheckBoxPair)

    Public IS_MALE As Boolean

    Public SCORES As New Dictionary(Of Integer, Tuple(Of Boolean, Integer)) From
    { ' Holds the scores for each checkbox. If value is True, adds the number on right if checkbox 'Yes' is ticked.
        {1, New Tuple(Of Boolean, Integer)(True, 10)}, ' If value is False, it only adds it if checkbox 'No' is ticked
        {2, New Tuple(Of Boolean, Integer)(True, 20)}, ' Technically, one could say 'True' then apply a negative number
        {3, New Tuple(Of Boolean, Integer)(True, 20)}, ' But why would you want to do that?
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

    Public MALE_QUESTIONS As New Dictionary(Of Integer, String) From
    {
        {1, "Do you use the dog filter on snapchat?"},
        {2, "Have you ever sent nudes to someone you're not dating?"},
        {3, "Do you feel entitled to things?"},
        {4, "Do you think you're like the average guy?"},
        {5, "Would or have you had sex for any reason other than love?"},
        {6, "Do you brag about having sex?"},
        {7, "Do you hang out with a big squad?"},
        {8, "Do you flirt with people for fun?"},
        {9, "Is your snapscore under 100k?"},
        {10, "Have you lost your virginity before 16?"},
        {11, "Do you only make out with your girlfriend?"},
        {12, "Do you think you're tough?"},
        {13, "Have yoy had less than 5 exs before 15?"},
        {14, "Are you hoes before bros?"},
        {15, "Have you dated someone twice or more after complaining about them"}
    }

    Public FEMALE_QUESTIONS As New Dictionary(Of Integer, String) From
    {
        {1, "Do you use the dog filter on snapchat?"},
        {2, "Have you ever sent nudes to someone you're not dating?"},
        {3, "Do you feel entitled to things?"},
        {4, "Do you cover unneeded amountss of 'skin'?"},
        {5, "Would or have you had sex for any reason other than love?"},
        {6, "Do you brag about having sex?"},
        {7, "Do you wear long clothes when it's cold?"},
        {8, "Do you flirt with people for fun?"},
        {9, "Is your snapscore under 100k?"},
        {10, "Have you lost your virginity before 16?"},
        {11, "Do you only make out with your boyfriend?"},
        {12, "Have you gone to victoria's secret?"},
        {13, "Have yoy had less than 5 exs before 15?"},
        {14, "Do you own a push-up bra?"},
        {15, "Have you dated someone twice or more after complaining about them"}
    }


    ''' <summary>
    ''' All checkboxes are named 'CBQ0-yes' or 'CBQ-no', where - is a number
    ''' So this function removes all other text, and returns just the number
    ''' </summary>
    ''' <param name="cb"></param>
    ''' <returns></returns>
    Public Function GetQNumber(cb As CheckBox) As Integer
        Return Integer.Parse(cb.Name.Replace("CBQ", "").Replace("yes", "").Replace("no", ""))
    End Function

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Dim confirm As String
        confirm = MsgBox("Are you sure you want to cancel the SHITE test?", vbYesNo)
        If confirm = vbYes Then
            Me.Close()
            SHITEmenu.Show()
        End If
    End Sub

    Private Function getQuestionLabel(number As Integer) As Label
        For Each control As Control In Me.Controls
            If TypeOf control Is Label AndAlso control.Name = "Label" + number.ToString() Then
                Return DirectCast(control, Label)
            End If
        Next
        Return Nothing
    End Function

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control In Me.Controls ' Controls = anything on the form, so buttons, labels, checkboxes etc.
            If TypeOf control Is CheckBox Then
                Dim cb = DirectCast(control, CheckBox) ' If control is a checkbox, then lets get a new variable of that type
                AddHandler cb.CheckedChanged, AddressOf CB_CheckedChanged ' All checkboxes will call just one function - less repitition
                Dim cbPair As CheckBoxPair = Nothing ' Intanstiate this as being empty/null
                If CHECKBOXES.TryGetValue(GetQNumber(cb), cbPair) Then
                    cbPair.Number = GetQNumber(cb)
                    ' Set values within the CheckBoxPair
                    If cb.Name.Contains("yes") Then
                        cbPair.Yes = cb
                    Else
                        cbPair.No = cb
                    End If
                Else
                    ' CheckBoxPair does not previously exist, so wew need to create it ...
                    If cb.Name.Contains("yes") Then
                        cbPair = New CheckBoxPair(cb, Nothing)
                    Else
                        cbPair = New CheckBoxPair(Nothing, cb)
                    End If
                    ' .. and then add the created item to the dictionary, for the next checkbox to add itself to
                    cbPair.Number = GetQNumber(cb)
                    CHECKBOXES.Add(GetQNumber(cb), cbPair)
                End If
                getQuestionLabel(cbPair.Number).Text = If(IS_MALE, MALE_QUESTIONS(cbPair.Number), FEMALE_QUESTIONS(cbPair.Number))
            End If
        Next
    End Sub

    ''' <summary>
    ''' This handles *all* checked events, finds the other pair (ie, yes/no) and ensures that only one is 'Checked'
    ''' </summary>
    ''' <param name="sender">The checkbox itself</param>
    ''' <param name="e">Something we don't care about</param>
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
        Score = 0 ' reset, so if they continue clicking it does nothing (if they can?)
        For Each cbPair In CHECKBOXES.Values
            ' Go through each pair of checkboxes (so: each question, yes/no)
            Dim cb = cbPair.Yes
            Dim tuple = SCORES(cbPair.Number)
            If Not (cbPair.No.Checked Or cbPair.Yes.Checked) Then
                MsgBox("You failed to answer question " + cbPair.Number.ToString())
                Return ' So if we get past this point, then all questions must be filled
            End If
            If tuple.Item1 = cb.Checked Then
                Score += tuple.Item2 ' Item2 refers to the number set above (at SCORES)
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