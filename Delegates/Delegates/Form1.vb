Public Class Form1
    Public c As New myFunctions
    Public Delegate Sub myDel(s As String)
    Private Sub btnG1_Click(sender As Object, e As EventArgs) Handles btnG1.Click
        Dim del As New myDel(AddressOf c.GoodMorning)
        del.Invoke(TextBox1.Text)
    End Sub

    Private Sub btnG2_Click(sender As Object, e As EventArgs) Handles btnG2.Click
        Dim del As New myDel(AddressOf c.GoodNight)
        del.Invoke(TextBox1.Text)
    End Sub

End Class
