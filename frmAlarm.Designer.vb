<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlarm
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
        Me.cmbUren = New System.Windows.Forms.ComboBox()
        Me.cmbMinuten = New System.Windows.Forms.ComboBox()
        Me.lblUren = New System.Windows.Forms.Label()
        Me.lblMinuten = New System.Windows.Forms.Label()
        Me.lblIntro01 = New System.Windows.Forms.Label()
        Me.lblIntro02 = New System.Windows.Forms.Label()
        Me.butForeColor = New System.Windows.Forms.Button()
        Me.butBackColor = New System.Windows.Forms.Button()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.gbVoorbeeld = New System.Windows.Forms.GroupBox()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butOkay = New System.Windows.Forms.Button()
        Me.gbVoorbeeld.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbUren
        '
        Me.cmbUren.FormattingEnabled = True
        Me.cmbUren.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "00"})
        Me.cmbUren.Location = New System.Drawing.Point(9, 69)
        Me.cmbUren.Name = "cmbUren"
        Me.cmbUren.Size = New System.Drawing.Size(55, 31)
        Me.cmbUren.TabIndex = 0
        '
        'cmbMinuten
        '
        Me.cmbMinuten.FormattingEnabled = True
        Me.cmbMinuten.Items.AddRange(New Object() {"01", "02", "03"})
        Me.cmbMinuten.Location = New System.Drawing.Point(101, 69)
        Me.cmbMinuten.Name = "cmbMinuten"
        Me.cmbMinuten.Size = New System.Drawing.Size(55, 31)
        Me.cmbMinuten.TabIndex = 1
        '
        'lblUren
        '
        Me.lblUren.AutoSize = True
        Me.lblUren.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUren.Location = New System.Drawing.Point(6, 49)
        Me.lblUren.Name = "lblUren"
        Me.lblUren.Size = New System.Drawing.Size(43, 17)
        Me.lblUren.TabIndex = 2
        Me.lblUren.Text = "Uren"
        '
        'lblMinuten
        '
        Me.lblMinuten.AutoSize = True
        Me.lblMinuten.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinuten.Location = New System.Drawing.Point(98, 49)
        Me.lblMinuten.Name = "lblMinuten"
        Me.lblMinuten.Size = New System.Drawing.Size(65, 17)
        Me.lblMinuten.TabIndex = 3
        Me.lblMinuten.Text = "Minuten"
        '
        'lblIntro01
        '
        Me.lblIntro01.AutoSize = True
        Me.lblIntro01.Location = New System.Drawing.Point(4, 9)
        Me.lblIntro01.Name = "lblIntro01"
        Me.lblIntro01.Size = New System.Drawing.Size(493, 23)
        Me.lblIntro01.TabIndex = 4
        Me.lblIntro01.Text = "Geef het tijdstip op dat het alarm moet afgaan en de gewenste"
        '
        'lblIntro02
        '
        Me.lblIntro02.AutoSize = True
        Me.lblIntro02.Location = New System.Drawing.Point(5, 26)
        Me.lblIntro02.Name = "lblIntro02"
        Me.lblIntro02.Size = New System.Drawing.Size(320, 23)
        Me.lblIntro02.TabIndex = 5
        Me.lblIntro02.Text = "alarmkleur. Eventueel een omschrijving."
        '
        'butForeColor
        '
        Me.butForeColor.Location = New System.Drawing.Point(162, 69)
        Me.butForeColor.Name = "butForeColor"
        Me.butForeColor.Size = New System.Drawing.Size(140, 28)
        Me.butForeColor.TabIndex = 6
        Me.butForeColor.Text = "Voorgrond kleur"
        Me.butForeColor.UseVisualStyleBackColor = True
        '
        'butBackColor
        '
        Me.butBackColor.Location = New System.Drawing.Point(308, 69)
        Me.butBackColor.Name = "butBackColor"
        Me.butBackColor.Size = New System.Drawing.Size(140, 28)
        Me.butBackColor.TabIndex = 7
        Me.butBackColor.Text = "Achtergrond kleur"
        Me.butBackColor.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(9, 139)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(493, 27)
        Me.txtText.TabIndex = 8
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(6, 113)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(179, 23)
        Me.lblText.TabIndex = 9
        Me.lblText.Text = "Waarschuwings tekst:"
        '
        'gbVoorbeeld
        '
        Me.gbVoorbeeld.Controls.Add(Me.lblExample)
        Me.gbVoorbeeld.Location = New System.Drawing.Point(9, 172)
        Me.gbVoorbeeld.Name = "gbVoorbeeld"
        Me.gbVoorbeeld.Size = New System.Drawing.Size(290, 91)
        Me.gbVoorbeeld.TabIndex = 10
        Me.gbVoorbeeld.TabStop = False
        Me.gbVoorbeeld.Text = "Voorbeeld"
        '
        'lblExample
        '
        Me.lblExample.AutoSize = True
        Me.lblExample.Location = New System.Drawing.Point(6, 29)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(86, 23)
        Me.lblExample.TabIndex = 4
        Me.lblExample.Text = "Voorbeeld"
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(402, 190)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(100, 28)
        Me.butCancel.TabIndex = 11
        Me.butCancel.Text = "Annuleren"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butOkay
        '
        Me.butOkay.Location = New System.Drawing.Point(402, 235)
        Me.butOkay.Name = "butOkay"
        Me.butOkay.Size = New System.Drawing.Size(100, 28)
        Me.butOkay.TabIndex = 12
        Me.butOkay.Text = "Okay"
        Me.butOkay.UseVisualStyleBackColor = True
        '
        'frmAlarm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(509, 275)
        Me.Controls.Add(Me.butOkay)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.gbVoorbeeld)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.butBackColor)
        Me.Controls.Add(Me.butForeColor)
        Me.Controls.Add(Me.lblIntro02)
        Me.Controls.Add(Me.lblIntro01)
        Me.Controls.Add(Me.lblMinuten)
        Me.Controls.Add(Me.lblUren)
        Me.Controls.Add(Me.cmbMinuten)
        Me.Controls.Add(Me.cmbUren)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAlarm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmAlarm"
        Me.gbVoorbeeld.ResumeLayout(False)
        Me.gbVoorbeeld.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUren As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMinuten As System.Windows.Forms.ComboBox
    Friend WithEvents lblUren As System.Windows.Forms.Label
    Friend WithEvents lblMinuten As System.Windows.Forms.Label
    Friend WithEvents lblIntro01 As System.Windows.Forms.Label
    Friend WithEvents lblIntro02 As System.Windows.Forms.Label
    Friend WithEvents butForeColor As System.Windows.Forms.Button
    Friend WithEvents butBackColor As System.Windows.Forms.Button
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents gbVoorbeeld As System.Windows.Forms.GroupBox
    Friend WithEvents lblExample As System.Windows.Forms.Label
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents butOkay As System.Windows.Forms.Button
End Class
