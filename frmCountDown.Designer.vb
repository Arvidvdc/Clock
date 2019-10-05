<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCountDown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.CounterPopUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CounterPopUpHerstart = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterPopUpAfsluiten = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterPopUpOpenenClock = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterPopUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrCountdown
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Label1"
        '
        'CounterPopUp
        '
        Me.CounterPopUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CounterPopUpHerstart, Me.CounterPopUpAfsluiten, Me.CounterPopUpOpenenClock})
        Me.CounterPopUp.Name = "CounterPopUp"
        Me.CounterPopUp.Size = New System.Drawing.Size(163, 70)
        '
        'CounterPopUpHerstart
        '
        Me.CounterPopUpHerstart.Name = "CounterPopUpHerstart"
        Me.CounterPopUpHerstart.Size = New System.Drawing.Size(162, 22)
        Me.CounterPopUpHerstart.Text = "Teller Herstarten"
        '
        'CounterPopUpAfsluiten
        '
        Me.CounterPopUpAfsluiten.Name = "CounterPopUpAfsluiten"
        Me.CounterPopUpAfsluiten.Size = New System.Drawing.Size(162, 22)
        Me.CounterPopUpAfsluiten.Text = "Teller Afsluiten"
        '
        'CounterPopUpOpenenClock
        '
        Me.CounterPopUpOpenenClock.Enabled = False
        Me.CounterPopUpOpenenClock.Name = "CounterPopUpOpenenClock"
        Me.CounterPopUpOpenenClock.Size = New System.Drawing.Size(162, 22)
        Me.CounterPopUpOpenenClock.Text = "Clock Herstarten"
        '
        'frmCountDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 235)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCountDown"
        Me.Text = "frmCountDown"
        Me.TopMost = True
        Me.CounterPopUp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrCountdown As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents CounterPopUp As ContextMenuStrip
    Friend WithEvents CounterPopUpAfsluiten As ToolStripMenuItem
    Friend WithEvents CounterPopUpHerstart As ToolStripMenuItem
    Friend WithEvents CounterPopUpOpenenClock As ToolStripMenuItem
End Class
