<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfig
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
        Me.tabConfig = New System.Windows.Forms.TabControl()
        Me.pageClock = New System.Windows.Forms.TabPage()
        Me.cbTransparant = New System.Windows.Forms.CheckBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.gbVoorbeeld = New System.Windows.Forms.GroupBox()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.butBackColor = New System.Windows.Forms.Button()
        Me.butForeColor = New System.Windows.Forms.Button()
        Me.cbUnderlined = New System.Windows.Forms.CheckBox()
        Me.cbStrikeOut = New System.Windows.Forms.CheckBox()
        Me.cbItalic = New System.Windows.Forms.CheckBox()
        Me.cbBold = New System.Windows.Forms.CheckBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.pageCountDown = New System.Windows.Forms.TabPage()
        Me.lblResetCounterlocation = New System.Windows.Forms.Label()
        Me.lblCountDown1MinExample = New System.Windows.Forms.Label()
        Me.lblCountDown30SecExample = New System.Windows.Forms.Label()
        Me.lblCountDown30Sec = New System.Windows.Forms.Label()
        Me.lblCountDown1Min = New System.Windows.Forms.Label()
        Me.butCountDown30Sec = New System.Windows.Forms.Button()
        Me.butCountDown1Min = New System.Windows.Forms.Button()
        Me.cmbCountDownTimer = New System.Windows.Forms.ComboBox()
        Me.lblCountDownTimer = New System.Windows.Forms.Label()
        Me.butOkay = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.tabConfig.SuspendLayout()
        Me.pageClock.SuspendLayout()
        Me.gbVoorbeeld.SuspendLayout()
        Me.pageCountDown.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabConfig
        '
        Me.tabConfig.Controls.Add(Me.pageClock)
        Me.tabConfig.Controls.Add(Me.pageCountDown)
        Me.tabConfig.Location = New System.Drawing.Point(12, 12)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.SelectedIndex = 0
        Me.tabConfig.Size = New System.Drawing.Size(474, 285)
        Me.tabConfig.TabIndex = 21
        '
        'pageClock
        '
        Me.pageClock.Controls.Add(Me.cbTransparant)
        Me.pageClock.Controls.Add(Me.lblSize)
        Me.pageClock.Controls.Add(Me.lblName)
        Me.pageClock.Controls.Add(Me.gbVoorbeeld)
        Me.pageClock.Controls.Add(Me.butBackColor)
        Me.pageClock.Controls.Add(Me.butForeColor)
        Me.pageClock.Controls.Add(Me.cbUnderlined)
        Me.pageClock.Controls.Add(Me.cbStrikeOut)
        Me.pageClock.Controls.Add(Me.cbItalic)
        Me.pageClock.Controls.Add(Me.cbBold)
        Me.pageClock.Controls.Add(Me.cmbSize)
        Me.pageClock.Controls.Add(Me.cmbName)
        Me.pageClock.Location = New System.Drawing.Point(4, 27)
        Me.pageClock.Name = "pageClock"
        Me.pageClock.Padding = New System.Windows.Forms.Padding(3)
        Me.pageClock.Size = New System.Drawing.Size(466, 254)
        Me.pageClock.TabIndex = 0
        Me.pageClock.Text = "Clock"
        Me.pageClock.UseVisualStyleBackColor = True
        '
        'cbTransparant
        '
        Me.cbTransparant.AutoSize = True
        Me.cbTransparant.Location = New System.Drawing.Point(318, 102)
        Me.cbTransparant.Name = "cbTransparant"
        Me.cbTransparant.Size = New System.Drawing.Size(100, 22)
        Me.cbTransparant.TabIndex = 32
        Me.cbTransparant.Text = "Transparant"
        Me.cbTransparant.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(211, 10)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(58, 18)
        Me.lblSize.TabIndex = 31
        Me.lblSize.Text = "Grootte"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 18)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "Lettertype"
        '
        'gbVoorbeeld
        '
        Me.gbVoorbeeld.Controls.Add(Me.lblExample)
        Me.gbVoorbeeld.Location = New System.Drawing.Point(7, 144)
        Me.gbVoorbeeld.Name = "gbVoorbeeld"
        Me.gbVoorbeeld.Size = New System.Drawing.Size(305, 91)
        Me.gbVoorbeeld.TabIndex = 27
        Me.gbVoorbeeld.TabStop = False
        Me.gbVoorbeeld.Text = "Voorbeeld"
        '
        'lblExample
        '
        Me.lblExample.AutoSize = True
        Me.lblExample.Location = New System.Drawing.Point(6, 29)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(72, 18)
        Me.lblExample.TabIndex = 4
        Me.lblExample.Text = "Voorbeeld"
        '
        'butBackColor
        '
        Me.butBackColor.Location = New System.Drawing.Point(318, 68)
        Me.butBackColor.Name = "butBackColor"
        Me.butBackColor.Size = New System.Drawing.Size(140, 28)
        Me.butBackColor.TabIndex = 26
        Me.butBackColor.Text = "Achtergrond kleur"
        Me.butBackColor.UseVisualStyleBackColor = True
        '
        'butForeColor
        '
        Me.butForeColor.Location = New System.Drawing.Point(318, 34)
        Me.butForeColor.Name = "butForeColor"
        Me.butForeColor.Size = New System.Drawing.Size(140, 28)
        Me.butForeColor.TabIndex = 25
        Me.butForeColor.Text = "Voorgrond kleur"
        Me.butForeColor.UseVisualStyleBackColor = True
        '
        'cbUnderlined
        '
        Me.cbUnderlined.AutoSize = True
        Me.cbUnderlined.Location = New System.Drawing.Point(137, 100)
        Me.cbUnderlined.Name = "cbUnderlined"
        Me.cbUnderlined.Size = New System.Drawing.Size(114, 22)
        Me.cbUnderlined.TabIndex = 24
        Me.cbUnderlined.Text = "Onderstrepen"
        Me.cbUnderlined.UseVisualStyleBackColor = True
        '
        'cbStrikeOut
        '
        Me.cbStrikeOut.AutoSize = True
        Me.cbStrikeOut.Location = New System.Drawing.Point(10, 100)
        Me.cbStrikeOut.Name = "cbStrikeOut"
        Me.cbStrikeOut.Size = New System.Drawing.Size(106, 22)
        Me.cbStrikeOut.TabIndex = 23
        Me.cbStrikeOut.Text = "Doorstrepen"
        Me.cbStrikeOut.UseVisualStyleBackColor = True
        '
        'cbItalic
        '
        Me.cbItalic.AutoSize = True
        Me.cbItalic.Location = New System.Drawing.Point(137, 73)
        Me.cbItalic.Name = "cbItalic"
        Me.cbItalic.Size = New System.Drawing.Size(71, 22)
        Me.cbItalic.TabIndex = 22
        Me.cbItalic.Text = "Cursief"
        Me.cbItalic.UseVisualStyleBackColor = True
        '
        'cbBold
        '
        Me.cbBold.AutoSize = True
        Me.cbBold.Location = New System.Drawing.Point(10, 73)
        Me.cbBold.Name = "cbBold"
        Me.cbBold.Size = New System.Drawing.Size(49, 22)
        Me.cbBold.TabIndex = 21
        Me.cbBold.Text = "Vet"
        Me.cbBold.UseVisualStyleBackColor = True
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Location = New System.Drawing.Point(215, 36)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(97, 26)
        Me.cmbSize.TabIndex = 20
        '
        'cmbName
        '
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(10, 36)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(184, 26)
        Me.cmbName.TabIndex = 19
        '
        'pageCountDown
        '
        Me.pageCountDown.Controls.Add(Me.lblResetCounterlocation)
        Me.pageCountDown.Controls.Add(Me.lblCountDown1MinExample)
        Me.pageCountDown.Controls.Add(Me.lblCountDown30SecExample)
        Me.pageCountDown.Controls.Add(Me.lblCountDown30Sec)
        Me.pageCountDown.Controls.Add(Me.lblCountDown1Min)
        Me.pageCountDown.Controls.Add(Me.butCountDown30Sec)
        Me.pageCountDown.Controls.Add(Me.butCountDown1Min)
        Me.pageCountDown.Controls.Add(Me.cmbCountDownTimer)
        Me.pageCountDown.Controls.Add(Me.lblCountDownTimer)
        Me.pageCountDown.Location = New System.Drawing.Point(4, 27)
        Me.pageCountDown.Name = "pageCountDown"
        Me.pageCountDown.Padding = New System.Windows.Forms.Padding(3)
        Me.pageCountDown.Size = New System.Drawing.Size(466, 254)
        Me.pageCountDown.TabIndex = 1
        Me.pageCountDown.Text = "CountDown"
        Me.pageCountDown.UseVisualStyleBackColor = True
        '
        'lblResetCounterlocation
        '
        Me.lblResetCounterlocation.AutoSize = True
        Me.lblResetCounterlocation.Location = New System.Drawing.Point(48, 109)
        Me.lblResetCounterlocation.Name = "lblResetCounterlocation"
        Me.lblResetCounterlocation.Size = New System.Drawing.Size(351, 18)
        Me.lblResetCounterlocation.TabIndex = 33
        Me.lblResetCounterlocation.Text = "...Klik hier voor het resetten van de venster locatie..."
        '
        'lblCountDown1MinExample
        '
        Me.lblCountDown1MinExample.AutoSize = True
        Me.lblCountDown1MinExample.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblCountDown1MinExample.Location = New System.Drawing.Point(231, 43)
        Me.lblCountDown1MinExample.Name = "lblCountDown1MinExample"
        Me.lblCountDown1MinExample.Size = New System.Drawing.Size(79, 18)
        Me.lblCountDown1MinExample.TabIndex = 32
        Me.lblCountDown1MinExample.Text = "Voorbeeld:"
        '
        'lblCountDown30SecExample
        '
        Me.lblCountDown30SecExample.AutoSize = True
        Me.lblCountDown30SecExample.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblCountDown30SecExample.Location = New System.Drawing.Point(231, 77)
        Me.lblCountDown30SecExample.Name = "lblCountDown30SecExample"
        Me.lblCountDown30SecExample.Size = New System.Drawing.Size(79, 18)
        Me.lblCountDown30SecExample.TabIndex = 31
        Me.lblCountDown30SecExample.Text = "Voorbeeld:"
        '
        'lblCountDown30Sec
        '
        Me.lblCountDown30Sec.AutoSize = True
        Me.lblCountDown30Sec.Location = New System.Drawing.Point(6, 77)
        Me.lblCountDown30Sec.Name = "lblCountDown30Sec"
        Me.lblCountDown30Sec.Size = New System.Drawing.Size(127, 18)
        Me.lblCountDown30Sec.TabIndex = 29
        Me.lblCountDown30Sec.Text = "30 seconden kleur:"
        '
        'lblCountDown1Min
        '
        Me.lblCountDown1Min.AutoSize = True
        Me.lblCountDown1Min.Location = New System.Drawing.Point(6, 43)
        Me.lblCountDown1Min.Name = "lblCountDown1Min"
        Me.lblCountDown1Min.Size = New System.Drawing.Size(104, 18)
        Me.lblCountDown1Min.TabIndex = 28
        Me.lblCountDown1Min.Text = "1 minuut kleur:"
        '
        'butCountDown30Sec
        '
        Me.butCountDown30Sec.Location = New System.Drawing.Point(155, 72)
        Me.butCountDown30Sec.Name = "butCountDown30Sec"
        Me.butCountDown30Sec.Size = New System.Drawing.Size(70, 28)
        Me.butCountDown30Sec.TabIndex = 27
        Me.butCountDown30Sec.Text = "Kleur"
        Me.butCountDown30Sec.UseVisualStyleBackColor = True
        '
        'butCountDown1Min
        '
        Me.butCountDown1Min.Location = New System.Drawing.Point(155, 38)
        Me.butCountDown1Min.Name = "butCountDown1Min"
        Me.butCountDown1Min.Size = New System.Drawing.Size(70, 28)
        Me.butCountDown1Min.TabIndex = 26
        Me.butCountDown1Min.Text = "Kleur"
        Me.butCountDown1Min.UseVisualStyleBackColor = True
        '
        'cmbCountDownTimer
        '
        Me.cmbCountDownTimer.FormattingEnabled = True
        Me.cmbCountDownTimer.Location = New System.Drawing.Point(156, 6)
        Me.cmbCountDownTimer.Name = "cmbCountDownTimer"
        Me.cmbCountDownTimer.Size = New System.Drawing.Size(69, 26)
        Me.cmbCountDownTimer.TabIndex = 22
        Me.cmbCountDownTimer.Text = "88"
        '
        'lblCountDownTimer
        '
        Me.lblCountDownTimer.AutoSize = True
        Me.lblCountDownTimer.Location = New System.Drawing.Point(6, 9)
        Me.lblCountDownTimer.Name = "lblCountDownTimer"
        Me.lblCountDownTimer.Size = New System.Drawing.Size(48, 18)
        Me.lblCountDownTimer.TabIndex = 21
        Me.lblCountDownTimer.Text = "Timer:"
        '
        'butOkay
        '
        Me.butOkay.Location = New System.Drawing.Point(488, 269)
        Me.butOkay.Name = "butOkay"
        Me.butOkay.Size = New System.Drawing.Size(140, 28)
        Me.butOkay.TabIndex = 30
        Me.butOkay.Text = "Okay"
        Me.butOkay.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(488, 235)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(140, 28)
        Me.butCancel.TabIndex = 31
        Me.butCancel.Text = "Annuleren"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'frmConfig
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(643, 315)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOkay)
        Me.Controls.Add(Me.tabConfig)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Configuratie"
        Me.tabConfig.ResumeLayout(False)
        Me.pageClock.ResumeLayout(False)
        Me.pageClock.PerformLayout()
        Me.gbVoorbeeld.ResumeLayout(False)
        Me.gbVoorbeeld.PerformLayout()
        Me.pageCountDown.ResumeLayout(False)
        Me.pageCountDown.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabConfig As TabControl
    Friend WithEvents pageClock As TabPage
    Friend WithEvents cbTransparant As CheckBox
    Friend WithEvents lblSize As Label
    Friend WithEvents lblName As Label
    Friend WithEvents gbVoorbeeld As GroupBox
    Friend WithEvents lblExample As Label
    Friend WithEvents butBackColor As Button
    Friend WithEvents butForeColor As Button
    Friend WithEvents cbUnderlined As CheckBox
    Friend WithEvents cbStrikeOut As CheckBox
    Friend WithEvents cbItalic As CheckBox
    Friend WithEvents cbBold As CheckBox
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents pageCountDown As TabPage
    Friend WithEvents lblCountDown30Sec As Label
    Friend WithEvents lblCountDown1Min As Label
    Friend WithEvents butCountDown30Sec As Button
    Friend WithEvents butCountDown1Min As Button
    Friend WithEvents cmbCountDownTimer As ComboBox
    Friend WithEvents lblCountDownTimer As Label
    Friend WithEvents butOkay As Button
    Friend WithEvents butCancel As Button
    Friend WithEvents lblCountDown1MinExample As Label
    Friend WithEvents lblCountDown30SecExample As Label
    Friend WithEvents lblResetCounterlocation As Label
End Class
