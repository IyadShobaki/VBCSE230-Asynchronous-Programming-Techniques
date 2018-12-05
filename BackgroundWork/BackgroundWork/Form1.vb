Imports System.ComponentModel

Public Class Form1
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim myParameter As String
        myParameter = CType(e.Argument, String)
        e.Result = myParameter
        'btnStart.Enabled = False

        For x = 1 To 500000000
            'Label1.Text = x
            'System.Threading.Thread.Sleep(100)
            ''Label1.Refresh()
            e.Result = x.ToString
            If x Mod 500000 = 0 Then
                BackgroundWorker1.ReportProgress(x)
            End If
            If BackgroundWorker1.CancellationPending Then
                e.Cancel = True
                Exit Sub
            End If
        Next


    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        BackgroundWorker1.RunWorkerAsync("My Message")

    End Sub

    Private Sub btnMsgbox_Click(sender As Object, e As EventArgs) Handles btnMsgbox.Click
        MessageBox.Show("Test")

    End Sub

    Private Sub btnWithoutBW_Click(sender As Object, e As EventArgs) Handles btnWithoutBW.Click
        For x = 1 To 500000000

        Next
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Background process completed")
            'btnStart.Enabled = True
        Else
            MessageBox.Show("Background process completed " + e.Result.ToString())
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub btnCheckBW_Click(sender As Object, e As EventArgs) Handles btnCheckBW.Click
        If BackgroundWorker1.IsBusy Then
            MessageBox.Show("BackgroundWorker is busy")
        Else
            MessageBox.Show("BackgroundWorker is ready")
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
End Class
