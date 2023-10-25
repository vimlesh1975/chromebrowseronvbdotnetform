<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ChromiumWebBrowser1 = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdInvoke = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChromiumWebBrowser1
        '
        Me.ChromiumWebBrowser1.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser1.Location = New System.Drawing.Point(44, 32)
        Me.ChromiumWebBrowser1.Name = "ChromiumWebBrowser1"
        Me.ChromiumWebBrowser1.Size = New System.Drawing.Size(610, 523)
        Me.ChromiumWebBrowser1.TabIndex = 0
        '
        'cmdPlay
        '
        Me.cmdPlay.Location = New System.Drawing.Point(691, 110)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlay.TabIndex = 1
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(691, 168)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 3
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'cmdResume
        '
        Me.cmdResume.Location = New System.Drawing.Point(691, 197)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(75, 23)
        Me.cmdResume.TabIndex = 4
        Me.cmdResume.Text = "Resume"
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(691, 226)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 5
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdInvoke
        '
        Me.cmdInvoke.Location = New System.Drawing.Point(691, 265)
        Me.cmdInvoke.Name = "cmdInvoke"
        Me.cmdInvoke.Size = New System.Drawing.Size(75, 23)
        Me.cmdInvoke.TabIndex = 6
        Me.cmdInvoke.Text = "Invoke"
        Me.cmdInvoke.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(680, 294)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 7
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 717)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdInvoke)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.ChromiumWebBrowser1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChromiumWebBrowser1 As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents cmdPlay As Button
    Friend WithEvents cmdPause As Button
    Friend WithEvents cmdResume As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdInvoke As Button
    Friend WithEvents cmdStop As Button
End Class
