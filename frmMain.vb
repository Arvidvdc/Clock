Imports System.IO
Imports System.Drawing.Text

Public Class frmMain
    Public Property sgtFont As New Font("Tahoma", 20, FontStyle.Bold)
    Public Property sgtToolTip As New ToolTip
    Public Property sgtINI As New Ini
    Public Property sgtDefaultPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Arvid's Soft\Clock"
    Public Property sgtINIFile As String = sgtDefaultPath & "\clock.ini"
    Public Property sgtColor As Integer = 0
    Public Property sgtCountDown As Integer = 5

#Region " Move Form "
    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        sgtINI.SetNumberField("Main", "Top", Me.Top)
        sgtINI.SetNumberField("Main", "Left", Me.Left)
        sgtINI.Save(sgtINIFile)

        frmCountDown.CounterPopUpOpenenClock.Enabled = True

    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown, lblTime.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove, lblTime.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, lblTime.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region

    Public Sub CreateINI()
        Dim strWorkDir As String = sgtDefaultPath

        If Directory.Exists(strWorkDir) = False Then
            Try
                FileSystem.MkDir(strWorkDir)
            Catch ex As Exception
                MsgBox("INIFile niet aangemaakt.")
                Exit Sub
            End Try
        End If

        If File.Exists(strWorkDir & "\clock.ini") Then
            File.Move(strWorkDir & "\clock.ini", strWorkDir & "\clock.bak")
        End If

        File.Create(strWorkDir & "\clock.ini").Dispose()
        sgtINI = New Ini()
        sgtINI.Load(strWorkDir & "\clock.ini")
        sgtINI.Add("Main")
        sgtINI.Add("Main", "Top", "0")
        sgtINI.Add("Main", "Left", "0")
        sgtINI.Add("Main", "TitleBar", "0")
        sgtINI.Add("Main", "OnTop", "False")
        sgtINI.Add("Main", "Transparent", 0)
        sgtINI.Add("Font")
        sgtINI.Add("Font", "Name", "Tahoma")
        sgtINI.Add("Font", "Size", "12")
        sgtINI.Add("Font", "Bold", True)
        sgtINI.Add("Font", "Italic", False)
        sgtINI.Add("Font", "StrikeOut", False)
        sgtINI.Add("Font", "Underlined", False)
        sgtINI.Add("Font", "ForeColor", "White")
        sgtINI.Add("Font", "BackColor", "Black")
        sgtINI.Add("Alarm")
        sgtINI.Add("Alarm", "Time", "")
        sgtINI.Add("Alarm", "Tekst", "")
        sgtINI.Add("Alarm", "ColorBack", "")
        sgtINI.Add("Alarm", "ColorFore", "")
        sgtINI.Add("Counter")
        sgtINI.Add("Counter", "CountDownTime", "5")
        sgtINI.Add("Counter", "Top", "0")
        sgtINI.Add("Counter", "Left", "0")
        sgtINI.Add("Counter", "1minColor", "Lime")
        sgtINI.Add("Counter", "30secColor", "Red")
        sgtINI.Save(strWorkDir & "\clock.ini")
    End Sub

    Public Sub CheckINI()
        Dim intMaxItems As Integer = 17
        Dim intCountItem As Integer = 0
        Dim strWorkString As String = Nothing
        Dim strSection As String = Nothing
        Dim strField As String = Nothing
        Dim strValue As String = Nothing

        Do Until intCountItem = intMaxItems
            intCountItem += 1
            Select Case intCountItem
                Case 1
                    strSection = "Main"
                    strField = "Top"
                    strValue = "0"
                Case 2
                    strSection = "Main"
                    strField = "Left"
                    strValue = "0"
                Case 3
                    strSection = "Main"
                    strField = "TitleBar"
                    strValue = "0"
                Case 4
                    strSection = "Main"
                    strField = "OnTop"
                    strValue = "False"
                Case 5
                    strSection = "Main"
                    strField = "Transparent"
                    strValue = "0"
                Case 6
                    strSection = "Font"
                    strField = "Name"
                    strValue = "Tahoma"
                Case 7
                    strSection = "Font"
                    strField = "Size"
                    strValue = "12"
                Case 8
                    strSection = "Font"
                    strField = "Bold"
                    strValue = "True"
                Case 9
                    strSection = "Font"
                    strField = "Italic"
                    strValue = "False"
                Case 10
                    strSection = "Font"
                    strField = "StrikeOut"
                    strValue = "False"
                Case 11
                    strSection = "Font"
                    strField = "Underlined"
                    strValue = "False"
                Case 12
                    strSection = "Font"
                    strField = "ForeColor"
                    strValue = "White"
                Case 13
                    strSection = "Font"
                    strField = "BackColor"
                    strValue = "Black"
                Case 14
                    strSection = "Alarm"
                    strField = "Time"
                    strValue = "0"
                Case 15
                    strSection = "Alarm"
                    strField = "Tekst"
                    strValue = ""
                Case 16
                    strSection = "Alarm"
                    strField = "ColorBack"
                    strValue = ""
                Case 17
                    strSection = "Alarm"
                    strField = "ColorFore"
                    strValue = ""
                Case Else
                    strSection = Nothing
                    strField = Nothing
                    strValue = Nothing
            End Select

            Try
                strWorkString = sgtINI.GetStringField(strSection, strField)
            Catch ex As SectionDoesNotExistException
                sgtINI.Add(strSection, strField, strValue)
                sgtINI.Save(sgtDefaultPath & "\clock.ini")
            Catch ex As Exception
            End Try
        Loop
    End Sub

    Public Sub sgtLayout()
        lblTime.Location = New Point(0, 0)
        Me.FormBorderStyle = sgtINI.GetStringField("Main", "TitleBar")
        Select Case Me.FormBorderStyle
            Case 5 'FixedToolWindow
                Me.Height = lblTime.Bottom + 40
                Me.Width = lblTime.Right + 17
                sgtPopUpBorderAan.Text = "Border uit"
            Case 0 'None
                Me.Height = lblTime.Bottom
                Me.Width = lblTime.Right
                sgtPopUpBorderAan.Text = "Border aan"
        End Select
        Me.TopMost = sgtINI.GetStringField("Main", "OnTop")
        sgtPopUpBovenaan.Checked = sgtINI.GetStringField("Main", "OnTop")
        If sgtINI.GetNumberField("Main", "Transparent") = 1 Then sgtPopUpTransparant.Checked = True Else sgtPopUpTransparant.Checked = False
    End Sub

    Public Function CreateFont(ByVal fontName As String, ByVal fontSize As Integer, ByVal isBold As Boolean, ByVal isItalic As Boolean, ByVal isStrikeout As Boolean, ByVal isUnderline As Boolean) As Drawing.Font
        Dim styles As FontStyle = FontStyle.Regular
        If (isBold) Then
            styles = styles Or FontStyle.Bold
        End If
        If (isItalic) Then
            styles = styles Or FontStyle.Italic
        End If
        If (isStrikeout) Then
            styles = styles Or FontStyle.Strikeout
        End If
        If (isUnderline) Then
            styles = styles Or FontStyle.Underline
        End If

        Dim newFont As New Drawing.Font(fontName, fontSize, styles)
        Return newFont

    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INIFile
        If Not File.Exists(sgtINIFile) Then
            Call CreateINI()
        End If
        sgtINI = New Ini
        sgtINI.Load(sgtINIFile)
        Call CheckINI()

        'Tooltip
        sgtToolTip.AutoPopDelay = 5000
        sgtToolTip.InitialDelay = 1000
        sgtToolTip.ReshowDelay = 100
        sgtToolTip.ShowAlways = True
        sgtToolTip.RemoveAll()

        sgtTimer.Start()

        Me.Top = sgtINI.GetNumberField("Main", "Top")
        Me.Left = sgtINI.GetNumberField("Main", "Left")
    End Sub

    Private Sub sgtTimer_Tick(sender As Object, e As EventArgs) Handles sgtTimer.Tick
        sgtCountDown = sgtINI.GetNumberField("Counter", "CountDownTime")
        lblTime.Text = FormatDateTime(Now, DateFormat.LongTime)
        Me.Text = FormatDateTime(Now, DateFormat.LongTime)
        lblTime.Font = CreateFont(sgtINI.GetStringField("Font", "Name"), sgtINI.GetStringField("Font", "Size"), sgtINI.GetStringField("Font", "Bold"), sgtINI.GetStringField("Font", "Italic"), sgtINI.GetStringField("Font", "StrikeOut"), sgtINI.GetStringField("Font", "Underlined"))

        If Trim(FormatDateTime(Now, DateFormat.ShortTime)) = Trim(sgtINI.GetStringField("Alarm", "Time")) Then
            Dim ca As Integer
            Dim s As Integer = Microsoft.VisualBasic.Right(Second(Now), 1)
            ca = s Mod 2
            If ca = 0 Then sgtColor = 0 Else sgtColor = 1
        Else
            sgtColor = 0
        End If

        Select Case sgtColor
            Case 0 'Standaard kleuren
                If sgtINI.GetNumberField("Main", "Transparent") = 1 Then
                    Me.TransparencyKey = Color.FromName(sgtINI.GetStringField("Font", "BackColor"))
                    sgtPopUpTransparant.Checked = True
                Else
                    Me.TransparencyKey = Color.AliceBlue
                    sgtPopUpTransparant.Checked = False
                End If
                lblTime.ForeColor = Color.FromName(sgtINI.GetStringField("Font", "ForeColor"))
                lblTime.BackColor = Color.FromName(sgtINI.GetStringField("Font", "BackColor"))
                sgtToolTip.SetToolTip(Me.lblTime, FormatDateTime(Now, DateFormat.LongDate))
                Me.Icon = My.Resources.Clock_9
            Case 1 'Alarm
                If sgtINI.GetNumberField("Main", "Transparent") = 1 Then
                    Me.TransparencyKey = Color.FromName(sgtINI.GetStringField("Font", "BackColor"))
                    sgtPopUpTransparant.Checked = True
                Else
                    Me.TransparencyKey = Color.AliceBlue
                    sgtPopUpTransparant.Checked = False
                End If
                lblTime.ForeColor = Color.FromName(sgtINI.GetStringField("Alarm", "ColorFore"))
                lblTime.BackColor = Color.FromName(sgtINI.GetStringField("Alarm", "ColorBack"))
                sgtToolTip.SetToolTip(Me.lblTime, sgtINI.GetStringField("Alarm", "Tekst"))
                Me.Icon = My.Resources.Clock_Alert
            Case Else
        End Select

        Call sgtLayout()

    End Sub

    Private Sub lblTime_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTime.MouseDown
        If e.Button = MouseButtons.Right Then
            sgtPopUp.Show(lblTime, e.Location)
        End If
    End Sub

    Private Sub sgtPopUpAfsluiten_Click(sender As Object, e As EventArgs) Handles sgtPopUpAfsluiten.Click
        Close()
    End Sub

    Private Sub sgtPopUpBovenaan_Click(sender As Object, e As EventArgs) Handles sgtPopUpBovenaan.Click
        If Me.TopMost = False Then sgtINI.SetStringField("Main", "OnTop", "True") Else sgtINI.SetStringField("Main", "OnTop", "False")
        sgtINI.Save(sgtINIFile)
    End Sub

    Private Sub sgtPopUpBorderAan_Click(sender As Object, e As EventArgs) Handles sgtPopUpBorderAan.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then sgtINI.SetStringField("Main", "TitleBar", "5") Else sgtINI.SetStringField("Main", "TitleBar", "0")
        sgtINI.Save(sgtINIFile)
    End Sub

    Private Sub sgtPopUpAlarm_Click(sender As Object, e As EventArgs) Handles sgtPopUpAlarm.Click
        sgtTimer.Stop()
        frmAlarm.ShowDialog()
        sgtTimer.Start()
    End Sub

    Private Sub sgtPopUpConfiguratie_Click(sender As Object, e As EventArgs) Handles sgtPopUpConfiguratie.Click
        sgtTimer.Stop()
        frmConfig.ShowDialog()
        sgtTimer.Start()
    End Sub

    Private Sub sgtPopUpTransparant_Click(sender As Object, e As EventArgs) Handles sgtPopUpTransparant.Click
        If sgtPopUpTransparant.Checked = True Then
            sgtINI.SetNumberField("Main", "Transparent", 0)
            Me.TransparencyKey = Color.AliceBlue
        Else
            sgtINI.SetNumberField("Main", "Transparent", 1)
            Me.TransparencyKey = Color.FromName(sgtINI.GetStringField("Font", "BackColor"))
        End If
        sgtINI.Save(sgtINIFile)
    End Sub

    Private Sub sgtPopUpAftellen_Click(sender As Object, e As EventArgs) Handles sgtPopUpAftellen.Click
        If sgtPopUpAftellen.Checked = True Then
            sgtPopUpAftellen.Checked = False
            frmCountDown.Close()
        Else
            sgtPopUpAftellen.Checked = True
            frmCountDown.Show()
        End If
    End Sub
End Class
