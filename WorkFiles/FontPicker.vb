Private Sub mnuTestVariabel_Click(sender As Object, e As EventArgs) Handles mnuTestVariabel.Click
	'Nieuw formulier aanmaken
	Dim frmFontPicker As New Form
	frmFontPicker.Name = "frmFontPicker"
	frmFontPicker.Text = "Kies een nieuw lettertype:"
	frmFontPicker.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
	'frmFontPicker.Icon = My.Resources.Series
	frmFontPicker.StartPosition = 1

	'Controls aanmaken
	Dim butOK As New Button
	Dim butCancel As New Button
	Dim lblChooseFont As New Label
	Dim cmbChooseFont As New ComboBox
	Dim lblChooseSize As New Label
	Dim cmbChooseSize As New ComboBox
	Dim lblChooseStyle As New Label
	Dim cmbChooseStyle As New ComboBox
	'dim lblChooseColor as New label
	'dim cpFont as New ColorDialog
	Dim lblExample As New Label

	'Controls invullen
	butOK.Text = "Kiezen"
	butOK.Visible = True
	butOK.Size = New Size(100, 27)
	AddHandler butOK.Click, Sub(s, e2)

							End Sub

	butCancel.Text = "Kiezen"
	butCancel.Visible = True
	butCancel.Size = New Size(100, 27)
	AddHandler butCancel.Click, Sub(s, e2)
									frmFontPicker.Close()
								End Sub

	lblChooseFont.AutoSize = True
	lblChooseFont.Text = "Kies lettertype"
	lblChooseFont.MaximumSize = New Size(300, 17)
	cmbChooseFont.Size = New Size(200, 24)

	lblChooseSize.AutoSize = True
	lblChooseSize.Text = "Kies afmeting:"
	lblChooseSize.MaximumSize = New Size(300, 17)
	cmbChooseFont.Size = New Size(80, 24)

	lblChooseStyle.AutoSize = True
	lblChooseStyle.Text = "Kies stijl:"
	lblChooseStyle.MaximumSize = New Size(300, 17)
	cmbChooseStyle.Size = New Size(80, 24)

	'Controls toevoegen aan formulier
	frmFontPicker.Controls.Add(butOK)
	frmFontPicker.Controls.Add(butCancel)
	frmFontPicker.Controls.Add(lblChooseFont)
	frmFontPicker.Controls.Add(cmbChooseFont)
	frmFontPicker.Controls.Add(lblChooseSize)
	frmFontPicker.Controls.Add(cmbChooseSize)
	frmFontPicker.Controls.Add(lblChooseStyle)
	frmFontPicker.Controls.Add(cmbChooseStyle)
	frmFontPicker.Controls.Add(lblExample)

	'Formulier openen
	frmFontPicker.ShowDialog()
end sub