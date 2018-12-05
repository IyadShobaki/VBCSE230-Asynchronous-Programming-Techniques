<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnMsgbox = New System.Windows.Forms.Button()
        Me.btnWithoutBW = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCheckBW = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(84, 48)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(188, 84)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'btnMsgbox
        '
        Me.btnMsgbox.Location = New System.Drawing.Point(313, 48)
        Me.btnMsgbox.Name = "btnMsgbox"
        Me.btnMsgbox.Size = New System.Drawing.Size(188, 84)
        Me.btnMsgbox.TabIndex = 1
        Me.btnMsgbox.Text = "MessageBox"
        Me.btnMsgbox.UseVisualStyleBackColor = True
        '
        'btnWithoutBW
        '
        Me.btnWithoutBW.Location = New System.Drawing.Point(84, 168)
        Me.btnWithoutBW.Name = "btnWithoutBW"
        Me.btnWithoutBW.Size = New System.Drawing.Size(188, 84)
        Me.btnWithoutBW.TabIndex = 2
        Me.btnWithoutBW.Text = "Without BW"
        Me.btnWithoutBW.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(530, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(313, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(188, 84)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCheckBW
        '
        Me.btnCheckBW.Location = New System.Drawing.Point(313, 264)
        Me.btnCheckBW.Name = "btnCheckBW"
        Me.btnCheckBW.Size = New System.Drawing.Size(188, 84)
        Me.btnCheckBW.TabIndex = 5
        Me.btnCheckBW.Text = "Check"
        Me.btnCheckBW.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 376)
        Me.ProgressBar1.Maximum = 500000000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(767, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnCheckBW)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWithoutBW)
        Me.Controls.Add(Me.btnMsgbox)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnMsgbox As Button
    Friend WithEvents btnWithoutBW As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCheckBW As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
