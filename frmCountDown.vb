Public Class frmCountDown
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(frmMain.sgtCountDown)
    Public Property sgtINI As New Ini
    Public Property sgtINIFile As String = frmMain.sgtINIFile
    Public Property sgtColorID As Integer = 0

#Region " Move Form "
    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point


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

    Public Sub sgtLayout()
        lblTime.Location = New Point(0, 0)
        Me.FormBorderStyle = sgtINI.GetStringField("Main", "TitleBar")
        Select Case Me.FormBorderStyle
            Case 5 'FixedToolWindow
                Me.Height = lblTime.Bottom + 40
                Me.Width = lblTime.Right + 17
            Case 0 'None
                Me.Height = lblTime.Bottom
                Me.Width = lblTime.Right
        End Select
        Me.TopMost = sgtINI.GetStringField("Main", "OnTop")
        Me.ShowInTaskbar = True
        Me.Top = sgtINI.GetNumberField("Counter", "Top")
        Me.Left = sgtINI.GetNumberField("Counter", "Left")
    End Sub

    Private Sub frmCountDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sgtINI = New Ini
        sgtINI.Load(sgtINIFile)

        'Layout
        lblTime.Text = "0" & frmMain.sgtCountDown & ":00"
        lblTime.Font = frmMain.lblTime.Font
        lblTime.ForeColor = frmMain.lblTime.ForeColor
        lblTime.BackColor = frmMain.lblTime.BackColor
        Me.Icon = My.Resources.Clock_9
        Call sgtLayout()

        'Timersettings en starten
        tmrCountdown.Interval = 500
        TargetDT = DateTime.Now.Add(CountDownFrom)
        tmrCountdown.Start()
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As System.EventArgs) Handles tmrCountdown.Tick
        Dim intAlarmType As Integer = 0 'Trigger voor alarm "1minuut" of "30seconden"
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            lblTime.Text = ts.ToString("mm\:ss")
            Dim strFirstPart As String = Microsoft.VisualBasic.Right(Trim(ts.ToString("mm\:ss").Split(":").First()), 1)

            Dim ca As Integer
            Dim s As Integer = Microsoft.VisualBasic.Right(Second(Now), 1)
            ca = s Mod 2
            If ca = 0 Then sgtColorID = 0 Else sgtColorID = 1

            If strFirstPart <= 0 Then
                If Trim(ts.ToString("mm\:ss").Split(":").Last()) <= 30 Then
                    intAlarmType = 30
                Else
                    intAlarmType = 1
                End If
            Else
                sgtColorID = 0
                intAlarmType = 0
            End If

            Select Case sgtColorID
                Case 0 'Standaard kleuren
                    lblTime.BackColor = Color.FromName(sgtINI.GetStringField("Font", "BackColor"))
                Case 1 'Alarm
                    If intAlarmType = 1 Then lblTime.BackColor = Color.FromName(sgtINI.GetStringField("Counter", "1minColor"))
                    If intAlarmType = 30 Then lblTime.BackColor = Color.FromName(sgtINI.GetStringField("Counter", "30secColor"))
                Case Else
            End Select
        Else 'timer bereikt 0
            lblTime.Text = "00:00"
            tmrCountdown.Stop()
        End If
    End Sub

    Private Sub frmCountDown_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        sgtINI.SetNumberField("Counter", "Top", Me.Top)
        sgtINI.SetNumberField("Counter", "Left", Me.Left)
        sgtINI.Save(sgtINIFile)
        frmMain.sgtPopUpAftellen.Checked = False
    End Sub

    Private Sub lblTime_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTime.MouseUp
        If e.Button = MouseButtons.Right Then
            CounterPopUp.Show(lblTime, e.Location)
        End If
    End Sub

    Private Sub CounterPopUpHerstart_Click(sender As Object, e As EventArgs) Handles CounterPopUpHerstart.Click
        tmrCountdown.Stop()
        lblTime.Text = "0" & sgtINI.GetNumberField("Counter", "CountDownTime") & ":00"
        TargetDT = DateTime.Now.Add(CountDownFrom)
        tmrCountdown.Start()
    End Sub

    Private Sub CounterPopUpAfsluiten_Click(sender As Object, e As EventArgs) Handles CounterPopUpAfsluiten.Click
        Me.Close()
    End Sub

    Private Sub CounterPopUpOpenenClock_Click(sender As Object, e As EventArgs) Handles CounterPopUpOpenenClock.Click
        frmMain.Show()
        CounterPopUpOpenenClock.Enabled = False
    End Sub
End Class