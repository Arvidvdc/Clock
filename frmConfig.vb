Public Class frmConfig

    Private Function SGTColor(ByVal SendColor As Color)
        Dim diaColor As New ColorDialog
        diaColor.AllowFullOpen = False
        diaColor.AnyColor = False
        diaColor.FullOpen = False
        diaColor.ShowHelp = False
        diaColor.SolidColorOnly = True
        If Not frmMain.sgtINI.GetStringField("Alarm", "ColorFore") = Nothing Then diaColor.Color = Color.FromName(frmMain.sgtINI.GetStringField("Alarm", "ColorFore"))
        If (diaColor.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Return diaColor.Color
        Else
            Return SendColor
        End If
    End Function

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Left = frmMain.Left
        Me.Top = frmMain.Top - Me.Height
        Me.Text = "Configuratie v" & Application.ProductVersion
        If Me.Top < 0 Then Me.Top = 0
        lblExample.Font = frmMain.lblTime.Font
        lblExample.Text = FormatDateTime(Now, DateFormat.LongTime)

        cbBold.Checked = frmMain.sgtINI.GetStringField("Font", "Bold")
        cbItalic.Checked = frmMain.sgtINI.GetStringField("Font", "Italic")
        cbStrikeOut.Checked = frmMain.sgtINI.GetStringField("Font", "StrikeOut")
        cbUnderlined.Checked = frmMain.sgtINI.GetStringField("Font", "Underlined")

        If Len(frmMain.sgtINI.GetStringField("Font", "BackColor")) > 0 Then lblExample.BackColor = Color.FromName(frmMain.sgtINI.GetStringField("Font", "BackColor"))
        If Len(frmMain.sgtINI.GetStringField("Font", "ForeColor")) > 0 Then lblExample.ForeColor = Color.FromName(frmMain.sgtINI.GetStringField("Font", "ForeColor"))

        If frmMain.sgtINI.GetNumberField("Main", "Transparent") = 1 Then
            butBackColor.Enabled = False
            lblExample.BackColor = Me.BackColor
            cbTransparant.Checked = True
        Else
            cbTransparant.Checked = False
        End If

        Dim fc As New Drawing.Text.InstalledFontCollection
        Dim ff As FontFamily() = fc.Families()
        cmbName.Items.Clear()
        For Each family As FontFamily In ff
            cmbName.Items.Add(family.Name)
        Next
        cmbName.Text = frmMain.sgtINI.GetStringField("Font", "Name")

        Dim a As Integer = 1
        cmbSize.Text = Nothing
        cmbSize.Items.Clear()
        Do Until a = 72 + 1
            If a <= 9 Then
                cmbSize.Items.Add("0" & a)
            Else
                cmbSize.Items.Add(a)
            End If
            a += 1
        Loop
        cmbSize.Text = frmMain.sgtINI.GetStringField("Font", "Size")

        a = 1
        cmbCountDownTimer.Text = Nothing
        cmbCountDownTimer.Items.Clear()
        Do Until a = 9 + 1
            cmbCountDownTimer.Items.Add(a)
            a += 1
        Loop
        cmbCountDownTimer.Text = frmMain.sgtINI.GetStringField("Counter", "CountDownTime")

    End Sub

    Private Sub tabConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabConfig.SelectedIndexChanged
        Select Case tabConfig.SelectedIndex
            Case 1
                lblCountDown1MinExample.ForeColor = lblExample.ForeColor
                If Len(frmMain.sgtINI.GetStringField("Counter", "1minColor")) > 0 Then lblCountDown1MinExample.BackColor = Color.FromName(frmMain.sgtINI.GetStringField("Counter", "1minColor"))
                'lblCountDown1MinExample.BackColor = lblExample.BackColor
                lblCountDown30SecExample.ForeColor = lblExample.ForeColor
                'lblCountDown30SecExample.BackColor = lblExample.BackColor
                If Len(frmMain.sgtINI.GetStringField("Counter", "30secColor")) > 0 Then lblCountDown30SecExample.BackColor = Color.FromName(frmMain.sgtINI.GetStringField("Counter", "30secColor"))
            Case Else

        End Select
    End Sub

    Private Sub butCountDown1Min_Click(sender As Object, e As EventArgs) Handles butCountDown1Min.Click
        lblCountDown1MinExample.BackColor = SGTColor(lblCountDown1MinExample.BackColor)
    End Sub

    Private Sub butForeColor_Click(sender As Object, e As EventArgs) Handles butForeColor.Click
        lblExample.ForeColor = SGTColor(lblExample.ForeColor)
    End Sub

    Private Sub butBackColor_Click(sender As Object, e As EventArgs) Handles butBackColor.Click
        lblExample.BackColor = SGTColor(lblExample.BackColor)
    End Sub

    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        Try
            If Not cmbName.Text = Nothing Then lblExample.Font = frmMain.CreateFont(cmbName.Text, lblExample.Font.Size, lblExample.Font.Bold, lblExample.Font.Italic, lblExample.Font.Strikeout, lblExample.Font.Underline)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSize.SelectedIndexChanged
        If Not cmbSize.Text = Nothing Then lblExample.Font = frmMain.CreateFont(lblExample.Font.FontFamily.Name, cmbSize.Text, lblExample.Font.Bold, lblExample.Font.Italic, lblExample.Font.Strikeout, lblExample.Font.Underline)
    End Sub

    Private Sub cmbSize_TextChanged(sender As Object, e As EventArgs) Handles cmbSize.TextChanged
        If Not cmbSize.Text = Nothing Then lblExample.Font = frmMain.CreateFont(lblExample.Font.FontFamily.Name, cmbSize.Text, lblExample.Font.Bold, lblExample.Font.Italic, lblExample.Font.Strikeout, lblExample.Font.Underline)
    End Sub

    Private Sub butOkay_Click(sender As Object, e As EventArgs) Handles butOkay.Click
        frmMain.sgtINI.SetStringField("Font", "Name", cmbName.Text)
        frmMain.sgtINI.SetStringField("Font", "Size", cmbSize.Text)
        frmMain.sgtINI.SetStringField("Font", "Bold", cbBold.Checked)
        frmMain.sgtINI.SetStringField("Font", "Italic", cbItalic.Checked)
        frmMain.sgtINI.SetStringField("Font", "StrikeOut", cbStrikeOut.Checked)
        frmMain.sgtINI.SetStringField("Font", "Underlined", cbUnderlined.Checked)
        frmMain.sgtINI.SetStringField("Font", "ForeColor", lblExample.ForeColor.Name)

        frmMain.sgtINI.SetNumberField("Counter", "CountDownTime", cmbCountDownTimer.Text)
        frmMain.sgtINI.SetStringField("Counter", "1minColor", lblCountDown1MinExample.BackColor.Name)
        frmMain.sgtINI.SetStringField("Counter", "30secColor", lblCountDown30SecExample.BackColor.Name)

        If cbTransparant.Checked = True Then
            frmMain.sgtINI.SetStringField("Main", "Transparent", 1)
        Else
            frmMain.sgtINI.SetStringField("Main", "Transparent", 0)
            frmMain.sgtINI.SetStringField("Font", "BackColor", lblExample.BackColor.Name)
        End If

        frmMain.sgtINI.Save(frmMain.sgtINIFile)
        Me.Close()
    End Sub

    Private Sub cbBold_CheckedChanged(sender As Object, e As EventArgs) Handles cbBold.CheckedChanged
        lblExample.Font = frmMain.CreateFont(lblExample.Font.FontFamily.Name, lblExample.Font.Size, cbBold.Checked, lblExample.Font.Italic, lblExample.Font.Strikeout, lblExample.Font.Underline)
    End Sub

    Private Sub cbStrikeOut_CheckedChanged(sender As Object, e As EventArgs) Handles cbStrikeOut.CheckedChanged
        lblExample.Font = frmMain.CreateFont(lblExample.Font.FontFamily.Name, lblExample.Font.Size, lblExample.Font.Bold, lblExample.Font.Italic, cbStrikeOut.Checked, lblExample.Font.Underline)
    End Sub

    Private Sub cbItalic_CheckedChanged(sender As Object, e As EventArgs) Handles cbItalic.CheckedChanged
        lblExample.Font = frmMain.CreateFont(lblExample.Font.FontFamily.Name, lblExample.Font.Size, lblExample.Font.Bold, cbItalic.Checked, lblExample.Font.Strikeout, lblExample.Font.Underline)
    End Sub

    Private Sub cbUnderlined_CheckedChanged(sender As Object, e As EventArgs) Handles cbUnderlined.CheckedChanged
        lblExample.Font = frmMain.CreateFont(lblExample.Font.FontFamily.Name, lblExample.Font.Size, lblExample.Font.Bold, lblExample.Font.Italic, lblExample.Font.Strikeout, cbUnderlined.Checked)
    End Sub

    Private Sub cbTransparant_Click(sender As Object, e As EventArgs) Handles cbTransparant.Click
        If cbTransparant.Checked = False Then
            Me.TransparencyKey = Color.AliceBlue
            If Len(frmMain.sgtINI.GetStringField("Font", "BackColor")) > 0 Then lblExample.BackColor = Color.FromName(frmMain.sgtINI.GetStringField("Font", "BackColor"))
            butBackColor.Enabled = True
            cbTransparant.Checked = False
        Else
            lblExample.BackColor = Me.BackColor
            butBackColor.Enabled = False
            cbTransparant.Checked = True
        End If
    End Sub

    Private Sub butCountDown30Sec_Click(sender As Object, e As EventArgs) Handles butCountDown30Sec.Click
        lblCountDown30SecExample.BackColor = SGTColor(lblCountDown30SecExample.BackColor)
    End Sub

    Private Sub lblResetCounterlocation_Click(sender As Object, e As EventArgs) Handles lblResetCounterlocation.Click
        'Controleren of from, open is
        Dim strStatus As String = "Closed"
        For Each form In My.Application.OpenForms
            If (form.name = "frmCountDown") Then
                strStatus = "Open"
                If form.Visible Then
                    strStatus = "Visible"
                End If
            End If
        Next
        'Eventueel open form afsluiten
        If strStatus <> "Closed" Then frmCountDown.Close()
        'Nieuwe waarden in de INI plaatsen
        frmMain.sgtINI.SetNumberField("Counter", "Top", 0)
        frmMain.sgtINI.SetNumberField("Counter", "Left", 0)
        frmMain.sgtINI.Save(frmMain.sgtINIFile)
        frmMain.sgtPopUpAftellen.Checked = False
        MsgBox("INIbestand aangepast")
    End Sub

    Private Sub frmConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tabConfig.SelectedIndex = 0
        frmMain.sgtINI = New Ini
        frmMain.sgtINI.Load(frmMain.sgtINIFile)
    End Sub
End Class