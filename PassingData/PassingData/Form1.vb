Imports System.Threading

Public Class Form1
    Private _Worker As Thread
    Private Delegate Sub updateDelegate(ByVal s As String)
    Private Sub updateStatus(ByVal s As String)
        Label1.Text = s
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If _Worker Is Nothing Then
            _Worker = New Thread(AddressOf WorkerMain)
            _Worker.Start()
        End If


    End Sub
    Private Sub WorkerMain()
        Dim x As Integer = 0
        Do
            x += 1
            Dim msg As String = String.Format("Hello {0}", x)
            Dim del As updateDelegate = AddressOf updateStatus
            Me.Invoke(del, msg)
            Thread.Sleep(500)

        Loop While x < 30
        _Worker = Nothing
    End Sub
End Class
