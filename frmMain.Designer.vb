<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.sgtTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.sgtPopUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.sgtPopUpBovenaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.sgtPopUpTransparant = New System.Windows.Forms.ToolStripMenuItem()
        Me.sgtPopUpBorderAan = New System.Windows.Forms.ToolStripMenuItem()
        Me.sgtPopUpAlarm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.sgtPopUpAftellen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.sgtPopUpConfiguratie = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.sgtPopUpAfsluiten = New System.Windows.Forms.ToolStripMenuItem()
        Me.sgtPopUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'sgtTimer
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(38, 18)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time"
        '
        'sgtPopUp
        '
        Me.sgtPopUp.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sgtPopUp.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.sgtPopUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sgtPopUpBovenaan, Me.sgtPopUpTransparant, Me.sgtPopUpBorderAan, Me.sgtPopUpAlarm, Me.ToolStripMenuItem3, Me.sgtPopUpAftellen, Me.ToolStripMenuItem2, Me.sgtPopUpConfiguratie, Me.ToolStripMenuItem1, Me.sgtPopUpAfsluiten})
        Me.sgtPopUp.Name = "sgtPopUp"
        Me.sgtPopUp.Size = New System.Drawing.Size(155, 198)
        '
        'sgtPopUpBovenaan
        '
        Me.sgtPopUpBovenaan.Name = "sgtPopUpBovenaan"
        Me.sgtPopUpBovenaan.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpBovenaan.Text = "Bovenaan"
        '
        'sgtPopUpTransparant
        '
        Me.sgtPopUpTransparant.Name = "sgtPopUpTransparant"
        Me.sgtPopUpTransparant.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpTransparant.Text = "Transparant"
        '
        'sgtPopUpBorderAan
        '
        Me.sgtPopUpBorderAan.Name = "sgtPopUpBorderAan"
        Me.sgtPopUpBorderAan.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpBorderAan.Text = "Border aan"
        '
        'sgtPopUpAlarm
        '
        Me.sgtPopUpAlarm.Name = "sgtPopUpAlarm"
        Me.sgtPopUpAlarm.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpAlarm.Text = "Alarm"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(151, 6)
        '
        'sgtPopUpAftellen
        '
        Me.sgtPopUpAftellen.Name = "sgtPopUpAftellen"
        Me.sgtPopUpAftellen.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpAftellen.Text = "Aftellen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(151, 6)
        '
        'sgtPopUpConfiguratie
        '
        Me.sgtPopUpConfiguratie.Name = "sgtPopUpConfiguratie"
        Me.sgtPopUpConfiguratie.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpConfiguratie.Text = "Configuratie"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 6)
        '
        'sgtPopUpAfsluiten
        '
        Me.sgtPopUpAfsluiten.Name = "sgtPopUpAfsluiten"
        Me.sgtPopUpAfsluiten.Size = New System.Drawing.Size(154, 22)
        Me.sgtPopUpAfsluiten.Text = "Afsluiten"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(317, 107)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.sgtPopUp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sgtTimer As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents sgtPopUp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents sgtPopUpConfiguratie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sgtPopUpAlarm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sgtPopUpAfsluiten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sgtPopUpBovenaan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sgtPopUpBorderAan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sgtPopUpTransparant As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents sgtPopUpAftellen As ToolStripMenuItem
End Class
