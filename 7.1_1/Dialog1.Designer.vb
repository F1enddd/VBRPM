<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dialog1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ButtonAddPosts = New System.Windows.Forms.Button()
        Me.ButtonAddDepartaments = New System.Windows.Forms.Button()
        Me.PostSelect = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepartamentsSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BirthdayDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelFIO = New System.Windows.Forms.Label()
        Me.FIOText = New System.Windows.Forms.TextBox()
        Me.PicBoxAOC = New System.Windows.Forms.PictureBox()
        Me.PicButton = New System.Windows.Forms.Button()
        Me.FileNameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonDopImages = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(398, 272)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel2.TabIndex = 31
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ОК"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Отмена"
        '
        'ButtonAddPosts
        '
        Me.ButtonAddPosts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAddPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddPosts.Location = New System.Drawing.Point(213, 234)
        Me.ButtonAddPosts.Name = "ButtonAddPosts"
        Me.ButtonAddPosts.Size = New System.Drawing.Size(67, 21)
        Me.ButtonAddPosts.TabIndex = 41
        Me.ButtonAddPosts.Text = "Добавить"
        '
        'ButtonAddDepartaments
        '
        Me.ButtonAddDepartaments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAddDepartaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddDepartaments.Location = New System.Drawing.Point(213, 169)
        Me.ButtonAddDepartaments.Name = "ButtonAddDepartaments"
        Me.ButtonAddDepartaments.Size = New System.Drawing.Size(67, 21)
        Me.ButtonAddDepartaments.TabIndex = 40
        Me.ButtonAddDepartaments.Text = "Добавить"
        '
        'PostSelect
        '
        Me.PostSelect.DisplayMember = "Title"
        Me.PostSelect.FormattingEnabled = True
        Me.PostSelect.Location = New System.Drawing.Point(14, 234)
        Me.PostSelect.Name = "PostSelect"
        Me.PostSelect.Size = New System.Drawing.Size(196, 21)
        Me.PostSelect.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Должность"
        '
        'DepartamentsSelect
        '
        Me.DepartamentsSelect.DisplayMember = "Title"
        Me.DepartamentsSelect.FormattingEnabled = True
        Me.DepartamentsSelect.Location = New System.Drawing.Point(14, 169)
        Me.DepartamentsSelect.Name = "DepartamentsSelect"
        Me.DepartamentsSelect.Size = New System.Drawing.Size(196, 21)
        Me.DepartamentsSelect.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Отдел"
        '
        'BirthdayDate
        '
        Me.BirthdayDate.Location = New System.Drawing.Point(10, 97)
        Me.BirthdayDate.Name = "BirthdayDate"
        Me.BirthdayDate.Size = New System.Drawing.Size(200, 20)
        Me.BirthdayDate.TabIndex = 35
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(11, 77)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(86, 13)
        Me.LabelDate.TabIndex = 34
        Me.LabelDate.Text = "Дата рождения"
        '
        'LabelFIO
        '
        Me.LabelFIO.AutoSize = True
        Me.LabelFIO.Location = New System.Drawing.Point(11, 14)
        Me.LabelFIO.Name = "LabelFIO"
        Me.LabelFIO.Size = New System.Drawing.Size(34, 13)
        Me.LabelFIO.TabIndex = 33
        Me.LabelFIO.Text = "ФИО"
        '
        'FIOText
        '
        Me.FIOText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FIOText.Location = New System.Drawing.Point(10, 33)
        Me.FIOText.Name = "FIOText"
        Me.FIOText.Size = New System.Drawing.Size(270, 20)
        Me.FIOText.TabIndex = 32
        '
        'PicBoxAOC
        '
        Me.PicBoxAOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxAOC.Location = New System.Drawing.Point(410, 23)
        Me.PicBoxAOC.Name = "PicBoxAOC"
        Me.PicBoxAOC.Size = New System.Drawing.Size(131, 158)
        Me.PicBoxAOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxAOC.TabIndex = 42
        Me.PicBoxAOC.TabStop = False
        '
        'PicButton
        '
        Me.PicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PicButton.Location = New System.Drawing.Point(410, 188)
        Me.PicButton.Name = "PicButton"
        Me.PicButton.Size = New System.Drawing.Size(131, 23)
        Me.PicButton.TabIndex = 43
        Me.PicButton.Text = "Обзор"
        Me.PicButton.UseVisualStyleBackColor = True
        '
        'FileNameTB
        '
        Me.FileNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileNameTB.Location = New System.Drawing.Point(410, 217)
        Me.FileNameTB.Name = "FileNameTB"
        Me.FileNameTB.Size = New System.Drawing.Size(134, 20)
        Me.FileNameTB.TabIndex = 44
        Me.FileNameTB.Tag = ""
        Me.FileNameTB.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Файл"
        '
        'ButtonDopImages
        '
        Me.ButtonDopImages.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDopImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDopImages.Location = New System.Drawing.Point(410, 243)
        Me.ButtonDopImages.Name = "ButtonDopImages"
        Me.ButtonDopImages.Size = New System.Drawing.Size(131, 21)
        Me.ButtonDopImages.TabIndex = 41
        Me.ButtonDopImages.Text = "Доп. изображения"
        '
        'Dialog1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 316)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FileNameTB)
        Me.Controls.Add(Me.PicButton)
        Me.Controls.Add(Me.PicBoxAOC)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ButtonDopImages)
        Me.Controls.Add(Me.ButtonAddPosts)
        Me.Controls.Add(Me.ButtonAddDepartaments)
        Me.Controls.Add(Me.PostSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DepartamentsSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BirthdayDate)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelFIO)
        Me.Controls.Add(Me.FIOText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PicBoxAOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonAddPosts As Button
    Friend WithEvents ButtonAddDepartaments As Button
    Friend WithEvents PostSelect As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartamentsSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BirthdayDate As DateTimePicker
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelFIO As Label
    Friend WithEvents FIOText As TextBox
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents PicBoxAOC As PictureBox
    Friend WithEvents PicButton As Button
    Friend WithEvents FileNameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonDopImages As Button
End Class
