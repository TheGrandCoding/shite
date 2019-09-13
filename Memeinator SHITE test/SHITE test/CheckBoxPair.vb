''' <summary>
''' Holds some information in regards to each individual question.
''' Holds the yes/no <see cref="CheckBox"/> and the question number as well
''' </summary>
Public Class CheckBoxPair
    Public Yes As CheckBox
    Public No As CheckBox
    Public Number As Integer
    Public Sub New(_yes As CheckBox, _no As CheckBox)
        Yes = _yes
        No = _no
        '''''''''''' V---------V this will return the '_yes' variable, but if that is null, will return the '_no' variable
        Dim name = If(_yes, _no).Name.Replace("CBQ", "").Replace("yes", "").Replace("no", "")
        If Integer.TryParse(name, Number) Then
        Else
            ' no number? oops
        End If
    End Sub
End Class
