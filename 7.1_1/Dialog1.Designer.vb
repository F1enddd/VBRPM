<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(277, 271)
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
        Me.ButtonAddPosts.Location = New System.Drawing.Point(216, 234)
        Me.ButtonAddPosts.Name = "ButtonAddPosts"
        Me.ButtonAddPosts.Size = New System.Drawing.Size(67, 21)
        Me.ButtonAddPosts.TabIndex = 41
        Me.ButtonAddPosts.Text = "Добавить"
        '
        'ButtonAddDepartaments
        '
        Me.ButtonAddDepartaments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAddDepartaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddDepartaments.Location = New System.Drawing.Point(216, 169)
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
        Me.FIOText.Size = New System.Drawing.Size(414, 20)
        Me.FIOText.TabIndex = 32
        '
        'Dialog1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.TableLayoutPanel2)
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
End Class
