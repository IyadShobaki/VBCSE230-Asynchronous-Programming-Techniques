Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For x = 1 To 50000
            ListBox1.Items.Add(x)
            Application.DoEvents()
        Next
    End Sub
End Class
