Public Class frmAlarm

    Private Sub butForeColor_Click(sender As Object, e As EventArgs) Handles butForeColor.Click
        Dim diaColor As New ColorDialog
        diaColor.AllowFullOpen = False
        diaColor.AnyColor = False
        diaColor.FullOpen = False
        diaColor.ShowHelp = False
        diaColor.SolidColorOnly = True
        If Not frmMain.sgtINI.GetStringField("Alarm", "ColorFore") = Nothing Then diaColor.Color = Color.FromName(frmMain.sgtINI.GetStringField("Alarm", "ColorFore"))
        If (diaColor.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            lblExample.ForeColor = diaColor.Color
        End If
    End Sub

    Private Sub butBackColor_Click(sender As Object, e As EventArgs) Handles butBackColor.Click
        Dim diaColor As New ColorDialog
        diaColor.AllowFullOpen = False
        diaColor.AnyColor = False
        diaColor.FullOpen = False
        diaColor.ShowHelp = False
        diaColor.SolidColorOnly = True
        If Not frmMain.sgtINI.GetStringField("Alarm", "ColorBack") = Nothing Then diaColor.Color = Color.FromName(frmMain.sgtINI.GetStringField("Alarm", "ColorBack"))
        If (diaColor.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            lblExample.BackColor = diaColor.Color
        End If
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAlarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = frmMain.Left
        Me.Top = frmMain.Top - Me.Height
        If Me.Top < 0 Then Me.Top = 0
        lblExample.Font = frmMain.lblTime.Font
        If Len(frmMain.sgtINI.GetStringField("Alarm", "Time")) > 0 Then
            lblExample.Text = frmMain.sgtINI.GetStringField("Alarm", "Time")
            cmbUren.Text = Microsoft.VisualBasic.Left(frmMain.sgtINI.GetStringField("Alarm", "Time"), 2)
            cmbMinuten.Text = Microsoft.VisualBasic.Right(frmMain.sgtINI.GetStringField("Alarm", "Time"), 2)
        End If
        If Len(frmMain.sgtINI.GetStringField("Alarm", "ColorBack")) > 0 Then lblExample.BackColor = Color.FromName(frmMain.sgtINI.GetStringField("Alarm", "ColorBack"))
        If Len(frmMain.sgtINI.GetStringField("Alarm", "ColorFore")) > 0 Then lblExample.ForeColor = Color.FromName(frmMain.sgtINI.GetStringField("Alarm", "ColorFore"))
        txtText.Text = frmMain.sgtINI.GetStringField("Alarm", "Tekst")

        If frmMain.sgtINI.GetNumberField("Main", "Transparent") = 1 Then
            butBackColor.Enabled = False
            lblExample.BackColor = Me.BackColor
        End If

        Dim a As Integer = 1
        cmbUren.Items.Clear()
        Do Until a = 24 + 1
            If a <= 9 Then
                cmbUren.Items.Add("0" & a)
            Else
                If a = 24 Then
                    cmbUren.Items.Add("00")
                Else
                    cmbUren.Items.Add(a)
                End If
            End If
            a += 1
        Loop
        a = 0
        cmbMinuten.Items.Clear()
        Do Until a = 60 + 1
            If a <= 9 Then
                cmbMinuten.Items.Add("0" & a)
            Else
                If a = 60 Then
                    cmbMinuten.Items.Add("00")
                Else
                    cmbMinuten.Items.Add(a)
                End If
            End If
            a += 1
        Loop
    End Sub

    Private Sub cmbUren_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUren.SelectedIndexChanged
        If Not cmbMinuten.Text = Nothing And Not cmbUren.Text = Nothing Then
            lblExample.Text = cmbUren.Text & ":" & cmbMinuten.Text
        End If
    End Sub

    Private Sub cmbMinuten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMinuten.SelectedIndexChanged
        If Not cmbMinuten.Text = Nothing And Not cmbUren.Text = Nothing Then
            lblExample.Text = cmbUren.Text & ":" & cmbMinuten.Text
        End If
    End Sub

    Private Sub butOkay_Click(sender As Object, e As EventArgs) Handles butOkay.Click
        If cmbUren.Text = Nothing Or cmbMinuten.Text = Nothing Then
            frmMain.sgtINI.SetStringField("Alarm", "Time", "")
        Else
            frmMain.sgtINI.SetStringField("Alarm", "Time", cmbUren.Text & ":" & cmbMinuten.Text)
        End If
        frmMain.sgtINI.SetStringField("Alarm", "Tekst", txtText.Text)
        frmMain.sgtINI.SetStringField("Alarm", "ColorBack", lblExample.BackColor.Name)
        frmMain.sgtINI.SetStringField("Alarm", "ColorFore", lblExample.ForeColor.Name)
        frmMain.sgtINI.Save(frmMain.sgtINIFile)
        Me.Close()
    End Sub
End Class