Public Class CheckBoxPair
    Public Yes As CheckBox
    Public No As CheckBox
    Public Number As Integer
    Public Sub New(_yes As CheckBox, _no As CheckBox)
        Yes = _yes
        No = _no
        Dim name = If(_yes, _no).Name.Replace("CBQ", "").Replace("yes", "").Replace("no", "")
        If Integer.TryParse(name, Number) Then
        Else

        End If
    End Sub
End Class
