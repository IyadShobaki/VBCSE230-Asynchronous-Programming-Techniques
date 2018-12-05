Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text
        RemoveHandler Button1.Click, AddressOf Button1_Click
        AddHandler Button1.Click, AddressOf myClick
    End Sub
    Private Sub myClick(sender As Object, e As EventArgs)
        Label1.Text = "Hello " & TextBox1.Text
        RemoveHandler Button1.Click, AddressOf myClick
        AddHandler Button1.Click, AddressOf Button1_Click
    End Sub
End Class
